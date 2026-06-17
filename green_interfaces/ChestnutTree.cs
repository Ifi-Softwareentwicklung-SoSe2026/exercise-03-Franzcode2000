using System;
namespace green_interfaces
{
    public class ChestnutTree : Plants, IWoodProducer
    {
        public ChestnutTree(string name, int ageInYears) : base(name, ageInYears) { }

        public override string GetDescription()
        {
            return $"{Name} ist eine Edelkastanie, {Age} Jahre alt.";
        }

        public string GetWoodUsage()
        {
            return "Kastanienholz ist wetterfest – ideal für Zäune.";
        }
    }
}