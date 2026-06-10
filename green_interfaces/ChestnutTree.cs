namespace green_interfaces;
using System;

public class ChestnutTree : Plants, IWoodProducer
{
    public ChestnutTree(string name, int age) : base(name, age) { }

    public void ProduceWood()
    {
        Console.WriteLine($"{Name} liefert wertvolles Kastanienholz.");
    }
}