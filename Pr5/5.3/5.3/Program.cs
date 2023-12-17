using System;

interface IFilter
{
    string Execute(string textLine);
}

class DigitFilter : IFilter
{
    char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public string Execute(string textLine)
    {
        string result = "";
        for (int i = 0; i < textLine.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (textLine[i] == numbers[j])
                {
                    result += numbers[j];
                }
            }
        }
        return result;
    }
}
class LetterFilter : IFilter
{
    char[] alphabet =
    { 'а', 'б', 'в', 'г',
      'д', 'е', 'ё', 'ж',
      'з', 'и', 'й', 'к',
      'л', 'м', 'н', 'о',
      'п', 'р', 'с', 'т',
      'у', 'ф', 'х', 'ц',
      'ч', 'ш', 'щ', 'ь',
      'ы', 'ъ', 'э', 'ю', 'я'};
    public string Execute(string textLine)
    {
        string result = "";
        for (int i = 0; i < textLine.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (textLine[i] == alphabet[j])
                {
                    result += alphabet[j];
                }
            }
        }
        return result;
    }
}

class program
{
    static void Main()
    {
        DigitFilter filter = new DigitFilter();
        LetterFilter letterFilter = new LetterFilter();
        string message;
        Console.Write("Введите строку: ");
        message = Console.ReadLine().ToLower();
        Console.WriteLine($"\nВаша строка без букв: {filter.Execute(message)}\n");
        Console.WriteLine($"Ваша строка без цифр: {letterFilter.Execute(message)}");
    }
}