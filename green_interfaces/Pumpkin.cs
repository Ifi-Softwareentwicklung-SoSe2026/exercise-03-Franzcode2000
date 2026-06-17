using System;
namespace green_interfaces
{
    public class Pumpkin : Plants, ICookable
    {
        public Pumpkin(string name, int ageInYears) : base(name, ageInYears) { }

        public override string GetDescription()
        {
            return $"{Name} ist ein Kürbis, {Age} Jahr(e) alt.";
        }

        public string GetCookingSuggestion()
        {
            return "Perfekt für Kürbissuppe oder Ofengemüse.";
        }
    }
}