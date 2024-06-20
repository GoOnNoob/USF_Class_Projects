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
    public partial class FormFruit2 : Form
    {
        Random random = new Random();

        String flip = "Twice";

        int stop_pics = 0;
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int win = 0;
        int loss = 0;

        //Form Fruit2 = new FormFruit2();


        public FormFruit2()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

        }

        private void FormFruit2_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(flip == "Twice")
            {
                timer1.Interval = 500;
                timer2.Interval = 500;
                timer3.Interval = 500;
                flip = "Once";
                button5.Text = "Flip once per second";
            }
            else
            {
                timer1.Interval = 1000;
                timer2.Interval = 1000;
                timer3.Interval = 1000;
                flip = "Twice";
                button5.Text = "Flip twice per second";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stop_pics += 1;
            if (stop_pics == 3 && num1 == num2 && num3 == num2)
            {
                MessageBox.Show("You Win!");
                win += 1;
                this.Text = "Win:" + win + "\tLose:" + loss;
            }
            else if (stop_pics == 3)
            {
                MessageBox.Show("Try Again...");
                loss += 1;
                this.Text = "Win:" + win.ToString() + "\tLose:" + loss.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             num1 = random.Next(0, 4);

            if (num1 == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

            }

            if (num1 == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }

            if (num1 == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }

            if (num1 == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            stop_pics = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             num2 = random.Next(0, 4);

            if (num2 == 0)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;

            }

            if (num2 == 1)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }

            if (num2 == 2)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }

            if (num2 == 3)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
             num3 = random.Next(0, 4);

            if (num3 == 0)
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;

            }

            if (num3 == 1)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
            }

            if (num3 == 2)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
            }

            if (num3 == 3)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            stop_pics += 1;
            if (stop_pics == 3 && num1 == num2 && num3 == num2)
            {
                MessageBox.Show("You Win!");
                win += 1;
                this.Text = "Win:" + win + "\tLose:" + loss;
            }
            else if (stop_pics == 3)
            {
                MessageBox.Show("Try Again...");
                loss += 1;
                this.Text = "Win:" + win.ToString() + "\tLose:" + loss.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            stop_pics += 1;
            if(stop_pics == 3 && num1 == num2 && num3 == num2)
            {
                MessageBox.Show("You Win!");
                win += 1;
                this.Text = "Win:" + win + "\tLose:" + loss;
            }
            else if(stop_pics == 3)
            {
                MessageBox.Show("Try Again...");
                loss += 1;
                this.Text = "Win:" + win.ToString() + "\tLose:" + loss.ToString();
            }
        }
    }
}
