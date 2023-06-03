namespace InsuranceApp.Osago.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public Owner(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
