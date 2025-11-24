namespace CarRentalManagement.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int year { get; set; }
        public string? licencePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
    }
}
