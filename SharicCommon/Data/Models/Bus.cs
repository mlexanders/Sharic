using SharicCommon.Data.Interfaces;

namespace SharicCommon.Data.Models
{
    public class Bus : IEntity
    {
        public int Id { get; set; }
        public int PeopleInn { get; set; }
    }
}
