using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Txt_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxEnter.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }


       

        private void файлToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var Писатель = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    Писатель.Write(textBoxEnter.Text);
                    Писатель.Close();
                }
                catch (Exception Ситуация)
                { // отчет о других ошибках
                    MessageBox.Show(Ситуация.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var Читатель = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBoxEnter.Text = Читатель.ReadToEnd();
                Читатель.Close();
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            { // отчет о других ошибках
                MessageBox.Show(Ситуация.Message,
                     "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font(" ",12F);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font(" ", 14F);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font(" ", 16F);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font(" ", 18F);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font(" ", 20F);
        }

        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Times New Roman", 12F);
            label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            label1.Text = "Times New Roman 12pt";
        }

        private void consolasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Consolas", 12F);
            label1.Font = new System.Drawing.Font("Consolas", 12F);
            label1.Text = "Consolas 12pt";
        }

        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Impact", 12F);
            label1.Font = new System.Drawing.Font("Impact", 12F);
            label1.Text = "Impact 12pt";

        }

        private void segoeUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Text = "Segoe UI 12pt";

        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Calibri", 12F);
            label1.Font = new System.Drawing.Font("Calibri", 12F);
            label1.Text = "Calibri 12pt";

        }

        private void timesNewRomanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Times New Roman", 14F);
            label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            label1.Text = "Times New Roman 14pt";
        }

        private void consolasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Consolas", 14F);
            label1.Font = new System.Drawing.Font("Consolas", 14F);
            label1.Text = "Consolas 14pt";
        }

        private void impactToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Impact", 14F);
            label1.Font = new System.Drawing.Font("Impact", 14F);
            label1.Text = "Impact 14pt";

        }

        private void segoeUIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.Text = "Segoe UI 14pt";

        }
        private void calibriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Calibri", 14F);
            label1.Font = new System.Drawing.Font("Calibri", 14F);
            label1.Text = "Calibri 14pt";
        }

        private void calibriToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Calibri", 14F);
            label1.Font = new System.Drawing.Font("Calibri", 14F);
            label1.Text = "Calibri 14pt";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void segoiUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Segoe UI", 16F);
            label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            label1.Text = "Segoe UI 16pt";
        }

        private void timesNewRomanToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Times New Roman", 16F);
            label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            label1.Text = "Times New Roman 16pt";
        }

        private void consolasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Consolas", 16F);
            label1.Font = new System.Drawing.Font("Consolas", 16F);
            label1.Text = "Consolas 16pt";
        }

        private void impactToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Impact", 16F);
            label1.Font = new System.Drawing.Font("Impact", 16F);
            label1.Text = "Impact 16pt";
        }

        private void calibriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBoxEnter.Font = new System.Drawing.Font("Calibri", 16F);
            label1.Font = new System.Drawing.Font("Calibri", 16F);
            label1.Text = "Calibri 16pt";
        }
    }
}
