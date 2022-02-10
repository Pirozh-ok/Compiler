using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Compiler
{
    static class TextColors
    {
        static List<string> blueComands = new List<string>()
        {
            "int",
            "float",
            "double",
            "string",
            "class",
            "static",
            "void",
            "new",
            "namespace",
            "bool",
            "true",
            "false",
            "null",
            "struct",
            "public",
            "private",
            "protected",
            "abstract",
            "ovveride",
            "using"
        };

        static List<string> purpleComands = new List<string>()
        {
            "if",
            "else",
            "break",
            "return",
            "try",
            "catch",
            "switch",
            "case",
            "default",
        };
        public static void AddColor(ref RichTextBox textBox)
        {
            int i = 0, startCom, endCom;
            string comand;

            while (i < textBox.Text.Length)
            {
                startCom = i;
                comand = string.Empty;
                while (i < textBox.Text.Length && Char.IsLetter(textBox.Text[i]))
                {
                    comand += textBox.Text[i];
                    i++;
                }
                endCom = i;
                if (blueComands.FirstOrDefault(x => x == comand) != null)
                {
                    textBox.Select(startCom, endCom - startCom + 1);
                    textBox.SelectionColor = Color.Blue;
                }
                else if (purpleComands.FirstOrDefault(x => x == comand) != null)
                {
                    textBox.Select(startCom, endCom - startCom + 1);
                    textBox.SelectionColor = Color.Purple;
                }

                i++;
            }
        }
    }
}
