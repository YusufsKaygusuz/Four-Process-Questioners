using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Calculate
{
    public partial class Form1 : Form
    {
        Random r;
        double result;
        int timeLeft = 10;
       
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomProblem();
            LabelTimeLeft.Text = "Time Left: " + timeLeft.ToString();
        }

        private void RandomProblem()
        {
            int number1 = r.Next(1,1001);
            int number2 = r.Next(1, 1001);

            Number1Label.Text = number1.ToString();
            Number2Label.Text = number2.ToString();

            int transaction = r.Next(1, 5);
            if(transaction == 1)
            {
                OpenadLabel.Text = "+";
                result = number1 + number2;
            }
            if (transaction == 2)
            {
                OpenadLabel.Text = "-";
                result = number1 - number2;
            }
            if (transaction == 3)
            {
                OpenadLabel.Text = "X";
                result = number1 * number2;
            }
            if (transaction == 4)
            {
                OpenadLabel.Text = "/";
                result = number1 / number2;
            }
        }

        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            LabelTimeLeft.Text = "Time Left: " + (--timeLeft).ToString();

            if (timeLeft == 0)
            {
                TimerCountDown.Stop();
                DialogResult dr = MessageBox.Show("Sorry, Play again?",
                    "Time is over.",
                    MessageBoxButtons.YesNo);


                if (dr == DialogResult.Yes)
                {
                    startAgain();
                }
                else
                {
                    this.Close();

                }
            }
        }

        private void startAgain()
        {
            TimerCountDown.Start();
            timeLeft = 100;
            RandomProblem();
            LabelTimeLeft.Text = "Time Left: " + timeLeft.ToString();
            TextB_Result.Text = "";
        }

        private void TextB_Result_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int UserAnswer = Convert.ToInt32(TextB_Result.Text);
                CheckTheResult(UserAnswer);
            }
        }

        private void CheckTheResult(int Answer)
        {
            if(Answer == result)
            {
                DialogResult dr = MessageBox.Show("Congratulations... Wanna Play Again?" ,"Thanks", MessageBoxButtons.YesNo);

                if(dr == DialogResult.Yes)
                {
                    startAgain();
                }
                else
                {
                    this.Close();
                }
            }
            TextB_Result.Text = "";
        }

    }
}
