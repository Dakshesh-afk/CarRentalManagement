namespace CarRentalManagement.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? DrivingLicense { get; set; }

        public string? address { get; set; }

        public string? ContactNumber { get; set; }

        public string? EmailAddress { get; set; }
    }
}
