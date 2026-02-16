using System;

class Program
{
    static void Main()
    {
        char[,] board = new char[3, 3];
        char player = 'X';
        bool gameOver = false;

        // Инициализация поля
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';

        while (!gameOver)
        {
            // Вывод поля с цветами
            Console.WriteLine("\n  0   1   2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;      // Красный для X
                        Console.Write("X");
                    }
                    else if (board[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;     // Синий для O
                        Console.Write("O");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;    // Серый для пустой клетки
                        Console.Write(" ");
                    }
                    Console.ResetColor();  // Возвращаем цвет по умолчанию
                    Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  -----------");
            }

            // Ввод хода
            Console.ForegroundColor = (player == 'X') ? ConsoleColor.Red : ConsoleColor.Blue;
            Console.WriteLine($"Игрок {player}, введите строку и столбец (например, '1 2'):");
            Console.ResetColor();

            string[] input = Console.ReadLine()?.Split(' ') ?? new string[0];
            if (input.Length != 2)
            {
                Console.WriteLine("Ошибка ввода! Введите два числа через пробел.");
                continue;
            }

            if (!int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col))
            {
                Console.WriteLine("Введите числа от 0 до 2.");
                continue;
            }

            if (row < 0 || row > 2 || col < 0 || col > 2)
            {
                Console.WriteLine("Координаты должны быть от 0 до 2.");
                continue;
            }

            if (board[row, col] != ' ')
            {
                Console.WriteLine("Клетка уже занята!");
                continue;
            }

            // Делаем ход
            board[row, col] = player;

            // Проверка победы
            bool win = CheckWin(board, player);

            if (win)
            {
                Console.ForegroundColor = (player == 'X') ? ConsoleColor.Red : ConsoleColor.Blue;
                Console.WriteLine($"\nИгрок {player} победил!");
                Console.ResetColor();
                gameOver = true;
                continue;
            }

            // Проверка ничьи
            bool full = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == ' ') full = false;

            if (full)
            {
                Console.WriteLine("\nНичья!");
                gameOver = true;
                continue;
            }

            // Смена игрока
            player = (player == 'X') ? 'O' : 'X';
        }

        Console.WriteLine("Игра окончена.");
    }

    // Проверка победы
    static bool CheckWin(char[,] board, char player)
    {
        // Строки
        for (int i = 0; i < 3; i++)
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                return true;

        // Столбцы
        for (int j = 0; j < 3; j++)
            if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
                return true;

        // Диагонали
        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
            return true;

        return false;
    }
}
