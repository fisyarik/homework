using System;

public class upr22
{
    public static void Main(string[] args)
    {
        // Запрашиваем сумму вклада
        Console.Write("Введите сумму вклада (например, 1000.50): ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        // Запрашиваем количество месяцев
        Console.Write("Введите количество месяцев: ");
        int numberOfMonths = int.Parse(Console.ReadLine());

        // Ставка процента за месяц (7%)
        decimal interestRate = 0.07m;

        // Итоговая сумма вклада
        decimal finalAmount = depositAmount;

        // Счетчик месяцев для цикла while
        int currentMonth = 0;

        // Цикл для начисления процентов за каждый месяц с использованием while
        while (currentMonth < numberOfMonths)
        {
            // Начисляем процент
            finalAmount = finalAmount * (1 + interestRate);

            // Увеличиваем счетчик месяцев
            currentMonth++;
        }

        // Выводим результат
        Console.WriteLine($"\nЧерез {numberOfMonths} месяцев сумма вклада составит: {finalAmount:C}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
