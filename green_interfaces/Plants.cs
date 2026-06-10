public abstract class Plants
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Plants(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string GetInfo()
    {
        return $"{Name}, {Age} Jahre alt";
    }
}