using System;
using System.Collections.Generic;

public class Fares : IEnumerable<Auto>
{
    private List<Auto> cars = new List<Auto>();

    public void AddAuto(string owner, string date, int number, Parking park)
    {
        cars.Add(new Auto(number, owner, DateTime.Parse(date)));
    }

    public IEnumerator<Auto> GetEnumerator()
    {
        return cars.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return cars.GetEnumerator();
    }

    public object DeepCopy()
    {
        Fares copy = new Fares();
        foreach (Auto car in cars)
        {
            copy.cars.Add((Auto)car.DeepCopy());
        }
        return copy;
    }
}

public enum Parking
{
    Cars,
    FreightCars,
    Buses
}
