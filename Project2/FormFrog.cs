using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class FormFrog : Form
    {

        Random random = new Random();
        int x = 0;
        int y = 0;
        bool frog_click = false;
        int score = 0;
        int jumps = 0;
        public FormFrog()
        {
            InitializeComponent();
        }

        private void FormFrog_Load(object sender, EventArgs e)
        {

        }

        private void FormFrog_DoubleClick(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Top = 500;
            //button1.Left = 730;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            if(jumps != 0)
            {
                frog_click = true;
            }

            timer1.Start();
            timer2.Start();

            this.Text = "Score: " + score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = random.Next(0, 731);
            y = random.Next(0, 501);

            button1.Left = x;
            button1.Top = y;


            jumps += 1;



        }

        private void FormFrog_Click(object sender, EventArgs e)
        {
            score -= 2;
            this.Text = "Score: " + score.ToString();
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (frog_click == true)
            {
                score += 1;
            }
            if(frog_click == false)
            {
                score -= 1;
            }

            frog_click = false;
            this.Text = "Score: " + score.ToString();
        }
    }
}
