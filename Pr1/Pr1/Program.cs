using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class Car
    {
        private string ModelCar;
        private double maxSpeed;
        private double raceDistance;

        public Car(string nameCar, double maxSpeed)
        {
            this.ModelCar = nameCar;
            this.maxSpeed = maxSpeed;
        }

        public void ShowModelCar()
        {
            Console.WriteLine("\nАвтомобиль: " + ModelCar + "\nСкорость: " + maxSpeed + " km/h\n");
        }

        public double RaceTime()
        {
            return Math.Round((raceDistance / maxSpeed) * 3600);
        }

        public void SetRaceDistance(double distance)
        {
            this.raceDistance = distance;
        }
    }

    class Program
    {
        static void StartRace(Dictionary<string, double> racers)
        {
            int hour, minute, seconds;
            double minTime = double.MaxValue;
            string winner = "";

            foreach (KeyValuePair<string, double> racer in racers)
            {
                if (racer.Value < minTime)
                {
                    minTime = racer.Value;
                    winner = racer.Key;
                }
                hour = (int)(racer.Value / 3600);
                minute = (int)((racer.Value % 3600) / 60);
                seconds = (int)(racer.Value % 60);
                Console.WriteLine("Модель машины: " + racer.Key + ", Время: " + hour + " часов, " + minute + " минут, " + seconds + " секунд");
            }

            hour = (int)(minTime / 3600);
            minute = (int)((minTime % 3600) / 60);
            seconds = (int)(minTime % 60);
            Console.WriteLine("\n\nПобедителем оказался гонщик на автомобиле: '" + winner + "'. Он проехал трассу за: " + hour + " часов, " + minute + " минут, " + seconds + " секунд\n\n");
        }

        static void Main(string[] args)
        {
            Dictionary<string, double> racers = new Dictionary<string, double>();
            double raceDistance;
            string modelCar;

            Console.Write("Укажите размер трассы в километрах: ");
            raceDistance = double.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введите марку автомобиля гонщика: ");
                modelCar = Console.ReadLine();

                while (true)
                {
                    if (modelCar.Length == 0 || modelCar.Length > 25)
                    {
                        Console.Write("Модель авто не должна превышать 25 символов: ");
                        modelCar = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Введите скорость автомобиля: ");
                double maxSpeed;
                while (true)
                {
                    maxSpeed = double.Parse(Console.ReadLine());
                    if (maxSpeed < 1 || maxSpeed > 500)
                    {
                        Console.Write("Введите допустимую скорость: ");
                    }
                    else
                    {
                        Car user = new Car(modelCar, maxSpeed);
                        user.SetRaceDistance(raceDistance);
                        user.ShowModelCar();

                        double raceTime = user.RaceTime();
                        racers.Add(modelCar, raceTime);

                        break;
                    }
                }
            }

            Console.WriteLine("\nГонка закончилась\n\nРезультаты:\n");
            StartRace(racers);

            Console.ReadLine();
        }
    }
}