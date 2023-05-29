using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матричный_калькулятор
{
    public partial class Form2 : Form
    {
        public int column { get; set; }
        public int row { get; set; }
        public Form2()
        {
            InitializeComponent();
            
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            // -- Пусть будет 
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Form1 calculator = new Form1();
            column = int.Parse(textBoxColumn.Text);
            row = int.Parse(textBoxRow.Text);
            if (column > calculator.numericColumns_A.Value)
            {
                MessageBox.Show("Количество столбцов " +
                "превышает размерность матрицы!",
                "Ошибочка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Close();
            }
            else if (row > calculator.numericRows_A.Value)
            {
                MessageBox.Show("Количество строк " +
                "превышает размерность матрицы!",
                "Ошибочка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Close();

            }
            else
            {
                Close();
            }
        }
    }
}
