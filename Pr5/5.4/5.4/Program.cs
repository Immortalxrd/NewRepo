using System;

interface IShare
{
    void Draw(int size);
}

class Vertical : IShare
{
    private char symbol;
    public Vertical(char symbol)
    {
        this.symbol = symbol;
    }

    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(symbol);
        }
    }
}
class HorizontalLine : IShare
{
    private char symbol;
    public HorizontalLine(char symbol)
    {
        this.symbol = symbol;
    }

    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(symbol);
        }
    }
}
class Sqare : IShare
{
    private char symbol;
    public Sqare(char symbol)
    {
        this.symbol = symbol;
    }

    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(symbol);
            }
            Console.Write("\n");
        }
    }
}

class Program
{
    static void Main()
    {
        char symbol;
        Console.Write("Введите символ: ");
        symbol = Convert.ToChar(Console.ReadLine());

        Vertical vertical = new Vertical(symbol);
        HorizontalLine line = new HorizontalLine(symbol);
        Sqare sqare = new Sqare(symbol);

        int size;
        Console.Write("Укажите длину линии: ");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ваша вертикальная линия из {symbol}.\n");
        vertical.Draw(size);
        Console.WriteLine($"\nВаша горизонтальная линия из {symbol}.\n");
        line.Draw(size);
        Console.WriteLine($"\n\nКвадрат из {symbol}.\n\n");
        sqare.Draw(size);
    }
}