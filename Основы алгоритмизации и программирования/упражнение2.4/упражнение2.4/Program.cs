using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число (0-10): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число (0-10): ");
            int b = int.Parse(Console.ReadLine());

            if (a < 0 || a > 10 || b < 0 || b > 10)
            {
                Console.WriteLine("Введенные числа недопустимы. Попробуйте снова.");
                continue;
            }

            Console.WriteLine("Результат умножения: " + (a * b));
            break;
        }
    }
}