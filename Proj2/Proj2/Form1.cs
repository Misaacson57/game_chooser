namespace Proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemFrogCatching_Click(object sender, EventArgs e)
        {
            frogGame frogGame = new frogGame();
            frogGame.ShowDialog();
        }

        private void menuItemFruitMatching_Click(object sender, EventArgs e)
        {
            fruitRules fruitRules = new fruitRules();
            fruitRules.ShowDialog();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
