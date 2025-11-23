using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace algoritms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f(double x)
        {
            if (radioButton1.Checked)      
                return Cos(x);

            if (radioButton2.Checked)     
                return x * x;

            if (radioButton3.Checked)      
                return Exp(x);

            return 0;
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
                textBox6.Text = "Ошибка: x должен быть в диапазоне [-1; 1] для arccos";
                return;
            }

            // Проверка деления на 0
            double denominator = Abs(x - y) * z + x * x;
            if (denominator == 0)
            {
                textBox6.Text = "Ошибка: деление на ноль!";
                return;
            }

            double H = 5 * Atan(x)
                     - 0.25 * Acos(x)
                     * ((x + z * Abs(x - y) + x * x) / denominator);
            textBox6.Text = H.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox4.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(textBox5.Text.Replace(',', '.'), CultureInfo.InvariantCulture);




            double xy = x * y;
                richTextBox1.AppendText($"Вычисляем xy = {x} * {y} = {xy}\r\n");

                double k;

                if (xy < 4 && xy > 1)
                {
                richTextBox1.AppendText("Условие 1 < xy < 4 выполняется.\r\n");
                    k = Math.Pow(f(x) + y, 2);
                richTextBox1.AppendText($"k = (f(x) + y)^2 = ({f(x)} + {y})^2 = {k}\r\n");
                }
                else if (xy > 8 && xy < 10)
                {
                richTextBox1.AppendText("Условие 8 < xy < 10 выполняется.\r\n");
                    k = f(x) * Tan(y);
                richTextBox1.AppendText($"k = f(x) * tg(y) = {f(x)} * tan({y}) = {k}\r\n");
                }
                else
                {
                richTextBox1.AppendText("Иначе: ни одно условие не выполнено.\r\n");
                    k = f(x) + y;
                richTextBox1.AppendText($"k = f(x) + y = {f(x)} + {y} = {k}\r\n");
                }
            richTextBox1.AppendText($"Результат: k = ");

                if (checkBox1.Checked)
                    richTextBox1.SelectionColor = Color.Red;
                else
                    richTextBox1.SelectionColor = Color.Black;
         
            richTextBox1.AppendText(k.ToString());

            richTextBox1.SelectionColor = Color.Black;
            }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

