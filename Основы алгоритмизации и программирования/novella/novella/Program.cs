using System;
using System.Collections.Generic;

public class novella
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в новеллу!");

        int storyStep = 1;
        List<int> endingsReached = new List<int>();

        // Переменные для отслеживания состояния (пример)
        bool hasMagicAmulet = false;
        bool helpedForestSpirit = false;
        bool hasOldMap = false;

        while (storyStep != 0)
        {
            switch (storyStep)
            {
                case 1: // Шаг 1: Вступление
                    Console.WriteLine("\n--- Шаг 1: Загадочный Лес ---");
                    Console.WriteLine("Вы стоите на опушке таинственного леса. Солнце пробивается сквозь густую листву.");
                    Console.WriteLine("Слышен шепот ветра и далекое пение птиц. Перед вами две тропинки:");
                    Console.WriteLine("1. Узкая, едва заметная тропинка, ведущая вглубь леса.");
                    Console.WriteLine("2. Широкая дорога, уходящая в сторону полей.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice1 = Console.ReadLine();

                    if (choice1 == "1") storyStep = 2;
                    else if (choice1 == "2") storyStep = 3;
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;

                case 2: // Шаг 2: Узкая тропинка (встреча с духом)
                    Console.WriteLine("\n--- Шаг 2: Тайны Леса ---");
                    Console.WriteLine("Вы идете по узкой тропинке. Вокруг вас высокие деревья, покрытые мхом.");
                    Console.WriteLine("Внезапно вы слышите тихий плач.");
                    Console.WriteLine("1. Пойти на звук плача.");
                    Console.WriteLine("2. Игнорировать звук и продолжать идти вперед.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice2 = Console.ReadLine();

                    if (choice2 == "1")
                    {
                        storyStep = 4; // Встреча с духом
                        helpedForestSpirit = true; // Флаг, что помогли духу
                    }
                    else if (choice2 == "2")
                    {
                        storyStep = 5; // Прошли мимо, не помогли
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;

                case 3: // Шаг 3: Широкая дорога (встреча со стариком)
                    Console.WriteLine("\n--- Шаг 3: Поля и Солнце ---");
                    Console.WriteLine("Вы выходите на залитое солнцем поле. Вдалеке виднеется деревня.");
                    Console.WriteLine("У дороги сидит старик с мудрым взглядом.");
                    Console.WriteLine("1. Поговорить со стариком.");
                    Console.WriteLine("2. Идти прямо к деревне.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice3 = Console.ReadLine();

                    if (choice3 == "1")
                    {
                        storyStep = 6; // Говорим со стариком
                        hasOldMap = true; // Получаем карту
                    }
                    else if (choice3 == "2")
                    {
                        storyStep = 7; // Идем в деревню
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;

                case 4: // Шаг 4: Лесной дух (действие)
                    Console.WriteLine("\n--- Шаг 4: Лесной Дух ---");
                    Console.WriteLine("Вы находите маленького лесного духа, который запутался в паутине.");
                    Console.WriteLine("1. Освободить духа.");
                    Console.WriteLine("2. Оставить его и уйти.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "1")
                    {
                        Console.WriteLine("Вы освободили духа. Он благодарит вас и дарит магический амулет.");
                        hasMagicAmulet = true; // Получаем амулет
                        storyStep = 13; // Переходим к шагу, связанному с амулетом
                    }
                    else if (choice4 == "2")
                    {
                        Console.WriteLine("Дух остался в паутине... Возможно, это было не лучшим решением.");
                        storyStep = 5; // Идем дальше, но без помощи духа
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;

                case 5: // Шаг 5: Опасность в лесу
                    Console.WriteLine("\n--- Шаг 5: Углубляясь в Лес ---");
                    Console.WriteLine("Вы продолжаете идти по лесу. Тени становятся длиннее, а звуки - тревожнее.");
                    Console.WriteLine("Внезапно вы слышите рычание. Это дикий зверь!");
                    Console.WriteLine("1. Попытаться убежать (если есть амулет, использовать его).");
                    Console.WriteLine("2. Дать отпор.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice5 = Console.ReadLine();

                    if (choice5 == "1")
                    {
                        if (hasMagicAmulet)
                        {
                            Console.WriteLine("Вы активируете амулет. Вас окутывает свет, и зверь отступает!");
                            storyStep = 14; // Переход к шагу после защиты амулетом
                        }
                        else
                        {
                            Console.WriteLine("Вы пытаетесь убежать, но спотыкаетесь. Зверь настигает вас...");
                            storyStep = 10; // Плохая концовка
                        }
                    }
                    else if (choice5 == "2")
                    {
                        Console.WriteLine("Вы храбро сражаетесь, но зверь слишком силен...");
                        storyStep = 10; // Плохая концовка
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;

                case 6: // Шаг 6: Разговор со стариком
                    Console.WriteLine("\n--- Шаг 6: Совет Старика ---");
                    Console.WriteLine("Старик рассказывает вам о древнем артефакте, спрятанном в лесу, который может дать великую силу.");
                    Console.WriteLine("Он достает старую, потрепанную карту.");
                    Console.WriteLine("1. Взять карту и отправиться на поиски артефакта.");
                    Console.WriteLine("2. Поблагодарить старика и идти в деревню, игнорируя его рассказ.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice6 = Console.ReadLine();

                    if (choice6 == "1")
                    {
                        storyStep = 11; // Начинаем поиски артефакта
                        hasOldMap = true; // Получили карту
                    }
                    else if (choice6 == "2")
                    {
                        storyStep = 7; // Идем в деревню
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;
                case 7: // Шаг 7: Прибытие в деревню
                    Console.WriteLine("\n--- Шаг 7: Тихая Деревня ---");
                    Console.WriteLine("Вы приходите в мирную деревню. Люди занимаются своими делами, их лица спокойны.");
                    Console.WriteLine("Вас приветливо встречают.");
                    storyStep = 12; // Спокойная концовка
                    break;

                // --- Шаги, ведущие к разным концовкам ---

                case 10: // Шаг 10: Потерянный в лесу (Плохая Концовка 1)
                    Console.WriteLine("\n--- Шаг 10: Темные Чащи ---");
                    Console.WriteLine("Зверь оказался сильнее, чем вы ожидали. Ваш путь обрывается здесь.");
                    Console.WriteLine("Вас поглощает дикая природа.");
                    endingsReached.Add(1); // Добавляем номер концовки
                    storyStep = 0; // Завершаем игру
                    break;

                case 11: // Шаг 11: Поиски артефакта
                    Console.WriteLine("\n--- Шаг 11: Древние Руины ---");
                    Console.WriteLine("Следуя карте, вы находите старые руины, полускрытые в чаще.");
                    Console.WriteLine("В центре стоит пьедестал, на котором покоится светящийся кристалл.");
                    Console.WriteLine("1. Взять кристалл.");
                    Console.WriteLine("2. Оставить кристалл и вернуться в деревню.");
                    Console.Write("Ваш выбор (1 или 2): ");
                    string choice11 = Console.ReadLine();

                    if (choice11 == "1")
                    {
                        storyStep = 15; // Концовка с артефактом
                    }
                    else if (choice11 == "2")
                    {
                        storyStep = 7; // Возвращаемся в деревню
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, выберите 1 или 2.");
                    break;

                case 12: // Шаг 12: Мирная жизнь (Спокойная Концовка 2)
                    Console.WriteLine("\n--- Шаг 12: Обыденное Счастье ---");
                    Console.WriteLine("Вы находите свое место в деревне. Жизнь здесь проста и предсказуема.");
                    Console.WriteLine("Вы нашли свое счастье в обыденности.");
                    endingsReached.Add(2);
                    storyStep = 0;
                    break;

                case 13: // Шаг 13: Защита амулета (Хорошая Концовка 3)
                    Console.WriteLine("\n--- Шаг 13: Под Защитой Магии ---");
                    Console.WriteLine("Волшебный амулет отпугнул все опасности леса.");
                    Console.WriteLine("Вы благополучно покидаете лес, чувствуя себя в безопасности.");
                    endingsReached.Add(3);
                    storyStep = 0;
                    break;

                case 14: // Шаг 14: Безопасный выход из леса
                    Console.WriteLine("\n--- Шаг 14: Спокойствие на Опушке ---");
                    Console.WriteLine("Благодаря амулету, вы без приключений вышли из леса.");
                    Console.WriteLine("Вы чувствуете облегчение и силу.");
                    // Это может быть отдельная концовка или шаг, ведущий к ней.
                    // Давайте сделаем это концовкой, если дух был спасен.
                    if (helpedForestSpirit)
                    {
                        storyStep = 13; // Перенаправляем на концовку с амулетом
                    }
                    else
                    {
                        // Если бы не помогли духу, но вышли бы безопасно (например, другой путь)
                        Console.WriteLine("Вы благополучно покинули лес.");
                        endingsReached.Add(4); // Новая концовка - "Безопасный выход"
                        storyStep = 0;
                    }
                    break;
                case 15: // Шаг 15: Власть кристалла (Концовка с артефактом 5)
                    Console.WriteLine("\n--- Шаг 15: Сила Кристалла ---");
                    Console.WriteLine("Вы берете кристалл. Ощущаете прилив невероятной энергии.");
                    Console.WriteLine("Вы чувствуете, что мир теперь в ваших руках.");
                    Console.WriteLine("Вы возвращаетесь в деревню, но уже как могущественный маг.");
                    endingsReached.Add(5);
                    storyStep = 0;
                    break;

                default:
                    Console.WriteLine("\nЧто-то пошло не так. История завершена.");
                    storyStep = 0;
                    break;
            }
        }

        Console.WriteLine("\n========================================");
        Console.WriteLine("Игра окончена!");

        if (endingsReached.Count > 0)
        {
            Console.WriteLine("Вы достигли следующих концовок:");
            foreach (int ending in endingsReached)
            {
                Console.Write($"- Концовка {ending}");
                switch (ending)
                {
                    case 1: Console.WriteLine(" (Потерянный в лесу)"); break;
                    case 2: Console.WriteLine(" (Мирная жизнь)"); break;
                    case 3: Console.WriteLine(" (Под защитой магии)"); break;
                    case 4: Console.WriteLine(" (Безопасный выход)"); break; // Эта концовка была добавлена в case 14, если дух не был спасен
                    case 5: Console.WriteLine(" (Власть кристалла)"); break;
                }
            }
        }
        else
        {
            Console.WriteLine("Вы не достигли ни одной из известных концовок.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}