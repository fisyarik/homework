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
        public double Fun(double x)
        {
            if (this.radioButton1.Checked)     
                return Cos(x);

            if (this.radioButton2.Checked)     
                return x * x;

            if (this.radioButton3.Checked)      
                return Exp(x);

            return 0;
        }

        public double CalculatorL(double x, double y, double z)// метод для вычисления линейного алгоритма
        { 
            double denominator = Abs(x - y) * z + x * x;
          
            double h = 5 * Atan(x)
                        - 0.25 * Acos(x)
                         * ((x + z * Abs(x - y) + x * x) / denominator);
            return h;
        }
       
        public double CalculatorR(double x, double y)// метод для вычисления разветвляющегося алгоритма
        {
            double prxandy = x * y;
            richTextBox1Res2.AppendText($"Вычисляем xy = {x} * {y} = {prxandy}\r\n");

            double k;

            if (prxandy < 4 && prxandy > 1)
            {
                richTextBox1Res2.AppendText("Условие 1 < xy < 4 выполняется.\r\n");
                k = Math.Pow(Fun(x) + y, 2);
                richTextBox1Res2.AppendText($"k = (f(x) + y)^2 = ({Fun(x)} + {y})^2 = {k}\r\n");
            }
            else if (prxandy > 8 && prxandy < 10)
            {
                richTextBox1Res2.AppendText("Условие 8 < xy < 10 выполняется.\r\n");
                k = Fun(x) * Tan(y);
                richTextBox1Res2.AppendText($"k = f(x) * tg(y) = {Fun(x)} * tan({y}) = {k}\r\n");
            }
            else
            {
                richTextBox1Res2.AppendText("Иначе: ни одно условие не выполнено.\r\n");
                k = Fun(x) + y;
                richTextBox1Res2.AppendText($"k = f(x) + y = {Fun(x)} + {y} = {k}\r\n");
            }

            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(testBoxX.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(textBoxY.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double z = Convert.ToDouble(textBoxZ.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double denominator = Abs(x - y) * z + x * x;

            if (x < -1 || x > 1)
            {
                textBoxResult.Text = "Ошибка: x должен быть в диапазоне [-1; 1] для arccos";
                return;
            }
            
            if (denominator == 0)
            {
                textBoxResult.Text = "Ошибка: деление на ноль!"; 
                return;
            }

            double h = CalculatorL(x, y, z);
            textBoxResult.Text = h.ToString();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double y = Convert.ToDouble(textBoxY2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            double k = CalculatorR(x, y);

            richTextBox1Res2.AppendText($"Результат: k = ");

                if (checkBox1.Checked)
                richTextBox1Res2.SelectionColor = Color.Red;
                else
                richTextBox1Res2.SelectionColor = Color.Black;

            richTextBox1Res2.AppendText(k.ToString());

            richTextBox1Res2.SelectionColor = Color.Black;
            }
    }
}

