using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    static class LexicalAnalyzer
    {
        static private List<string> keyWords = new List<string>() {"int"};
        static private Dictionary<string, string> codes = new Dictionary<string, string>()
        {
            {"ключевое слово","1"},
            {"целое без знака","2"},
            {"идентификатор","3"},
            {"пробел","4"},
            {"конец оператора","5"},
            {"конец строки","6"},
            {"присваивание","7"},
            {"присваивание с умножением","8"},
            {"присваивание с делением","9"},
            {"присваивание с суммой","10"},
            {"присваивание с вычитанием","11"},
            {"комментарий","11"},
            {"открывающая круглая скобка","12"},
            {"закрывающая круглая скобка","12"},
            {"недопустимый символ","-1" }
        };

        private static string FormatString(string codeWord, string word, int indexStart)
        {
            return codes[codeWord] + " - " + codeWord + " - \"" + word + "\" c " + indexStart.ToString() + " по " + (indexStart + word.Length-1).ToString() + " символы\r\n";
        }
        public static string Analysis(string str)
        {
            var result = string.Empty;
            int i = 0, indStart = 0;
            while (i < str.Length)
            {
                if (char.IsLetter(str[i]))
                {
                    string word = string.Empty;
                    indStart = i;
                    while (i < str.Length && char.IsLetterOrDigit(str[i]))
                    {
                        word += str[i];
                        i++;
                    }
                    i = i - 1;
                    if (keyWords.FirstOrDefault(x => x == word) != null) result += FormatString("ключевое слово", word, indStart);
                    else result += FormatString("идентификатор", word, indStart);
                }

                else if (i < str.Length && char.IsDigit(str[i]))
                {
                    string word = string.Empty;
                    indStart = i;
                    while (i < str.Length && char.IsDigit(str[i]))
                    {
                        word += str[i];
                        i++;
                    }
                    i = i - 1;
                    result += FormatString("целое без знака", word, indStart);
                }

                else if (i < str.Length && str[i] == '\n')
                    result += FormatString("конец строки", "\\n", i);

                else if (i < str.Length && str[i] == ' ')
                    result += FormatString("пробел", " ", i);

                else if (i < str.Length && str[i] == ';')
                    result += FormatString("конец оператора", ";", i);

                else if (i < str.Length && str[i] == '=')
                {
                    result += FormatString("присваивание", "=", i);
                    i++;
                }

                else if (i < str.Length && str[i] == '*' && str[i + 1] == '=')
                {
                    result += FormatString("присваивание с умножением", "*=", i);
                    i++;
                }

                else if (i < str.Length && str[i] == '/' && str[i + 1] == '=')
                {
                    result += FormatString("присваивание с делением", "/=", i);
                    i++;
                }

                else if (i < str.Length && str[i] == '+' && str[i + 1] == '=')
                {
                    result += FormatString("присваивание с суммой", "+=", i);
                    i++;
                }

                else if (i < str.Length && str[i] == '-' && str[i + 1] == '=')
                {
                    result += FormatString("присваивание с вычитанием", "-=", i);
                    i++;
                }

                else if (i < str.Length && str[i] == '(')
                    result += FormatString("открывающая круглая скобка", "(", i);

                else if (i < str.Length && str[i] == ')')
                    result += FormatString("закрывающая круглая скобка", ")", i);

                else if (i < str.Length - 1 && str[i] == '/' && str[i + 1] == '*')
                {
                    int index = str.IndexOf("*/", i);
                    if (index == -1)
                        result += FormatString("недопустимый символ", str[i].ToString(), i);
                    else
                    {
                        indStart = i;
                        string comment = str.Substring(indStart, index+2-indStart);
                        i += index + 2 - indStart;
                        result += FormatString("комментарий", comment, indStart);
                    }

                }

                else if (i < str.Length)
                    result += FormatString("недопустимый символ", str[i].ToString(), i);

                i++;
            }

            return result; 
        }
    }
}
