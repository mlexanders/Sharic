using SharicCommon.Data.Difinitions;
using SharicCommon.Data.Interfaces;

namespace SharicCommon.Data.Models
{
    public class Issue : IEntity
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public int DriverId { get; set; }
        public int StateId { get; set; }
        public Trip Trip { get; set; }
        public Driver Driver { get; set; }
        public StateTask StateTask { get; set; }
    }
}
