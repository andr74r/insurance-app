namespace InsuranceApp.Osago.Entities
{
    public class Policyholder
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public Policyholder(string name, DateTime birthday)
        {
            Name = name;
            Birthday= birthday;
        }
    }
}
