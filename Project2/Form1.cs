namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fruitMatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fruit = new FormFruit();
            fruit.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frogCatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frogger = new FormFrog();
            frogger.ShowDialog();
        }
    }
}
