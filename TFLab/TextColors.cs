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
        static Dictionary<Color, List<string>> dictColorComands = new Dictionary<Color, List<string>>()
        {
            {Color.Blue, new List<string>()
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
                "using",
                "ref",
                "out"
            } },

            {Color.Purple, new List<string>()
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
            }},

            {Color.Green, new List<string>()
            {
                "Programm",
                "String",
                "Int",
                "Double",
                "Float",
                "List",
                "Array",
            }}
        };
       
        public static void AddColor(ref RichTextBox textBox)
        {
            int i, startCom;

            foreach (var current in dictColorComands)
            {
                foreach (var comand in current.Value)
                {
                    i = 0; 
                    while (true)
                    {
                        startCom = textBox.Text.IndexOf(comand, i);
                        if (startCom == -1) break;
                        i = startCom;
                        while (i < textBox.Text.Length && char.IsLetter(textBox.Text[i]))
                            i++;

                        textBox.Select(startCom, i - startCom);
                        textBox.SelectionColor = current.Key;
                    }
                }
            }
        }
    }
}
