using System;

public class upr21

{
    public static void Main(string[] args)
    {
        // Запрашиваем сумму вклада
        Console.Write("Введите сумму вклада: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        // Запрашиваем количество месяцев
        Console.Write("Введите количество месяцев: ");
        int months = int.Parse(Console.ReadLine()); // int.Parse безопаснее для целых чисел

        // Ставка процента за месяц (7%)
        decimal procent = 0.07m; // 'm' указывает, что это decimal

        // Итоговая сумма вклада
        decimal final = deposit;

        // Цикл для начисления процентов за каждый месяц
        for (int i = 0; i < months; i++)
        {
            // Начисляем процент: finalAmount = finalAmount + (finalAmount * interestRate)
            final = final * (1 + procent);
        }

        // Выводим результат
        Console.WriteLine($"\nЧерез {months} месяцев сумма вклада составит: {final:C}");
        // :C форматирует вывод как валюту (например, 1 234,56 ₽)

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

