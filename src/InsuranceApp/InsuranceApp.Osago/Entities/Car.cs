namespace InsuranceApp.Osago.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int EnginePower { get; set; }

        public Car(string brand, string model, int year, int enginePower)
        {
            Brand = brand;
            Model = model;
            Year = year;
            EnginePower = enginePower;
        }
    }
}
