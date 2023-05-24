using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ПР_7
{
    public partial class Form1 : Form
    {
        OpenFileDialog OpenDlg = new OpenFileDialog();
        
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Пусто
        }

        //Игры

        private void ВЫЙТИToolStripMenuItem_Click(object sender, EventArgs e)  //Выйти
        {
            Application.Exit();
        }
        private void ОТКРЫТЬToolStripMenuItem_Click(object sender, EventArgs e)  //Открыть
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }

            OpenDlg.Dispose();
        }
        private void СОХРАНИТЬToolStripMenuItem_Click(object sender, EventArgs e) //Сохранить

        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }

            SaveDlg.Dispose();
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-------------------------");

        }
 
        private void Button1_Click(object sender, EventArgs e)
        {
            string selectedSortType = comboBox1.SelectedItem.ToString();
            List<string> items = new List<string>();

            foreach (var item in listBox1.Items)
            { 
                items.Add(item.ToString());  
            }

            switch (selectedSortType) 
            { 
              case "АЛФАВИТ (ПО ВОЗРАСТАНИЮ)": items.Sort(); break;
              case "АЛФАВИТ (ПО УБЫВАНИЮ)":  items.Sort(); items.Reverse(); break;
              case "ДЛИНА СЛОВА (ПО ВОЗРАСТАНИЮ)": items.Sort((x, y) => x.Length.CompareTo(y.Length)); break;
              case "ДЛИНА СЛОВА (ПО УБЫВАНИЮ)":  items.Sort((x, y) => y.Length.CompareTo(x.Length)); break; 
            }

            listBox1.Items.Clear();

            foreach (var item in items)
            {  
                listBox1.Items.Add(item);  
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string selectedSortType = comboBox2.SelectedItem.ToString();

            List<string> items = new List<string>();

            foreach (var item in listBox2.Items)

            {  
                items.Add(item.ToString()); 
            }

            switch (selectedSortType) 

            { 
              case "АЛФАВИТ (ПО ВОЗРАСТАНИЮ)": items.Sort(); break;
              case "АЛФАВИТ (ПО УБЫВАНИЮ)":  items.Sort(); items.Reverse(); break;
              case "ДЛИНА СЛОВА (ПО ВОЗРАСТАНИЮ)": items.Sort((x, y) => x.Length.CompareTo(y.Length)); break;
                case "ДЛИНА СЛОВА (ПО УБЫВАНИЮ)":  items.Sort((x, y) => y.Length.CompareTo(x.Length)); break; 
            }

            listBox2.Items.Clear();

            foreach (var item in items)

            { 
                listBox2.Items.Add(item); 
            }
        }
  
        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.BeginUpdate();

            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }
                
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            String[] ss = new String[0];
            richTextBox1.Lines = ss;

            checkBox1.Checked = false;
            checkBox2.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear(); // очистка

            string Find = textBox1.Text;

            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Addrec = new Form2();
            Addrec.Owner = this;
            Addrec.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            for(int i = listBox1.Items.Count - 1; i>=0;i--)

            {
                if (listBox1.GetSelected(i)) listBox1.Items.RemoveAt(i);
            }

            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.GetSelected(i)) listBox2.Items.RemoveAt(i);
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                string selectedString = listBox1.Items[selectedIndex].ToString();
                listBox2.Items.Add(selectedString);
                listBox1.Items.RemoveAt(selectedIndex);
            }
            else 
            {
                MessageBox.Show(" Пусто "); 
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string item = listBox2.Items[i].ToString();
                listBox1.Items.Add(item);
            }

            listBox2.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string item = listBox1.Items[i].ToString();
                listBox2.Items.Add(item);
            }

            listBox1.Items.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBox2.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBox2.Items.Count)
            {
                string selectedString = listBox2.Items[selectedIndex].ToString();
                listBox1.Items.Add(selectedString);
                listBox2.Items.RemoveAt(selectedIndex);
            }
            else 
            { 
                MessageBox.Show(" Пусто "); 
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //--------------//
        }
    }
}
