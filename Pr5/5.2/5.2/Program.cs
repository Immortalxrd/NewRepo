using System;
using System.Collections.Generic;

// Абстрактный класс
public abstract class HelloAll
{
    // Абстрактный метод
    public abstract void SayHello();
}

// Класс наследник для английского приветствия
public class English : HelloAll
{
    public override void SayHello()
    {
        Console.WriteLine("Hello everybody!");
    }
}

// Класс наследник для русского приветствия
public class Russian : HelloAll
{
    public override void SayHello()
    {
        Console.WriteLine("Привет всем!");
    }
}

// Класс наследник для немецкого приветствия
public class Germany : HelloAll
{
    public override void SayHello()
    {
        Console.WriteLine("Hallo an alle!");
    }
}

class Program
{
    static void Main()
    {
        // Создание списка объектов разных классов
        List<HelloAll> listHello = new List<HelloAll>
        {
            new English(),
            new Russian(),
            new Germany()
        };

        // Вызов метода для каждого объекта в списке
        foreach (var item in listHello)
        {
            item.SayHello();
            Console.WriteLine($", будет на {item.GetType().Name} языке");
        }
    }
}
