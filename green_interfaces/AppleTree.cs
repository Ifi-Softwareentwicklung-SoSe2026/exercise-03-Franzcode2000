using System;

public class AppleTree : Plants, ICookable, IWoodProducer
{
    public AppleTree(string name, int age) : base(name, age) { }

    public void Cook()
    {
        Console.WriteLine($"{Name} liefert Äpfel – daraus wird Apfelmus gekocht.");
    }

    public void ProduceWood()
    {
        Console.WriteLine($"{Name} produziert Holz für Möbel.");
    }
}