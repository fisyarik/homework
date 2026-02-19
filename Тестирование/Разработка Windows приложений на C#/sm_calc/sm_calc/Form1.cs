using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sm_calc
{
    public partial class Form1 : Form
    {

        string currentInput = ""; // Текущий ввод пользователя
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool isNewEntry = true; // Флаг для нового ввода
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "1";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "1";
            }
            currentInput += "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "2";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "2";
            }
            currentInput += "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "3";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "3";
            }
            currentInput += "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "4";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "4";
            }
            currentInput += "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "5";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "5";
            }
            currentInput += "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "6";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "6";
            }
            currentInput += "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "7";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "7";
            }
            currentInput += "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "8";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "8";
            }
            currentInput += "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "9";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "9";
            }
            currentInput += "9";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "0";
                isNewEntry = false;
            }
            else
            {
                Display.Text += "0";
            }
            currentInput += "0";
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (!isNewEntry)
            {
                firstNumber = double.Parse(Display.Text);
                operation = "+";
                currentInput += "+";
                isNewEntry = true;
            }

        }

        private void butSubtract_Click(object sender, EventArgs e)
        {
            if (!isNewEntry)
            {
                firstNumber = double.Parse(Display.Text);
                operation = "-";
                currentInput += "-";
                isNewEntry = true;
            }
        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            if (!isNewEntry)
            {
                firstNumber = double.Parse(Display.Text);
                operation = "*";
                currentInput += "*";
                isNewEntry = true;
            }
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            if (!isNewEntry)
            {
                firstNumber = double.Parse(Display.Text);
                operation = "/";
                currentInput += "/";
                isNewEntry = true;
            }
        }

        private void butProcent_Click(object sender, EventArgs e)
        {
            double number = double.Parse(Display.Text);
            double result = number / 100;
            Display.Text = result.ToString();
            currentInput += "%";
            isNewEntry = true;
        }


        private void butClear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            currentInput = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isNewEntry = true;
        }

        private void butBackSpace_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
                currentInput = currentInput.Remove(currentInput.Length - 1);
                if (Display.Text == "") Display.Text = "0";
            }
        }

        private void butSquare_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(Display.Text);
                double result = number * number; // или Math.Pow(number, 2)
                Display.Text = result.ToString();
                currentInput += "^2=" + result.ToString();
                isNewEntry = true;
            }
            catch (FormatException)
            {
                Display.Text = "Ошибка";
            }
        }

        private void butEquals_Click(object sender, EventArgs e)
        {
            if (operation != "" && !isNewEntry)
            {
                secondNumber = double.Parse(Display.Text);

                switch (operation)
                {
                    case "+":
                        Display.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        Display.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        Display.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        if (secondNumber != 0)
                            Display.Text = (firstNumber / secondNumber).ToString();
                        else
                            Display.Text = "Ошибка: деление на ноль!";
                        break;
                }

                currentInput += "=" + Display.Text;
                isNewEntry = true;
                operation = "";
            }
        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                Display.Text = "0.";
                isNewEntry = false;
            }
            else if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
                currentInput += ".";
            }
        }
    }
}
