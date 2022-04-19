using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLab
{
    static class LexicalAnalyzer
    {
        static private List<(char, int)> lexems = new List<(char, int)>();
        static private List<string> errors = new List<string>();
        public static (List<(char, int)>, List<string>) Analysis(string[] str)
        {
            lexems.Clear();
            errors.Clear();
            for (int j = 0; j < str.Count(); j++)
            {
                int i = 0;
                if (j != str.Count() - 1) str[j] += '\n';
                while (i < str[j].Length)
                {
                    if (str[j][i] == '(' || str[j][i] == '*' || str[j][i] == ')' || Char.IsDigit(str[j][i]) || Char.IsLetter(str[j][i]) || str[j][i] == '/' || str[j][i] == '\n')
                        lexems.Add((str[j][i], j + 1));
                    else errors.Add($"Строка {j + 1}: неизвестный символ \"{str[j][i]}\"");
                    i++;
                }
            }
            return (lexems, errors);
        }
    }
}