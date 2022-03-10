using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    static class LexicalAnalyzer
    {
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
            {"скобки","12"}
        };
        public static string TextAnalysis(string text)
        {
            return AnalysisStr(text);
        }

        private static string FormatString(string codeWord, string word, int indexStart)
        {
            return codes[codeWord] + " - " + codeWord + " - \"" + word + "\" c " + indexStart.ToString() + " по " + (indexStart + word.Length).ToString() + " символы\r\n";
        }
        private static string AnalysisStr(string str)
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

                    if (word == "int") result += FormatString("ключевое слово", word, indStart);
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

                    result += FormatString("целое без знака", word, indStart);
                }

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

                i++; 
            }

            return result; 
        }
    }
}
