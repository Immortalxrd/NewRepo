using System;
using System.Threading;

class Ork
{
    private int _count = 1;
    private int _gold = 0;
    private int _farming = 2;

    public int Count
    {
        get { return _count; }
    }

    public int Gold
    {
        get { return _gold; }
    }

    public void BuyOrk()
    {
        Console.WriteLine("Добро пожаловать в лавку.");
        Console.WriteLine("Купить орка - 5 монет");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "купить")
        {
            if (_gold - 5 < 0)
            {
                Console.WriteLine("Золота недостаточно, приходите позже");
            }
            else
            {
                _gold -= 5;
                _count++;
            }
        }

        if (_count >= 5)
        {
            _farming -= 2;
        }
    }

    public void Mining()
    {
        while (true)
        {
            string key = Console.ReadLine();

            if (key.ToLower() == "магазин")
            {
                BuyOrk();
            }
            else if (key.ToLower() == "баланс")
            {
                Console.WriteLine($"Ваш баланс == {_gold}");
                Console.WriteLine("Напишите exit, чтобы выйти");
            }
            else if (key.ToLower() == "заработать")
            {
                Thread.Sleep(4000); // Заменяем time.sleep на Thread.Sleep в C#
                Console.WriteLine($"Ваш орк успешно добыл {_farming} монет");
                _gold += _farming * _count;
            }
            else if (key.ToLower() == "выйти")
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Ork ork = new Ork();
        ork.Mining();

        Console.WriteLine($"Вы заработали == {ork.Gold} монет и наняли {ork.Count} орка");
    }
}
