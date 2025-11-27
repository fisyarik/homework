using System;

class novella1
{
    static void Main()
    {
        DoStep(1, 0);
    }

    static void DoStep(int step, int score)
    {
        Console.WriteLine(GetStepText(step));
        Console.WriteLine("1 - да, окей   2 - никуда не поеду");

        char c = Console.ReadKey(true).KeyChar;

        switch (c)
        {
            case '1':
                score++;
                if (step < 20)
                {
                    DoStep(step + 1, score);
                    return;
                }
                End(score);
                return;

            case '2':
                End(score);
                return;

            default:
                DoStep(step, score);
                return;
        }
    }

    static string GetStepText(int s)
    {
        switch (s)
        {
            case 1: return "шаг 1: проснуться вовремя?";
            case 2: return "шаг 2: встать с кровати?";
            case 3: return "шаг 3: накраситься?";
            case 4: return "шаг 4: сделать зарядку?";
            case 5: return "шаг 5: позавтракать?";
            case 6: return "шаг 6: одеться?";
            case 7: return "шаг 7: найти носки-пары?";
            case 8: return "шаг 8: собрать сумку?";
            case 9: return "шаг 9: проверить расписание?";
            case 10: return "шаг 10: выйти из комнаты?";
            case 11: return "шаг 11: дойти до двери?";
            case 12: return "шаг 12: надеть обувь?";
            case 13: return "шаг 13: выйти на улицу?";
            case 14: return "шаг 14: дойти до метро?";
            case 15: return "шаг 15: зайти в метро?";
            case 16: return "шаг 16: доехать до станции?";
            case 17: return "шаг 17: выйти из метро?";
            case 18: return "шаг 18: дойти до колледжа?";
            case 19: return "шаг 19: войти в здание?";
            case 20: return "шаг 20: дойти до аудитории?";
        }
        return "шаг?";
    }

    static void End(int s)
    {
        Console.WriteLine("\nконец.");

        switch (s)
        {
            case 20:
                Console.WriteLine("концовка 1: ты дошла до аудитории. александр сергеевич тебя схавает. беги!!!!!");
                break;
            case >= 18:
                Console.WriteLine("концовка 2: почти дошла, но передумала.");
                break;
            case >= 15:
                Console.WriteLine("концовка 3: уехала не туда.");
                break;
            case >= 13:
                Console.WriteLine("концовка 4: увидела булочку и никуда не пошла.");
                break;
            case >= 10:
                Console.WriteLine("концовка 5: решила, что день слишком сложный.");
                break;
            case >= 6:
                Console.WriteLine("концовка 6: утро не задалось, никуда не поехала.");
                break;
            case >= 4:
                Console.WriteLine("концовка 7: устала раньше времени.");
                break;
            case >= 2:
                Console.WriteLine("концовка 8: кот лёг на тебя, и ты сдалась.");
                break;
            case 1:
                Console.WriteLine("концовка 9: проснулась, но дальше легла спать.");
                break;
            default:
                Console.WriteLine("концовка 10: ты даже не проснулась.");
                break;
        }

        Console.WriteLine("спасибо за игру!");
    }
}