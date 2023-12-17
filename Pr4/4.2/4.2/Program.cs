using System;

class Delivery
{
    public string DescriptionOrder { get; }
    public int WeightOrder { get; }

    public Delivery(string descriptionOrder, int weightOrder)
    {
        DescriptionOrder = descriptionOrder;
        WeightOrder = weightOrder;
    }

    public string Order()
    {
        return DescriptionOrder;
    }
}

class DeliveryService
{
    private int limitWeight;

    public DeliveryService()
    {
        limitWeight = 5;
    }

    public void SendOrders(Delivery delivery)
    {
        if (limitWeight >= delivery.WeightOrder)
        {
            limitWeight -= delivery.WeightOrder;
            Console.WriteLine($"'{delivery.Order()}': отправка удалась");
        }
        else
        {
            Console.WriteLine($"'{delivery.Order()}': отправка не удалась, превышена норма веса на {delivery.WeightOrder - limitWeight} кг.");
        }
    }
}

class PostOffice
{
    public static void StartLine()
    {
        Console.WriteLine("----------------------------------------------------");
    }

    public static void HelloString()
    {
        Console.WriteLine("Приветствуем вас на нашей почте");
    }
}

class Program
{
    static void Main()
    {
        PostOffice.StartLine();
        PostOffice.HelloString();
        PostOffice.StartLine();

        Delivery lamp = new Delivery("Лампа", 1);
        Delivery table = new Delivery("Стол", 10);

        DeliveryService deliveryService = new DeliveryService();
        deliveryService.SendOrders(lamp);
        deliveryService.SendOrders(table);
    }
}
