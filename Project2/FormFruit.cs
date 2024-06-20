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
    public partial class FormFruit : Form
    {
        public FormFruit()
        {
            InitializeComponent();
        }

        private void FormFruit_Load(object sender, EventArgs e)
        {

        }

        private void FormFruit_DoubleClick(object sender, EventArgs e)
        {
            Form fruit2 = new FormFruit2();
            fruit2.ShowDialog();
        }
    }
}
