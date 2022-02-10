using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TFLab
{
    public partial class MainForm : Form
    {
        ToolTip[] tips = new ToolTip[8];
        string currentOpenFile = string.Empty;
        bool isSave = false; 
    public MainForm()
        {
            InitializeComponent();
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            
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
                //FileStream file = new FileStream(currentOpenFile, FileMode.Open);
                //byte[] arr = System.Text.Encoding.Default.GetBytes(tbCode.Text);
                //file.Write(arr, 0, arr.Length);
                //file.Close();
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
            }    
        }
        void OpenFile()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open a file";
            OFD.Filter = "CharpFile|*.cs";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                SaveInFile();
                currentOpenFile = OFD.FileName;
                tbCode.Text = File.ReadAllText(currentOpenFile);
                label1.Visible = true;
                tbCode.Visible = true;
                label2.Visible = true; 
                tbResult.Visible = true;
            }
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
            Exit(); 
        }

        void Exit()
        {
            if (currentOpenFile != string.Empty && !isSave)
                if (MessageBox.Show("У вас есть несохранённые изменения в открытом документе. \nСохранить изменения?", "Сохранить файл?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveInFile();
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit(); 
        }
    }

}
