using System;

public class upr3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int a = int.Parse(Console.ReadLine());

        {
            // Проверяем условие: число равно 5 ИЛИ число равно 10
            if (a == 5 || a == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        

        // Ожидание нажатия клавиши перед закрытием консоли (опционально)
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
