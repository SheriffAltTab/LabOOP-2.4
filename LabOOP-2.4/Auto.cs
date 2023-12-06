using System;

public class Auto : INameAndCopy
{
    public int RegNumber { get; set; }
    public string Owner { get; set; }
    public DateTime Date { get; set; }

    public Auto(int regNumber, string owner, DateTime date)
    {
        RegNumber = regNumber;
        Owner = owner;
        Date = date;
    }

    public Auto()
    {
        RegNumber = 0;
        Owner = "Default Owner";
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Державний номер: {RegNumber}, Власник: {Owner}, Дата: {Date}";
    }

    public object DeepCopy()
    {
        return new Auto(RegNumber, Owner, Date);
    }

    string INameAndCopy.Name { get; set; }
}
