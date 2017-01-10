namespace pro2namespace
{
    partial class MLV
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTemp = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileD = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиВихідніДаніЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиОбчисленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиГрафікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точністьОбчисленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десятихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тисячнихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десятитисячнихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стотисячніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.міліонніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butSaveWord = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pB = new System.Windows.Forms.PictureBox();
            this.rtbP1 = new System.Windows.Forms.RichTextBox();
            this.rtbB1 = new System.Windows.Forms.RichTextBox();
            this.rtbB2 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusXY,
            this.statusTemp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusXY
            // 
            this.statusXY.Name = "statusXY";
            this.statusXY.Size = new System.Drawing.Size(118, 17);
            this.statusXY.Text = "toolStripStatusLabel1";
            // 
            // statusTemp
            // 
            this.statusTemp.Name = "statusTemp";
            this.statusTemp.Size = new System.Drawing.Size(0, 17);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(71, 17);
            this.Status.Text = "AnotherInfo";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileD
            // 
            this.openFileD.FileName = "openFileDialog";
            this.openFileD.Filter = "TXT files|*.txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.звітToolStripMenuItem,
            this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиВихідніДаніЗФайлуToolStripMenuItem,
            this.оновитиОбчисленняToolStripMenuItem,
            this.оновитиГрафікToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F);
            this.файлToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиВихідніДаніЗФайлуToolStripMenuItem
            // 
            this.відкритиВихідніДаніЗФайлуToolStripMenuItem.Name = "відкритиВихідніДаніЗФайлуToolStripMenuItem";
            this.відкритиВихідніДаніЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.відкритиВихідніДаніЗФайлуToolStripMenuItem.Text = "Відкрити вихідні дані з файлу";
            this.відкритиВихідніДаніЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.відкритиВихідніДаніЗФайлуToolStripMenuItem_Click);
            // 
            // оновитиОбчисленняToolStripMenuItem
            // 
            this.оновитиОбчисленняToolStripMenuItem.Name = "оновитиОбчисленняToolStripMenuItem";
            this.оновитиОбчисленняToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.оновитиОбчисленняToolStripMenuItem.Text = "Оновити обчислення";
            this.оновитиОбчисленняToolStripMenuItem.Click += new System.EventHandler(this.оновитиОбчисленняToolStripMenuItem_Click);
            // 
            // оновитиГрафікToolStripMenuItem
            // 
            this.оновитиГрафікToolStripMenuItem.Name = "оновитиГрафікToolStripMenuItem";
            this.оновитиГрафікToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.оновитиГрафікToolStripMenuItem.Text = "Оновити графік";
            this.оновитиГрафікToolStripMenuItem.Click += new System.EventHandler(this.оновитиГрафікToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // звітToolStripMenuItem
            // 
            this.звітToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.точністьОбчисленьToolStripMenuItem});
            this.звітToolStripMenuItem.Name = "звітToolStripMenuItem";
            this.звітToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.звітToolStripMenuItem.Text = "Звіт";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // точністьОбчисленьToolStripMenuItem
            // 
            this.точністьОбчисленьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.десятихToolStripMenuItem,
            this.сотихToolStripMenuItem,
            this.тисячнихToolStripMenuItem,
            this.десятитисячнихToolStripMenuItem,
            this.стотисячніToolStripMenuItem,
            this.міліонніToolStripMenuItem});
            this.точністьОбчисленьToolStripMenuItem.Name = "точністьОбчисленьToolStripMenuItem";
            this.точністьОбчисленьToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.точністьОбчисленьToolStripMenuItem.Text = "Точність обчислень до";
            // 
            // десятихToolStripMenuItem
            // 
            this.десятихToolStripMenuItem.Name = "десятихToolStripMenuItem";
            this.десятихToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.десятихToolStripMenuItem.Text = "Десятих";
            this.десятихToolStripMenuItem.Click += new System.EventHandler(this.десятихToolStripMenuItem_Click);
            // 
            // сотихToolStripMenuItem
            // 
            this.сотихToolStripMenuItem.Name = "сотихToolStripMenuItem";
            this.сотихToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сотихToolStripMenuItem.Text = "Сотих";
            this.сотихToolStripMenuItem.Click += new System.EventHandler(this.сотихToolStripMenuItem_Click);
            // 
            // тисячнихToolStripMenuItem
            // 
            this.тисячнихToolStripMenuItem.Name = "тисячнихToolStripMenuItem";
            this.тисячнихToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.тисячнихToolStripMenuItem.Text = "Тисячних";
            this.тисячнихToolStripMenuItem.Click += new System.EventHandler(this.тисячнихToolStripMenuItem_Click);
            // 
            // десятитисячнихToolStripMenuItem
            // 
            this.десятитисячнихToolStripMenuItem.Name = "десятитисячнихToolStripMenuItem";
            this.десятитисячнихToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.десятитисячнихToolStripMenuItem.Text = "Десятитисячних";
            this.десятитисячнихToolStripMenuItem.Click += new System.EventHandler(this.десятитисячнихToolStripMenuItem_Click);
            // 
            // стотисячніToolStripMenuItem
            // 
            this.стотисячніToolStripMenuItem.Name = "стотисячніToolStripMenuItem";
            this.стотисячніToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.стотисячніToolStripMenuItem.Text = "Стотисячних";
            // 
            // міліонніToolStripMenuItem
            // 
            this.міліонніToolStripMenuItem.Name = "міліонніToolStripMenuItem";
            this.міліонніToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.міліонніToolStripMenuItem.Text = "Міліонних";
            // 
            // розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem
            // 
            this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem.Name = "розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem";
            this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem.Size = new System.Drawing.Size(419, 20);
            this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem.Text = "Розрахунок рівноцінного обміну забудованих земель населених пунктів ";
            this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem.Click += new System.EventHandler(this.розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem_Click);
            // 
            // butSaveWord
            // 
            this.butSaveWord.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butSaveWord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.butSaveWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.butSaveWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butSaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSaveWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSaveWord.Location = new System.Drawing.Point(601, 278);
            this.butSaveWord.Name = "butSaveWord";
            this.butSaveWord.Size = new System.Drawing.Size(187, 58);
            this.butSaveWord.TabIndex = 11;
            this.butSaveWord.Text = "Зберегти звіт";
            this.butSaveWord.UseVisualStyleBackColor = false;
            this.butSaveWord.Click += new System.EventHandler(this.butSaveWord_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(7, 36);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(31, 18);
            this.labelX.TabIndex = 12;
            this.labelX.Text = "X =";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(44, 36);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(214, 40);
            this.textBoxX.TabIndex = 13;
            this.textBoxX.Text = "0 105,55 105,55 0 -2,07";
            this.textBoxX.Click += new System.EventHandler(this.textBoxX_Click);
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(44, 82);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(214, 40);
            this.textBoxY.TabIndex = 21;
            this.textBoxY.Text = "0 0 23,46 23,46 11,73";
            this.textBoxY.Click += new System.EventHandler(this.textBoxY_Click);
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(7, 82);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(30, 18);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Y =";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(7, 215);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(251, 51);
            this.labelDescription.TabIndex = 26;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(601, 50);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(187, 211);
            this.richTextBox.TabIndex = 27;
            this.richTextBox.Text = "";
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUpdateData.Location = new System.Drawing.Point(10, 272);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(248, 64);
            this.buttonUpdateData.TabIndex = 28;
            this.buttonUpdateData.Text = "Оновити дані";
            this.buttonUpdateData.UseVisualStyleBackColor = false;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(44, 134);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(214, 20);
            this.textBoxP1.TabIndex = 29;
            this.textBoxP1.Text = "2500";
            this.textBoxP1.Click += new System.EventHandler(this.textBoxP1_Click);
            this.textBoxP1.TextChanged += new System.EventHandler(this.textBoxChanged);
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(44, 160);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(214, 20);
            this.textBoxB1.TabIndex = 30;
            this.textBoxB1.Text = "20";
            this.textBoxB1.Click += new System.EventHandler(this.textBoxB1_Click);
            this.textBoxB1.TextChanged += new System.EventHandler(this.textBoxChanged);
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(44, 184);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(214, 20);
            this.textBoxB2.TabIndex = 31;
            this.textBoxB2.Text = "38";
            this.textBoxB2.Click += new System.EventHandler(this.textBoxB2_Click);
            this.textBoxB2.TextChanged += new System.EventHandler(this.textBoxChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(598, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Результати обчислень:";
            // 
            // pB
            // 
            this.pB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB.Location = new System.Drawing.Point(275, 36);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(300, 300);
            this.pB.TabIndex = 33;
            this.pB.TabStop = false;
            this.pB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pB_MouseMove);
            // 
            // rtbP1
            // 
            this.rtbP1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtbP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbP1.Location = new System.Drawing.Point(10, 134);
            this.rtbP1.Multiline = false;
            this.rtbP1.Name = "rtbP1";
            this.rtbP1.Size = new System.Drawing.Size(27, 20);
            this.rtbP1.TabIndex = 34;
            this.rtbP1.Text = "P1";
            // 
            // rtbB1
            // 
            this.rtbB1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtbB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbB1.Location = new System.Drawing.Point(10, 160);
            this.rtbB1.Multiline = false;
            this.rtbB1.Name = "rtbB1";
            this.rtbB1.Size = new System.Drawing.Size(27, 20);
            this.rtbB1.TabIndex = 35;
            this.rtbB1.Text = "B1";
            // 
            // rtbB2
            // 
            this.rtbB2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtbB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbB2.Location = new System.Drawing.Point(10, 184);
            this.rtbB2.Multiline = false;
            this.rtbB2.Name = "rtbB2";
            this.rtbB2.Size = new System.Drawing.Size(27, 20);
            this.rtbB2.TabIndex = 36;
            this.rtbB2.Text = "B2";
            // 
            // MLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(811, 365);
            this.Controls.Add(this.rtbB2);
            this.Controls.Add(this.rtbB1);
            this.Controls.Add(this.rtbP1);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB2);
            this.Controls.Add(this.textBoxB1);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.butSaveWord);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(827, 400);
            this.Name = "MLV";
            this.Text = "ВИЗНАЧЕННЯ НАДНОРМАТИВНИХ ПЛОЩ ЗЕМЕЛЬНИХ ДІЛЯНОК ПРОМИСЛОВИХ ПІДПРИЄМСТВ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem звітToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиОбчисленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusXY;
        private System.Windows.Forms.Button butSaveWord;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиГрафікToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точністьОбчисленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десятихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тисячнихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десятитисячнихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиВихідніДаніЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusTemp;
        private System.Windows.Forms.ToolStripMenuItem стотисячніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem міліонніToolStripMenuItem;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.RichTextBox rtbP1;
        private System.Windows.Forms.RichTextBox rtbB1;
        private System.Windows.Forms.RichTextBox rtbB2;
    }
}

