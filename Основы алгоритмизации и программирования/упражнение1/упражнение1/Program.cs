using System;

public class upr1
{
    public static void Main(string[] args)
    {
        Console.Write("Первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Второе число: ");
        int b = int.Parse(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("Два числа равны.");
        }
        else if (a > b)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else 
        {
            Console.WriteLine("Первое число меньше второго.");
        }

 
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

