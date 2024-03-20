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
    public partial class fruitRules : Form
    {
        public fruitRules()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fruitRules_Load(object sender, EventArgs e)
        {

        }

        private void fruitRules_DoubleClick(object sender, EventArgs e)
        {
            fruitGame fruitGame = new fruitGame();
            fruitGame.ShowDialog(); 
        }
    }
}
