namespace Txt_editor
{
    partial class Form1
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
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consolasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.impactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeUIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consolasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.impactToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.segoiUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Font = new System.Drawing.Font("Consolas", 14F);
            this.textBoxEnter.Location = new System.Drawing.Point(0, 48);
            this.textBoxEnter.Multiline = true;
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(1310, 521);
            this.textBoxEnter.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1310, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерToolStripMenuItem});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.размерToolStripMenuItem.Text = "Размер";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.consolasToolStripMenuItem,
            this.impactToolStripMenuItem,
            this.segoeUIToolStripMenuItem,
            this.calibriToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "12";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // consolasToolStripMenuItem
            // 
            this.consolasToolStripMenuItem.Name = "consolasToolStripMenuItem";
            this.consolasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consolasToolStripMenuItem.Text = "Consolas";
            this.consolasToolStripMenuItem.Click += new System.EventHandler(this.consolasToolStripMenuItem_Click_1);
            // 
            // impactToolStripMenuItem
            // 
            this.impactToolStripMenuItem.Name = "impactToolStripMenuItem";
            this.impactToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.impactToolStripMenuItem.Text = "Impact";
            this.impactToolStripMenuItem.Click += new System.EventHandler(this.impactToolStripMenuItem_Click);
            // 
            // segoeUIToolStripMenuItem
            // 
            this.segoeUIToolStripMenuItem.Name = "segoeUIToolStripMenuItem";
            this.segoeUIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.segoeUIToolStripMenuItem.Text = "Segoe UI";
            this.segoeUIToolStripMenuItem.Click += new System.EventHandler(this.segoeUIToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.calibriToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem1,
            this.consolasToolStripMenuItem1,
            this.impactToolStripMenuItem1,
            this.segoeUIToolStripMenuItem1,
            this.calibriToolStripMenuItem1});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "14";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // timesNewRomanToolStripMenuItem1
            // 
            this.timesNewRomanToolStripMenuItem1.Name = "timesNewRomanToolStripMenuItem1";
            this.timesNewRomanToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.timesNewRomanToolStripMenuItem1.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem1.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem1_Click);
            // 
            // consolasToolStripMenuItem1
            // 
            this.consolasToolStripMenuItem1.Name = "consolasToolStripMenuItem1";
            this.consolasToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.consolasToolStripMenuItem1.Text = "Consolas";
            this.consolasToolStripMenuItem1.Click += new System.EventHandler(this.consolasToolStripMenuItem1_Click);
            // 
            // impactToolStripMenuItem1
            // 
            this.impactToolStripMenuItem1.Name = "impactToolStripMenuItem1";
            this.impactToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.impactToolStripMenuItem1.Text = "Impact";
            this.impactToolStripMenuItem1.Click += new System.EventHandler(this.impactToolStripMenuItem1_Click);
            // 
            // segoeUIToolStripMenuItem1
            // 
            this.segoeUIToolStripMenuItem1.Name = "segoeUIToolStripMenuItem1";
            this.segoeUIToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.segoeUIToolStripMenuItem1.Text = "Segoe UI";
            this.segoeUIToolStripMenuItem1.Click += new System.EventHandler(this.segoeUIToolStripMenuItem1_Click);
            // 
            // calibriToolStripMenuItem1
            // 
            this.calibriToolStripMenuItem1.Name = "calibriToolStripMenuItem1";
            this.calibriToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.calibriToolStripMenuItem1.Text = "Calibri";
            this.calibriToolStripMenuItem1.Click += new System.EventHandler(this.calibriToolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem2,
            this.consolasToolStripMenuItem2,
            this.impactToolStripMenuItem2,
            this.segoiUIToolStripMenuItem,
            this.calibriToolStripMenuItem2});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "16";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // timesNewRomanToolStripMenuItem2
            // 
            this.timesNewRomanToolStripMenuItem2.Name = "timesNewRomanToolStripMenuItem2";
            this.timesNewRomanToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.timesNewRomanToolStripMenuItem2.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem2.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem2_Click);
            // 
            // consolasToolStripMenuItem2
            // 
            this.consolasToolStripMenuItem2.Name = "consolasToolStripMenuItem2";
            this.consolasToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.consolasToolStripMenuItem2.Text = "Consolas";
            this.consolasToolStripMenuItem2.Click += new System.EventHandler(this.consolasToolStripMenuItem2_Click);
            // 
            // impactToolStripMenuItem2
            // 
            this.impactToolStripMenuItem2.Name = "impactToolStripMenuItem2";
            this.impactToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.impactToolStripMenuItem2.Text = "Impact";
            this.impactToolStripMenuItem2.Click += new System.EventHandler(this.impactToolStripMenuItem2_Click);
            // 
            // segoiUIToolStripMenuItem
            // 
            this.segoiUIToolStripMenuItem.Name = "segoiUIToolStripMenuItem";
            this.segoiUIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.segoiUIToolStripMenuItem.Text = "Segoe UI";
            this.segoiUIToolStripMenuItem.Click += new System.EventHandler(this.segoiUIToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem2
            // 
            this.calibriToolStripMenuItem2.Name = "calibriToolStripMenuItem2";
            this.calibriToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.calibriToolStripMenuItem2.Text = "Calibri";
            this.calibriToolStripMenuItem2.Click += new System.EventHandler(this.calibriToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "18";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "20";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1187, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consolas 14pt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segoeUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consolasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem impactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem segoeUIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consolasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem impactToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem segoiUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem2;
    }
}

