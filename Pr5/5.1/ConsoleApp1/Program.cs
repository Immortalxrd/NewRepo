using System;
using System.Collections.Generic;

public interface IAnimal
{
    void Voice();
}

public class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав");
    }
}

public class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу");
    }
}

public class Owl : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Ух! Ух!");
    }
}

public class Cow : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Му");
    }
}

public class Monkey : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("yadysdyasdyasdasy");
    }
}

class Program
{
    static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>
        {
            new Dog(),
            new Cat(),
            new Cow(),
            new Owl(),
            new Monkey()
        };

        foreach (var animal in animals)
        {
            Console.Write($"{animal.GetType().Name} издаёт звук: ");
            animal.Voice();
        }
    }
}
