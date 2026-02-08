using MathLibb;
using mylib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathLibb.Basic;
using static mylib.Class1;
using static MathLibb.Log;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom");
            tom.Print();


            Basic calc = new Basic();
            double x = 10, y = 2;

            Console.WriteLine($"Сложение: {calc.Summ(x, y)}");
            Console.WriteLine($"Вычитание: {calc.Diff(x, y)}");
            Console.WriteLine($"Умножение: {calc.Composition(x, y)}");
            Console.WriteLine($"Деление: {calc.Division(x, y)}");

            // Проверка деления на ноль
            try { Console.WriteLine(calc.Division(x, 0)); }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Log logic = new Log();

            bool p = true;
            bool q = false;

            Console.WriteLine($"P = {p}, Q = {q}");
            Console.WriteLine();

            Console.WriteLine($"AND:  {logic.And(p, q)}");      // false
            Console.WriteLine($"OR:   {logic.Or(p, q)}");       // true
            Console.WriteLine($"NOT P: {logic.Not(p)}");         // false
            Console.WriteLine($"XOR:  {logic.Xor(p, q)}");     // true
            Console.WriteLine($"IMPLIES: {logic.Implies(p, q)}"); // false
            Console.WriteLine($"EQUIV: {logic.Equiv(p, q)}");   // false
        }
    }
}
