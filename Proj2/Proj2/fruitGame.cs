using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2
{
    public partial class fruitGame : Form
    {

        Random random = new Random();
        int num1, num2, num3;
        bool speedFast = true;

        int firstRun = 0;
        int wins = 0;
        int losses = 0;


        public fruitGame()
        {
            InitializeComponent();
        }

        private void fruitGame_Load(object sender, EventArgs e)
        {

        }

        private void fruitGame_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            if (speedFast == true)
            {
                timer1.Interval = 500;
                timer2.Interval = 500;
                timer3.Interval = 500;

                flipButton.Text = "Flip once per second";
                speedFast = true;
            }
            else if (speedFast == false)
            {
                timer1.Interval = 1000;
                timer2.Interval = 1000;
                timer3.Interval = 1000;

                flipButton.Text = "Flip twice per second";
                speedFast = true;
            }
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;

            if (firstRun == 0)
            {
                this.Text = $"Win: {wins}   Lose: {losses}";
                firstRun = 1;
            }
        }

        private void stopFruit1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            if (firstRun == 1)
                checkwin();
        }

        private void stopFruit2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            if (firstRun == 1)
                checkwin();
        }

        private void stopFruit3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            if (firstRun == 1)
                checkwin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num1 = random.Next(1, 4);

            if (num1 == 1)
            {
                wMelon1.Visible = true;
                ban1.Visible = false;
                cher1.Visible = false;
                ora1.Visible = false;
            }
            else if (num1 == 2)
            {
                wMelon1.Visible = false;
                ban1.Visible = false;
                cher1.Visible = false;
                ora1.Visible = true;
            }
            else if (num1 == 3)
            {
                wMelon1.Visible = false;
                ban1.Visible = false;
                cher1.Visible = true;
                ora1.Visible = false;
            }
            else if (num1 == 4)
            {
                wMelon1.Visible = false;
                ban1.Visible = true;
                cher1.Visible = false;
                ora1.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            num2 = random.Next(1, 4);

            if (num2 == 1)
            {
                wMelon2.Visible = true;
                ban2.Visible = false;
                cher2.Visible = false;
                ora2.Visible = false;
            }
            else if (num2 == 2)
            {
                wMelon2.Visible = false;
                ban2.Visible = false;
                cher2.Visible = false;
                ora2.Visible = true;
            }
            else if (num2 == 3)
            {
                wMelon2.Visible = false;
                ban2.Visible = false;
                cher2.Visible = true;
                ora2.Visible = false;
            }
            else if (num2 == 4)
            {
                wMelon2.Visible = false;
                ban2.Visible = true;
                cher2.Visible = false;
                ora2.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            num3 = random.Next(1, 4);

            if (num3 == 1)
            {
                wMelon3.Visible = true;
                ban3.Visible = false;
                cher3.Visible = false;
                ora3.Visible = false;
            }
            else if (num3 == 2)
            {
                wMelon3.Visible = false;
                ban3.Visible = false;
                cher3.Visible = false;
                ora3.Visible = true;
            }
            else if (num3 == 3)
            {
                wMelon3.Visible = false;
                ban3.Visible = false;
                cher3.Visible = true;
                ora3.Visible = false;
            }
            else if (num3 == 4)
            {
                wMelon3.Visible = false;
                ban3.Visible = true;
                cher3.Visible = false;
                ora3.Visible = false;
            }
        }

        private void checkwin()
        {
            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
            {
                if (num1 == num2 && num2 == num3)
                {
                    MessageBox.Show("You win!");
                    wins += 1;
                    this.Text = $"Win: {wins}   Lose: {losses}";
                }
                else
                {
                    MessageBox.Show("Try again...");
                    losses += 1;
                    this.Text = $"Win: {wins}   Lose: {losses}";
                }
            }
        }
    }
}
