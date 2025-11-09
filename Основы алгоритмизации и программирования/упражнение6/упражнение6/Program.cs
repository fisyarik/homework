using System;

public class upr6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.Write("Ваш выбор: ");

        // Читаем ввод пользователя
        string operation = Console.ReadLine();

        // Используем switch...case для определения операции
        switch (operation)
        {
            case "1":
                Console.WriteLine("Вы выбрали: Сложение");
                break; // Выходим из switch
            case "2":
                Console.WriteLine("Вы выбрали: Вычитание");
                break; // Выходим из switch
            case "3":
                Console.WriteLine("Вы выбрали: Умножение");
                break; // Выходим из switch
            default: // Если ввод не совпадает ни с одним из case
                Console.WriteLine("Ошибка: Операция неопределена. Пожалуйста, выберите 1, 2 или 3.");
                break; // Выходим из switch
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
