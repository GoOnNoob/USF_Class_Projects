using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2
{
    public partial class Gameboard : Form
    {
        Random num = new Random();
        List<int> guessNum = new List<int>();
        List<int> bankNum = new List<int>();
        int n1;

        public Gameboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            //n1 = Convert.ToInt32(textBox1.Text);
            //MessageBox.Show(n1.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result rf = new Result();
            rf.Show();
        }

        private void label4_click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this is where the text i think is saved from the text box
            button1.Enabled = true;
            //MessageBox.Show(textBox1.Text);
            //int n1 = Convert.ToInt32(textBox1.Text);
            //MessageBox.Show(n1.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int newNum = num.Next(1, 6);
            label1.Text = newNum.ToString();
            n1 = Convert.ToInt32(textBox1.Text);
            if(newNum == n1)
            {
                //MessageBox.Show("Same");

            }
            else
            {
                //MessageBox.Show("Not Same");
            }
        }
    }
}
