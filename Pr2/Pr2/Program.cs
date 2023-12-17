using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class EquationSolution
    {
        private double a, b, c;
        private double resultX1, resultX2;

        private double Discriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        private void CalculateRoots()
        {
            double dis = Discriminant(a, b, c);
            double x1 = Math.Round((-b + Math.Sqrt(dis)) / (2 * a), 2);
            double x2 = Math.Round((-b - Math.Sqrt(dis)) / (2 * a), 2);

            if (dis < 0)
            {
                resultX1 = 0.000001;
                resultX2 = 0.000001;
            }
            else if (dis > 0)
            {
                resultX1 = x1;
                resultX2 = x2;
            }
            else
            {
                resultX1 = x1;
            }
        }

        public EquationSolution(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetX1()
        {
            CalculateRoots();
            return (resultX1 == 0.000001) ? resultX1 : resultX1;
        }

        public double GetX2()
        {
            CalculateRoots();
            return (resultX2 == 0.000001) ? resultX2 : resultX2;
        }
    }

    class TaskTwo
    {
        private int n;
        private int number;

        public TaskTwo(int number)
        {
            this.number = number;
        }

        public int GetNum()
        {
            return n + 1;
        }

        public bool SetNumber(int number)
        {
            if (number == n + 1)
            {
                n = number;
                return true;
            }
            else
            {
                n = 0;
                return false;
            }
        }
    }

    class CaesarCipher
    {
        private string ConvertIn;
        private int ShiftTo;
        private readonly char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                         'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
                                         'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь',
                                         'э', 'ю', 'я' };

        private string ConvertingString(string Convert, int shift)
        {
            string result = "";
            foreach (char symbol in Convert)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (symbol == alphabet[i])
                    {
                        int newIndex = (i + shift) % alphabet.Length;
                        result += alphabet[newIndex];
                    }
                }
            }
            return result;
        }

        private string UnConvert(string Convert, int shift)
        {
            string result = "";
            foreach (char symbol in Convert)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (symbol == alphabet[i])
                    {
                        int newIndex = (i - shift + alphabet.Length) % alphabet.Length;
                        result += alphabet[newIndex];
                    }
                }
            }
            return result;
        }

        public CaesarCipher(string convertIn, int shiftTo)
        {
            ConvertIn = convertIn;
            ShiftTo = shiftTo;
        }

        public void UnConvertedString()
        {
            Console.WriteLine(UnConvert(ConvertIn, ShiftTo));
        }

        public void ConvertedString()
        {
            Console.WriteLine(ConvertingString(ConvertIn, ShiftTo));
        }
    }

    class MainClasses
    {
        static void Main()
        {
            int questionTask;

            Console.Write("Введите задачу, которую вы хотите проверить: ");
            while (true)
            {
                questionTask = Convert.ToInt32(Console.ReadLine());
                if (questionTask == 0) { break; }

                if (questionTask == 1)
                {
                    double a, b, c;

                    Console.WriteLine("\nЗадание 1: Решение дискриминанта\n\n");
                    Console.WriteLine("Введите индексы для переменных.\n");

                    Console.Write("Введите индекс a:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите индекс b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите индекс c:");
                    c = Convert.ToDouble(Console.ReadLine());

                    EquationSolution equationSolution = new EquationSolution(a, b, c);

                    double checkResultX1, checkResultX2;
                    checkResultX1 = equationSolution.GetX1();
                    checkResultX2 = equationSolution.GetX2();

                    if (checkResultX1 == 0.000001 && checkResultX2 == 0.000001)
                    {
                        Console.WriteLine("\n\nОтвет: Корней нет\n");
                    }
                    else if (checkResultX1 != 0 && checkResultX2 == 0)
                    {
                        Console.WriteLine($"\nКвадратное уравнение вида: {a}^2+({b})+({c})=0\n\nОтвет: {equationSolution.GetX1()}\n");
                    }
                    else
                        Console.WriteLine($"\nКвадратное уравнение вида: {a}^2+({b})+({c})=0\n\nОтвет: x1={equationSolution.GetX1()} и x2={equationSolution.GetX2()}\n");
                }

                if (questionTask == 2)
                {
                    Console.WriteLine("\nЗадание 2:\n\n");
                    int userInput = 0;
                    TaskTwo taskTwo = new TaskTwo(userInput);

                    while (true)
                    {
                        int userNumber = taskTwo.GetNum();
                        Console.WriteLine($"Введите число {userNumber}: ");
                        userInput = Convert.ToInt32(Console.ReadLine());

                        if (taskTwo.SetNumber(userInput))
                        {
                            Console.WriteLine("\nВерное значение, можете продолжать.");
                        }
                        else
                        {
                            Console.WriteLine("Неверное значение. Начните заново.");
                        }
                    }
                }

                if (questionTask == 3)
                {
                    Console.WriteLine("\nЗадание 3: Шифр Цезаря\n\n");

                    int shift;
                    Console.Write("Укажите строку, которую нужно зашифровать: ");
                    string userStringToConvert = Console.ReadLine();
                    Console.Write("Укажите сдвиг для шифровки: ");
                    while (true)
                    {
                        shift = Convert.ToInt32(Console.ReadLine());
                        if (shift <= 0)
                        {
                            Console.Write("Укажите корректный сдвиг: ");
                        }
                        else break;
                    }

                    CaesarCipher caesarCipher = new CaesarCipher(userStringToConvert, shift);

                    Console.WriteLine("Что вы хотите сделать со строкой: расшифровать, зашифровать.");
                    string questionConvert;
                    while (true)
                    {
                        questionConvert = Console.ReadLine();
                        if (questionConvert == "зашифровать" || questionConvert == "Зашифровать")
                        {
                            Console.Write("Ваша зашифрованная строка: ");
                            caesarCipher.ConvertedString();
                            break;
                        }
                        if (questionConvert == "расшифровать" || questionConvert == "Расшифровать")
                        {
                            Console.Write("Ваша расшифрованная строка: ");
                            caesarCipher.UnConvertedString();
                            break;
                        }
                        else
                        {
                            Console.Write("Выберите корректное действие: ");
                        }
                    }
                }
                else
                {
                    Console.Write("Укажите один из трех номеров задачи: ");
                }
            }
        }
    }
}

