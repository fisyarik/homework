using System;
using static System.Formats.Asn1.AsnWriter;

class novella1
{
    static void Main()
    {
        int score = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(Step(i));
            Console.WriteLine("1 - да, окей  2 - никуда не поеду");

            char c = Console.ReadKey(true).KeyChar;

            if (c == '1')
            {
                score++;
            }

            else
            {
                End(score);
                return;
            }
        }

        End(20);
    }

    static string Step(int score)
    {
        if (score == 1) return "шаг 1: проснуться вовремя?";
        if (score == 2) return "шаг 2: встать с кровати?";
        if (score == 3) return "шаг 3: накраситься?";
        if (score == 4) return "шаг 4: сделать зарядку?";
        if (score == 5) return "шаг 5: позавтракать?";
        if (score == 6) return "шаг 6: одеться?";
        if (score == 7) return "шаг 7: найти носки-пары?";
        if (score == 8) return "шаг 8: собрать сумку?";
        if (score == 9) return "шаг 9: проверить расписание?";
        if (score == 10) return "шаг 10: выйти из комнаты?";
        if (score == 11) return "шаг 11: дойти до двери?";
        if (score == 12) return "шаг 12: надеть обувь?";
        if (score == 13) return "шаг 13: выйти на улицу?";
        if (score == 14) return "шаг 14: дойти до метро?";
        if (score == 15) return "шаг 15: зайти в метро?";
        if (score == 16) return "шаг 16: доехать до станции?";
        if (score == 17) return "шаг 17: выйти из метро?";
        if (score == 18) return "шаг 18: дойти до колледжа?";
        if (score == 19) return "шаг 19: войти в здание?";
        if (score == 20) return "шаг 20: дойти до аудитории?";

        return "шаг?";
    }

    static void End(int score)
    {
        Console.WriteLine("\nконец.");

        if (score == 20)
            Console.WriteLine("концовка 1: ты дошла до аудитории. Александ Сергеевич тебя схавает. БЕГИ!!!!!");
        else if (score >= 18)
            Console.WriteLine("концовка 2: почти дошла, но передумала.");
        else if (score >= 15)
            Console.WriteLine("концовка 3: уехала не туда");
        else if (score >= 13)
            Console.WriteLine("концовка 4: увидела булочку и и никуда не пошла.");
        else if (score >= 10)
            Console.WriteLine("концовка 5: решила, что день слишком сложный.");
        else if (score >= 6)
            Console.WriteLine("концовка 6: утро не задалось, никуда не поехала.");
        else if (score >= 4)
            Console.WriteLine("концовка 7: устала раньше времени.");
        else if (score >= 2)
            Console.WriteLine("концовка 8: кот лёг на тебя, и ты сдалась.");
        else if (score == 1)
            Console.WriteLine("концовка 9: проснулась, но дальше легла спать.");
        else
            Console.WriteLine("концовка 10: ты даже не проснулась.");

        Console.WriteLine("спасибо за игру!");
    }
}
