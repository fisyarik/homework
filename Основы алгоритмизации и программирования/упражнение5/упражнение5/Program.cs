using System;

public class upr5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        double sum = Convert.ToDouble(Console.ReadLine());
        double percent; // процент

        // процентная ставка
        if (sum < 100)
        {
            percent = 0.05; // 5%
        }
        else if (sum >= 100 && sum <= 200)
        {
            percent = 0.07; // 7%
        }
        else // sum > 200
        {
            percent = 0.10; // 10%
        }

        // расчет итоговой суммы с процентами
        double finalSumWithInterest = sum + (sum * percent);

        // добавление фиксированного бонуса
        double bonus = 15.0;
        double finalSumWithBonus = finalSumWithInterest + bonus;

        // результат
        Console.WriteLine($"Итоговая сумма с процентами и бонусами: {finalSumWithBonus}");

        // Ожидание нажатия клавиши перед закрытием консоли (опционально)
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
