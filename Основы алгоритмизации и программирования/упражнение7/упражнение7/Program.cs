using System;

public class upr6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.Write("Ваш выбор: ");

        // Читаем ввод пользователя
        string operation = Console.ReadLine();

        double result = 0; // для хранения результата

        // выбор операции через switch
        switch (operation)
        {
            case "1":
                result = a + b;
                Console.WriteLine($"Результат сложения = {result}");
                break; // выход
            case "2":
                result = a - b;
                Console.WriteLine($"Результат вычитания = {result}");
                break; // выход
            case "3":
                result = a * b;
                Console.WriteLine($"Результат умножения = {result}");
                break; // выход
            default: // Если ввод не совпадает ни с одним из case
                Console.WriteLine("ошибка введите числа 1 2 или 3");
                break; // выход
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
