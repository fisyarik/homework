using System;

public class upr2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int a = int.Parse(Console.ReadLine());

        // Проверяем условие: число больше 5 И меньше 10
        if (a > 5 && a < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

        // Ожидание нажатия клавиши перед закрытием консоли (опционально)
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
