namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public string? CustomerId { get; set; }
    }
}
