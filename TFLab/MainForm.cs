using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TFLab;

//сохранение
//справка в пдф

/*Возможные будущие изменения*/
//доделать подсветку синтаксиса
//нумерация строк
// индикатор сохранённости 
//по щелчку на ошибку, указывать строку в коде
//изменение во время работы программы размера области кода и результатов
//при изменении кода, файл становится не сохранённым (флаг) - поправаить при созданнии/открытии файла isSave = true;
// System.ComponentModel.Win32Exception: "Ошибка при создании дескриптора окна.

namespace Compiler
{
    public partial class MainForm : Form
    {
        ToolTip[] tips = new ToolTip[8];
        string currentOpenFile = string.Empty;
        string lastComand = string.Empty;
        bool isSave = false;
        public MainForm()
        {
            InitializeComponent();
            initTips();
        }
        public MainForm(string fileName)
        {
            InitializeComponent();
            initTips();
            SettingOpen(fileName);
        }

        void initTips()
        {
            KeyPreview = true;

            tips[0] = new ToolTip();
            tips[0].SetToolTip(bPaste, "Вставить");
            tips[1] = new ToolTip();
            tips[1].SetToolTip(bCut, "Вырезать");
            tips[2] = new ToolTip();
            tips[2].SetToolTip(bSave, "Сохранить");
            tips[3] = new ToolTip();
            tips[3].SetToolTip(bOpen, "Открыть");
            tips[4] = new ToolTip();
            tips[4].SetToolTip(bCopy, "Копировать");
            tips[5] = new ToolTip();
            tips[5].SetToolTip(bNew, "Создать новый файл");
            tips[6] = new ToolTip();
            tips[6].SetToolTip(bRight, "Вперёд");
            tips[7] = new ToolTip();
            tips[7].SetToolTip(bLeft, "Назад");
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            SaveInFile();
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            CreateFile();
        }
        private void tsCreate_Click(object sender, EventArgs e)
        {
            CreateFile();
        }
        private void tsOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        void SaveInFile()
        {
            if (!isSave && currentOpenFile != string.Empty)
            {
                File.WriteAllText(currentOpenFile, tbCode.Text);
                isSave = true;
            }
        }
        void CreateFile()
        {
            SaveFileDialog CreateFileDialog = new SaveFileDialog();
            CreateFileDialog.Title = "Create a file";
            CreateFileDialog.Filter = "CSharpFile|*.cs";
            var pressBut = CreateFileDialog.ShowDialog();

            if (pressBut == DialogResult.OK)
            {
                // если текущий документ не сохранён, то сохраняем
                if (currentOpenFile != string.Empty)
                {
                    if (!isSave)
                        if (MessageBox.Show("У вас есть несохранённые изменения в открытом документе. \nСохранить изменения?", "Сохранить файл?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            SaveInFile();
                    tbCode.Text = String.Empty;
                    tbResult.Text = String.Empty;
                }

                FileStream newFile = new FileStream(CreateFileDialog.FileName, FileMode.Create);
                newFile.Close();
                currentOpenFile = CreateFileDialog.FileName;

                label1.Visible = true;
                label2.Visible = true;
                tbCode.Visible = true;
                tbResult.Visible = true;
                spliter.Visible = true;
                this.Text = "Compiler (" + currentOpenFile + ")";
            }
        }
        void OpenFile()
        {
            if (currentOpenFile != string.Empty)
            {
                if (!isSave)
                    if (MessageBox.Show("У вас есть несохранённые изменения в открытом документе. \nСохранить изменения?", "Сохранить файл?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SaveInFile();
            }

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open a file";
            OFD.Filter = "CharpFile|*.cs";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                SettingOpen(OFD.FileName);
            }
        }
        void SettingOpen(string nameFile)
        {
            SaveInFile();
            currentOpenFile = nameFile;
            tbCode.Text = File.ReadAllText(currentOpenFile);
            isSave = true;
            label1.Visible = true;
            tbCode.Visible = true;
            label2.Visible = true;
            tbResult.Visible = true;
            spliter.Visible = true;
            this.Text = "Compiler (" + currentOpenFile + ")";
            //TextColors.AddColor(ref tbCode); 
        }
        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            tbCode.Undo();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            tbCode.Redo();
        }

        private void tsСancel_Click(object sender, EventArgs e)
        {
            tbCode.Undo();
        }

        private void tsRepeat_Click(object sender, EventArgs e)
        {
            tbCode.Redo();
        }

        private void tsCut_Click(object sender, EventArgs e)
        {
            tbCode.Cut();
        }

        private void tsCopy_Click(object sender, EventArgs e)
        {
            tbCode.Copy();
        }

        private void tsPaste_Click(object sender, EventArgs e)
        {
            tbCode.Paste();
        }

        private void tsDel_Click(object sender, EventArgs e)
        {
            tbCode.Clear();
        }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            tbCode.SelectAll();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            tbCode.Copy();
        }

        private void bCut_Click(object sender, EventArgs e)
        {
            tbCode.Cut();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            tbCode.Paste();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            SaveInFile();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            ExitProg();
        }

        void ExitProg()
        {
            try
            {
                if (currentOpenFile != string.Empty && !isSave)
                    if (MessageBox.Show("У вас есть несохранённые изменения в открытом документе. \nСохранить изменения?", "Сохранить файл?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SaveInFile();
                Environment.Exit(0);
            }
            catch (System.ComponentModel.Win32Exception ex)
            { }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitProg();
        }

        private void tsSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Title = "Save a file";
            SaveFileDialog.Filter = "CSharpFile|*.cs";
            var pressBut = SaveFileDialog.ShowDialog();

            if (pressBut == DialogResult.OK)
            {
                File.WriteAllText(SaveFileDialog.FileName, tbCode.Text);
                isSave = true;
            }
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"..\..\help\aboutProg.html");
            }
            catch
            {
                MessageBox.Show("Не удалось найти файл содержащий сведения о программе!");
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
                SaveInFile();

            if (e.KeyCode == Keys.O && e.Control)
                OpenFile();

            if (e.KeyCode == Keys.N && e.Control)
                CreateFile();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (isFileValid(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (isFileValid(files[0]))
            {
                e.Effect = DragDropEffects.Copy;
                SettingOpen(files[0]);
            }
        }

        private bool isFileValid(string filename)
        {
            //Проверяем, что можем принять такой файл по расширению
            return Path.GetExtension(filename) == ".cs";
        }
        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void OpenMicrosoftWord(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = path;
            Process.Start(startInfo);
        }
        private void tsCallingHelp_Click(object sender, EventArgs e)
        {

            try
            {
                //Process.Start(@"..\..\help\helpStateMachine.html");
                //OpenMicrosoftWord(@"C:\Users\ivan-\source\repos\TFLab\TFLab\help\helpRecursive.docx");
                OpenMicrosoftWord(@"C:\Users\ivan-\source\repos\TFLab\TFLab\help\helpRegex.docx");
            }
            catch
            {
                MessageBox.Show("Не удалось найти файл содержащий справку!");
            }
        }

        private void tsStart_Click(object sender, EventArgs e)
        {
            if (currentOpenFile != null && tbCode.Text != "")
            {
                tbResult.Text = RegexTasks.Task1(tbCode.Text);
                //tbResult.Text = RegexTasks.Task2(tbCode.Text);
                //tbResult.Text = RegexTasks.Task3(tbCode.Text);
                /*RecurciveAnalyzer ra = new RecurciveAnalyzer(tbCode.Text);
                var result = ra.StartAnalyze();
                tbResult.Text = $"Результат проверки введённой строки: {result.Item1}. Порядок разбора: Исходная строка {result.Item2}";//UseStateMachine.StartAnalize(tbCode.Text.Split('\n'));//LexicalAnalyzer.Analysis(tbCode.Text);*/
            }
        }
    }
}
