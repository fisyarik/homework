using System;

public class upr4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        double sum = Convert.ToDouble(Console.ReadLine()); // сумма
        double percent; // для процента

        if (sum < 100)
        {
            percent = 0.05; // 5%
        }
        else if (sum >= 100 && sum <= 200)
        {
            percent = 0.07; // 7%
        }
        else
        {
            percent = 0.10; // 10%
        }

        double finalSum = sum + (sum * percent); // итоговая сумма

        Console.WriteLine($"Итоговая сумма: {finalSum}"); // результат
    }
}
