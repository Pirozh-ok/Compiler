using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Compiler
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm form = null; 

            if (args != null && args.Length > 0)
            {
                string fileName = args[0];
                //Существует ли файл
                if (System.IO.File.Exists(fileName))
                {
                    form = new MainForm(fileName);
                }
                //Файл не существует
                else
                {
                    MessageBox.Show("File does not exist!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    form = new MainForm();
                }
            }
            //без аргументов
            else
            {
                form = new MainForm();
            }

            Application.Run(form);
        }
    }
}
