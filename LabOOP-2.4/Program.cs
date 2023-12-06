using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Fares fares = new Fares();

        fares.AddAuto("Діо Брандо", DateTime.Today.Date.AddHours(10).AddMinutes(3).AddSeconds(31).ToString(), 12345, Parking.Cars);
        fares.AddAuto("Джонні Джостар", DateTime.Today.Date.AddHours(8).AddMinutes(32).AddSeconds(12).ToString(), 54321, Parking.FreightCars);
        fares.AddAuto("Джайро Цепелі", DateTime.Today.Date.AddHours(5).AddMinutes(53).AddSeconds(41).ToString(), 67890, Parking.Buses);

        foreach (Auto car in fares)
        {
            Console.WriteLine(car);
        }

        Fares copyFares = (Fares)fares.DeepCopy();

        Console.WriteLine("\nКопія списку автомобілів:");
        foreach (Auto car in copyFares)
        {
            Console.WriteLine(car);
        }
    }
}
