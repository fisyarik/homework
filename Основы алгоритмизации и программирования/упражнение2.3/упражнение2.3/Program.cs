using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Таблица умножения ---");

        // Внешний цикл для множимого (первое число)
        for (int i = 1; i <= 10; i++)
        {
            // Внутренний цикл для множителя (второе число)
            for (int j = 1; j <= 10; j++)
            {
                // Вычисляем произведение
                int result = i * j;

                // Выводим строку таблицы умножения
                // Используем форматирование для выравнивания столбцов
                Console.Write($"{i,3} x {j,2} = {result,4} | ");
            }
            // Переход на новую строку после завершения ряда (например, после 1x1 ... 1x10)
            Console.WriteLine();
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
