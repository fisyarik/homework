using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibb
{
    public class Basic
    {
        
            public double Summ(double a, double b)
            {
                return a + b;
            }

            public double Diff(double a, double b)
            {
                return a - b;
            }

            public double Composition(double a, double b)
            {
                return a * b;
            }

            public double Division(double a, double b)
            {
                if (b == 0)
                    throw new Exception("Деление на ноль!");

                return a / b;
            }
        }
}
