namespace InsuranceApp.Osago.Entities
{
    public class OsagoPolicy
    {
        public int Id { get; set; }

        public string? Series { get; set; }

        public string? Number { get; set; }

        public Car? Car { get; set; }

        public int? PolicyholderId { get; set; }

        public Policyholder? Policyholder { get; set; }

        public int? OwnerId { get; set; }

        public Owner? Owner { get; set; }

        public virtual IEnumerable<Driver> Drivers { get; set; } = Enumerable.Empty<Driver>();

        public PolicyState PolicyState { get; set; }

        public OsagoPolicy(PolicyState policyState)
        {
            PolicyState = policyState;
        }
    }

    public enum PolicyState
    {
        Draft = 0,
        Paid = 1,
        Issued = 2
    }
}
