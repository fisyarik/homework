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
        else // Если не равны и первое не больше, значит первое меньше
        {
            Console.WriteLine("Первое число меньше второго.");
        }

        // Ожидание нажатия клавиши перед закрытием консоли (опционально)
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

