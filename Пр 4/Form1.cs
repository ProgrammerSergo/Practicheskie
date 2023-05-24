using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр_4
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtraheend;

        int multiplicand;
        int multiplied;

        int dividend;
        int divisor;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);


            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtraheend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtraheend.ToString();
            difference.Value = 0;


            multiplicand = randomizer.Next(2, 11);
            multiplied = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplied.ToString();
            product.Value = 0;


            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


            timeLeft = 30;
            timeLabel.Text = "30 секунд";
            timer1.Start();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)

            && (minuend - subtraheend == difference.Value)
            && (multiplicand * multiplied == product.Value)
            && (dividend / divisor == quotient.Value))

                return true;
            else
                return false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Ты правильно ответил на все вопросы!",
                                        "Поздравляю!");
                startButton.Enabled = true;

            }
            else if (timeLeft > 0) 
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " секунд";

            }

            else
            {

                timer1.Stop();
                timeLabel.Text = "Время вышло!";
                MessageBox.Show("Время вышло", "Прости ;( !");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtraheend;
                product.Value = multiplicand * multiplied;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }
    }

}
