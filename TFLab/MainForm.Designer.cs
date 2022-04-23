
namespace Compiler
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsСancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRepeat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsText = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГраматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCallingHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.bNew = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCut = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bPaste = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spliter = new System.Windows.Forms.SplitContainer();
            this.tbCode = new System.Windows.Forms.RichTextBox();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spliter)).BeginInit();
            this.spliter.Panel1.SuspendLayout();
            this.spliter.Panel2.SuspendLayout();
            this.spliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsEdit,
            this.tsText,
            this.tsStart,
            this.tsHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCreate,
            this.tsOpen,
            this.tsSave,
            this.tsSaveAs,
            this.tsExit});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(59, 24);
            this.tsFile.Text = "Файл";
            // 
            // tsCreate
            // 
            this.tsCreate.Name = "tsCreate";
            this.tsCreate.Size = new System.Drawing.Size(192, 26);
            this.tsCreate.Text = "Создать";
            this.tsCreate.Click += new System.EventHandler(this.tsCreate_Click);
            // 
            // tsOpen
            // 
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(192, 26);
            this.tsOpen.Text = "Открыть";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // tsSave
            // 
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(192, 26);
            this.tsSave.Text = "Сохранить";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsSaveAs
            // 
            this.tsSaveAs.Name = "tsSaveAs";
            this.tsSaveAs.Size = new System.Drawing.Size(192, 26);
            this.tsSaveAs.Text = "Сохранить как";
            this.tsSaveAs.Click += new System.EventHandler(this.tsSaveAs_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(192, 26);
            this.tsExit.Text = "Выход";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsСancel,
            this.tsRepeat,
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.tsDel,
            this.tsSelect});
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(74, 24);
            this.tsEdit.Text = "Правка";
            // 
            // tsСancel
            // 
            this.tsСancel.Name = "tsСancel";
            this.tsСancel.Size = new System.Drawing.Size(186, 26);
            this.tsСancel.Text = "Отменить";
            this.tsСancel.Click += new System.EventHandler(this.tsСancel_Click);
            // 
            // tsRepeat
            // 
            this.tsRepeat.Name = "tsRepeat";
            this.tsRepeat.Size = new System.Drawing.Size(186, 26);
            this.tsRepeat.Text = "Повторить";
            this.tsRepeat.Click += new System.EventHandler(this.tsRepeat_Click);
            // 
            // tsCut
            // 
            this.tsCut.Name = "tsCut";
            this.tsCut.Size = new System.Drawing.Size(186, 26);
            this.tsCut.Text = "Вырезать";
            this.tsCut.Click += new System.EventHandler(this.tsCut_Click);
            // 
            // tsCopy
            // 
            this.tsCopy.Name = "tsCopy";
            this.tsCopy.Size = new System.Drawing.Size(186, 26);
            this.tsCopy.Text = "Копировать";
            this.tsCopy.Click += new System.EventHandler(this.tsCopy_Click);
            // 
            // tsPaste
            // 
            this.tsPaste.Name = "tsPaste";
            this.tsPaste.Size = new System.Drawing.Size(186, 26);
            this.tsPaste.Text = "Вставить";
            this.tsPaste.Click += new System.EventHandler(this.tsPaste_Click);
            // 
            // tsDel
            // 
            this.tsDel.Name = "tsDel";
            this.tsDel.Size = new System.Drawing.Size(186, 26);
            this.tsDel.Text = "Удалить";
            this.tsDel.Click += new System.EventHandler(this.tsDel_Click);
            // 
            // tsSelect
            // 
            this.tsSelect.Name = "tsSelect";
            this.tsSelect.Size = new System.Drawing.Size(186, 26);
            this.tsSelect.Text = "Выделить все";
            this.tsSelect.Click += new System.EventHandler(this.tsSelect_Click);
            // 
            // tsText
            // 
            this.tsText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияГраматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.tsText.Name = "tsText";
            this.tsText.Size = new System.Drawing.Size(59, 24);
            this.tsText.Text = "Текст";
            // 
            // постановкаToolStripMenuItem
            // 
            this.постановкаToolStripMenuItem.Name = "постановкаToolStripMenuItem";
            this.постановкаToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.постановкаToolStripMenuItem.Text = "Постановка задачи";
            this.постановкаToolStripMenuItem.Click += new System.EventHandler(this.постановкаToolStripMenuItem_Click);
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            this.грамматикаToolStripMenuItem.Click += new System.EventHandler(this.грамматикаToolStripMenuItem_Click);
            // 
            // классификацияГраматикиToolStripMenuItem
            // 
            this.классификацияГраматикиToolStripMenuItem.Name = "классификацияГраматикиToolStripMenuItem";
            this.классификацияГраматикиToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.классификацияГраматикиToolStripMenuItem.Text = "Классификация граматики";
            this.классификацияГраматикиToolStripMenuItem.Click += new System.EventHandler(this.классификацияГраматикиToolStripMenuItem_Click);
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            this.методАнализаToolStripMenuItem.Click += new System.EventHandler(this.методАнализаToolStripMenuItem_Click);
            // 
            // диагностикаИToolStripMenuItem
            // 
            this.диагностикаИToolStripMenuItem.Name = "диагностикаИToolStripMenuItem";
            this.диагностикаИToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.диагностикаИToolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
            this.диагностикаИToolStripMenuItem.Click += new System.EventHandler(this.диагностикаИToolStripMenuItem_Click);
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            this.тестовыйПримерToolStripMenuItem.Click += new System.EventHandler(this.тестовыйПримерToolStripMenuItem_Click);
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            this.списокЛитературыToolStripMenuItem.Click += new System.EventHandler(this.списокЛитературыToolStripMenuItem_Click);
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            this.исходныйКодПрограммыToolStripMenuItem.Click += new System.EventHandler(this.исходныйКодПрограммыToolStripMenuItem_Click);
            // 
            // tsStart
            // 
            this.tsStart.Name = "tsStart";
            this.tsStart.Size = new System.Drawing.Size(55, 24);
            this.tsStart.Text = "Пуск";
            this.tsStart.Click += new System.EventHandler(this.tsStart_Click);
            // 
            // tsHelp
            // 
            this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCallingHelp,
            this.tsAbout});
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(81, 24);
            this.tsHelp.Text = "Справка";
            // 
            // tsCallingHelp
            // 
            this.tsCallingHelp.Name = "tsCallingHelp";
            this.tsCallingHelp.Size = new System.Drawing.Size(197, 26);
            this.tsCallingHelp.Text = "Вызов справки";
            this.tsCallingHelp.Click += new System.EventHandler(this.tsCallingHelp_Click);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(197, 26);
            this.tsAbout.Text = "О программе";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // bNew
            // 
            this.bNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNew.BackgroundImage")));
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bNew.Location = new System.Drawing.Point(27, 31);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(50, 50);
            this.bNew.TabIndex = 4;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bOpen
            // 
            this.bOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOpen.BackgroundImage")));
            this.bOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bOpen.Location = new System.Drawing.Point(81, 31);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(50, 50);
            this.bOpen.TabIndex = 5;
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSave.BackgroundImage")));
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSave.Location = new System.Drawing.Point(135, 31);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(50, 50);
            this.bSave.TabIndex = 7;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCut
            // 
            this.bCut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCut.BackgroundImage")));
            this.bCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bCut.Location = new System.Drawing.Point(450, 31);
            this.bCut.Name = "bCut";
            this.bCut.Size = new System.Drawing.Size(50, 50);
            this.bCut.TabIndex = 8;
            this.bCut.UseVisualStyleBackColor = true;
            this.bCut.Click += new System.EventHandler(this.bCut_Click);
            // 
            // bRight
            // 
            this.bRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRight.BackgroundImage")));
            this.bRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bRight.Location = new System.Drawing.Point(324, 31);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(50, 50);
            this.bRight.TabIndex = 9;
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bLeft
            // 
            this.bLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bLeft.BackgroundImage")));
            this.bLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bLeft.Location = new System.Drawing.Point(260, 31);
            this.bLeft.MinimumSize = new System.Drawing.Size(50, 50);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(50, 50);
            this.bLeft.TabIndex = 10;
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bPaste
            // 
            this.bPaste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bPaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPaste.BackgroundImage")));
            this.bPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPaste.Location = new System.Drawing.Point(513, 31);
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(50, 50);
            this.bPaste.TabIndex = 11;
            this.bPaste.UseVisualStyleBackColor = true;
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // bCopy
            // 
            this.bCopy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCopy.BackgroundImage")));
            this.bCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bCopy.Location = new System.Drawing.Point(387, 31);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(50, 50);
            this.bCopy.TabIndex = 12;
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Код";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Результат компиляции";
            this.label2.Visible = false;
            // 
            // spliter
            // 
            this.spliter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spliter.Location = new System.Drawing.Point(12, 105);
            this.spliter.Name = "spliter";
            this.spliter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spliter.Panel1
            // 
            this.spliter.Panel1.Controls.Add(this.tbCode);
            // 
            // spliter.Panel2
            // 
            this.spliter.Panel2.Controls.Add(this.tbResult);
            this.spliter.Panel2.Controls.Add(this.label2);
            this.spliter.Size = new System.Drawing.Size(776, 458);
            this.spliter.SplitterDistance = 293;
            this.spliter.TabIndex = 16;
            this.spliter.Visible = false;
            // 
            // tbCode
            // 
            this.tbCode.AcceptsTab = true;
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCode.Location = new System.Drawing.Point(0, 0);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(774, 291);
            this.tbCode.TabIndex = 17;
            this.tbCode.Text = "";
            this.tbCode.Visible = false;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(0, 0);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(774, 159);
            this.tbResult.TabIndex = 16;
            this.tbResult.Text = "";
            this.tbResult.Visible = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spliter);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bPaste);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bCut);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "MainForm";
            this.Text = "Compiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spliter.Panel1.ResumeLayout(false);
            this.spliter.Panel2.ResumeLayout(false);
            this.spliter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spliter)).EndInit();
            this.spliter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsText;
        private System.Windows.Forms.ToolStripMenuItem tsStart;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.ToolStripMenuItem tsCreate;
        private System.Windows.Forms.ToolStripMenuItem tsOpen;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem tsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsСancel;
        private System.Windows.Forms.ToolStripMenuItem tsRepeat;
        private System.Windows.Forms.ToolStripMenuItem tsCut;
        private System.Windows.Forms.ToolStripMenuItem tsCopy;
        private System.Windows.Forms.ToolStripMenuItem tsPaste;
        private System.Windows.Forms.ToolStripMenuItem tsDel;
        private System.Windows.Forms.ToolStripMenuItem tsSelect;
        private System.Windows.Forms.ToolStripMenuItem постановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификацияГраматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCallingHelp;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCut;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bPaste;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer spliter;
        private System.Windows.Forms.RichTextBox tbCode;
        private System.Windows.Forms.RichTextBox tbResult;
    }
}

