using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using System.Globalization;

namespace algoritms
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(textBox2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double z = Convert.ToDouble(textBox3.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            // Проверка диапазона определения acos
            if (x < -1 || x > 1)
            {
                label4.Text = "Ошибка: x должен быть в диапазоне [-1; 1] для arccos";
                return;
            }

            // Проверка деления на 0
            double denominator = Abs(x - y) * z + x * x;
            if (denominator == 0)
            {
                label4.Text = "Ошибка: деление на ноль!";
                return;
            }

            double F = 5 * Atan(x)
                     - 0.25 * Acos(x)
                     * ((x + z * Abs(x - y) + x * x) / denominator);
            label4.Text = F.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
