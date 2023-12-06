public class Person : INameAndCopy
{
    public string[] Cars { get; set; }

    public Person(string[] cars)
    {
        Cars = cars;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person other = (Person)obj;
        return Enumerable.SequenceEqual(Cars, other.Cars);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            foreach (string car in Cars)
                hash = hash * 23 + car.GetHashCode();
            return hash;
        }
    }

    public object DeepCopy()
    {
        return new Person(Cars.ToArray());
    }

    string INameAndCopy.Name { get; set; }
}
