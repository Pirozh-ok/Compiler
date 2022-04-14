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
            int i = 0;
            while(i < str.Length)
            {
                if (str[i] == '/') ;
            }
            return "";
        }
    }
}