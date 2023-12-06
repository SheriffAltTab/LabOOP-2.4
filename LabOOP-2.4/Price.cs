using System;

public class Price : INameAndCopy
{
    protected string services;
    protected int occupiedSpace;

    public Price(string services, int occupiedSpace)
    {
        this.services = services;
        OccupiedSpace = occupiedSpace;
    }

    public Price()
    {
        services = "";
        OccupiedSpace = 0;
    }

    public string Services
    {
        get => services;
        set
        {
            if (value.Length == 0)
                throw new ArgumentException("Послуги не можуть бути порожніми.");
            services = value;
        }
    }

    public int OccupiedSpace
    {
        get => occupiedSpace;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Зайняті місця повинні бути більше нуля.");
            occupiedSpace = value;
        }
    }

    public virtual object DeepCopy()
    {
        return new Price(services, occupiedSpace);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Price other = (Price)obj;
        return services == other.services && occupiedSpace == other.occupiedSpace;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(services, occupiedSpace);
    }

    public override string ToString()
    {
        return $"Послуги: {services}, Зайняті місця: {occupiedSpace}";
    }

    string INameAndCopy.Name { get; set; }
}


