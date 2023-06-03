namespace InsuranceApp.Osago.Entities
{
    public class Driver
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ExperienceYears { get; set; }

        public Driver(string name, int experienceYears)
        {
            Name = name;
            ExperienceYears = experienceYears;
        }
    }
}
