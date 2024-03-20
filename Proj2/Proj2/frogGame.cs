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
    public partial class frogGame : Form
    {

        Random Random = new Random();
        int score = 0;
        bool clicked = false;

        public frogGame()
        {
            InitializeComponent();
        }

        private void frogGame_Load(object sender, EventArgs e)
        {

        }

        private void frogGame_Click(object sender, EventArgs e)
        {
            score -= 2;
            this.Text = "Score = " + score;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frogButton.Left = Random.Next(0, this.ClientSize.Width - frogButton.Width);

            frogButton.Top = Random.Next(0, this.ClientSize.Height - frogButton.Height);

            if (clicked == false)
            {
                clicked = false;
            }
            else if (clicked == false)
            {
                score -= 1;
                this.Text = "Score = " + score;
                clicked = false;
            }
             
            

        }

        private void frogButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            timer1.Enabled = true;

            score++;
            this.Text = "Score = " + score;

            if (clicked == false);
            {
                clicked = true;
            }
        }
    }
}
