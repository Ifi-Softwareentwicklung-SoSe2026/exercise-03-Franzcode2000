namespace green_interfaces
{
    public abstract class Plants
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Plants(string name, int ageInYears)
        {
            Name = name;
            Age = ageInYears;
        }

        public abstract string GetDescription();
    }
}