namespace green_interfaces;
using System;

public class Pumpkin : Plants, ICookable
{
    public Pumpkin(string name, int age) : base(name, age) { }

    public void Cook()
    {
        Console.WriteLine($"{Name} wird zu Kürbissuppe verarbeitet.");
    }
}