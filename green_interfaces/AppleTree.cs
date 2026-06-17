using System;
namespace green_interfaces
{
    public class AppleTree : Plants, ICookable, IWoodProducer
    {
        public AppleTree(string name, int ageInYears) : base(name, ageInYears) { }

        public override string GetDescription()
        {
            return $"{Name} ist ein Apfelbaum, {Age} Jahre alt.";
        }

        public string GetCookingSuggestion()
        {
            return "Äpfel eignen sich für Apfelmus und Kuchen.";
        }

        public string GetWoodUsage()
        {
            return "Das Holz wird für Möbel genutzt.";
        }
    }
}