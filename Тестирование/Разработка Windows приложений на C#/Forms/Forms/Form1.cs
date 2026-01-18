using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            triangle newForm = new triangle();
            newForm.Enabled = true;
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            heart newForm = new heart();
            newForm.Enabled = true;
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            car newForm = new car();
            newForm.Enabled = true;
            newForm.Show();
        }
    }
}
