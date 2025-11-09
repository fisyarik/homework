using System;

public class calculator
{
    public static void Main(string[] args)
    {
        // первое число
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        // второе число
        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // простые операции
        double sum = a + b;
        Console.WriteLine($"Сложение = {sum}");

        double difference = a - b;
        Console.WriteLine($"Вычитание = {difference}");

        double product = a * b;
        Console.WriteLine($"Умножение = {product}");

        double division = a / b;
        Console.WriteLine($"Деление = {division}");


        // сравниение
        bool isGreater = a > b;
        Console.WriteLine($"Больше:  {isGreater}");

        bool isLess = a < b;
        Console.WriteLine($"Меньше: {isLess}");

        bool isEqual = a == b;
        Console.WriteLine($"Равно: {isEqual}");

        // первое число
        Console.Write("Введите первое число: ");
        int z = Convert.ToInt32(Console.ReadLine());

        // второе число
        Console.Write("Введите второе число: ");
        int x = Convert.ToInt32(Console.ReadLine());

        // лог умножение
        Console.WriteLine($"Логическое умножение = {z & x}");
        // лог сложение
        Console.WriteLine($"Логическое сложение =  {z | x}");
        // лог исключающее или
        int key = 102; //ключ шифрования

        int encrypt = z ^ key; //Результатом будет число 1001011 или 75
        Console.WriteLine($"Зашифрованное первое число: {encrypt}");

        int decrypt = encrypt ^ key; // Результатом будет исходное число 45
        Console.WriteLine($"Расшифрованное число: {decrypt}");

        int key1 = 1101; //ключ шифрования

        int encrypt1 = x ^ key1; //Результатом будет число 1001011 или 75
        Console.WriteLine($"Зашифрованное второе число: {encrypt1}");

        int decrypt1 = encrypt1 ^ key1; // Результатом будет исходное число 45
        Console.WriteLine($"Расшифрованное число: {decrypt1}");

        // инверсия
        Console.WriteLine(~z);
        Console.WriteLine(~x);

        // сдвиг
        int c = z << x; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе

        Console.WriteLine($"Зашифрованное число: {c}");    // 64

        int d = z >> x; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
        Console.WriteLine($"Зашифрованное число: {d}");






        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
