using System;

static class OutPut
{
    static public void Message()
    {
        Console.WriteLine("\n====================================================================================================\n");
    }
}
class Vehicle
{
    public string NameVehicle { get; set; }
    public int MaxSpeed { get; set; }
}
class Polytechnic : Vehicle
{
    private string carModel;
    private int priceCar { get; set; }
    public Polytechnic(int priceVehicle)
    {
        this.priceCar = priceVehicle;
    }


    private string ModelCar()
    {
        string car = "ПОЛИТЕХ-МАШИНА";
        return car;
    }
    public Polytechnic() { }

    private bool TimeTechnic()
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday) return true;
        else return false;
    }
    public void Music()
    {
        TimeSpan startTime = new TimeSpan(9, 0, 0);
        TimeSpan endTime = new TimeSpan(18, 0, 0);

        if (priceCar >= 80000)
        {
            // Проверяем, что текущий день недели не является воскресеньем
            if (!TimeTechnic())
            {
                //Текущее время совпадает со временем работы политеха
                if (DateTime.Now.TimeOfDay >= startTime && DateTime.Now.TimeOfDay <= endTime)
                {
                    // Промежуток в 5 минут между 9:00 9:05
                    if (DateTime.Now.TimeOfDay >= startTime && DateTime.Now.TimeOfDay <= new TimeSpan(9, 5, 0))
                    {
                        Console.WriteLine($"Советую бежать, {NameVehicle} уже почти включила музыку. У вас осталось {_ = (new TimeSpan(9, 5, 0)) - startTime}\n");
                    }
                    else
                    {
                        Console.WriteLine($"Скорее всего вы уже не видите данное сообщение, {NameVehicle} все-таки смогла...\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Тех закрыт, {NameVehicle} ищет новую композицию.\n");
                }
            }
            else
            {
                // Тех закрыт
                Console.WriteLine($"Вам повезло, в воскресенье {NameVehicle} спит.\n");
            }
        }
        //Машина дешевле 80к
        else
        {
            Console.WriteLine($"Вам повезло, {NameVehicle} развалилась по дороге\n");
        }
    }
}
class Plane : Vehicle
{
    private bool checkError()
    {
        if (MaxSpeed <= 60)
        {
            return false;
        }
        return true;
    }
    public void ImpactToPeople()
    {
        if (checkError())
        {
            Console.WriteLine("Процесс опыления запущен...\n");
        }
        else
        {
            Console.WriteLine($"Хлеба не будет, {MaxSpeed} km/h не хватило для взлета.\n");
        }
    }
}
class Mixer : Vehicle
{
    public int priceToTurn { get; set; }
    private int Balance { get; set; }
    public Mixer(int balance)
    {
        this.Balance = balance;
    }

    private int priceToMix()
    {
        return MaxSpeed / priceToTurn;
    }
    private bool Payment()
    {
        if (Balance - priceToMix() >= 0)
        {
            Balance = Balance - priceToMix();
            return true;
        }
        return false;
    }
    public void StartToMix()
    {
        if (Payment())
        {
            Console.WriteLine($"\nЕдинственная фунция бетономешалки работает исправно, за {MaxSpeed} оборотов вам пришлось отдать {priceToMix()} рублей.\n\nВаш текущий баланс: {Balance}");
        }
        else
        {
            Console.WriteLine($"На вашем счете не так много денег, чтобы пользоваться {NameVehicle} вечно");
        }
    }
}

class Program
{
    static void Main()
    {
        OutPut.Message();
        int priceCar;
        Console.Write("Введите цену автомобиля: ");
        priceCar = Convert.ToInt32(Console.ReadLine());

        Polytechnic polytechnic = new Polytechnic(priceCar);
        polytechnic.NameVehicle = "ПОЛИТЕХ-МАШИНА";

        polytechnic.Music();

        OutPut.Message();
        int speedPlane;
        Console.Write("Укажите скорость самолета: ");
        speedPlane = Convert.ToInt32(Console.ReadLine());

        Plane plane = new Plane();
        plane.MaxSpeed = speedPlane;

        plane.ImpactToPeople();

        OutPut.Message();
        int Balance = 100;
        int SpeedMixer;
        Console.Write("Укажите, сколько оборотов в минуту вам нужно: ");
        SpeedMixer = Convert.ToInt32(Console.ReadLine());

        Mixer mixer = new Mixer(Balance);
        mixer.NameVehicle = "БЕТОНОМЕШАЛКА";
        mixer.priceToTurn = 10;
        mixer.MaxSpeed = SpeedMixer;

        mixer.StartToMix();

        OutPut.Message();
    }
}