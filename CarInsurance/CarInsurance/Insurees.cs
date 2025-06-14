namespace CarInsurance
{
    public class Insurees
    {
        public Guid Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string ? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public required int CarYear { get; set; }

        public required string CarMake { get; set; }


        public required string CarModel { get; set; }

        public bool DUI { get; set; }

        public int SpeedingTickets { get; set; }

        public CoverageType Coverage { get; set; }
        public decimal Quote { get; set; }



    }

    public enum CoverageType
    {
        Full,
        Liability
    }

}


