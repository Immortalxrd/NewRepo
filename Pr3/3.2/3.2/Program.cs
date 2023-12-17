using System;

class Color
{
    private int _red;
    private int _green;
    private int _blue;

    public Color(int red = 0, int green = 0, int blue = 0)
    {
        this.Red = red;
        this.Green = green;
        this.Blue = blue;
    }

    public int Red
    {
        get { return _red; }
        set { _red = NormalizeColorValue(value); }
    }

    public int Green
    {
        get { return _green; }
        set { _green = NormalizeColorValue(value); }
    }

    public int Blue
    {
        get { return _blue; }
        set { _blue = NormalizeColorValue(value); }
    }

    private int NormalizeColorValue(int colorValue)
    {
        return Math.Min(255, Math.Max(0, colorValue));
    }

    public void DisplayColor()
    {
        Console.WriteLine($"{Red}, {Green}, {Blue}");
    }
}

class Program
{
    static void Main()
    {
        Color yellow = new Color(255, 255, 0);
        yellow.DisplayColor();

        Color pink = new Color();
        pink.Red = 255;
        pink.Green = 0;
        pink.Blue = 147;

        pink.DisplayColor();
    }
}
