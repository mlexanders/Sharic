using SharicApi.Repository;
using SharicCommon.Data.Difinitions;

namespace SharicCommon.Data.Models
{
    public class Trip : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TripType TripType { get; set; } // прилет-A  вылет-B
        public string? Terminal { get; set; }
        public string? AirlanesCode { get; set; }
        public string? Airport { get; set; }
        public string? AircraftType { get; set; }
        public string? ParkNumber { get; set; }
        public string? GateNumber { get; set; }
        public int PassengerCount { get; set; }
    }
}