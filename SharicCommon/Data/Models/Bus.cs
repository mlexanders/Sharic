using SharicApi.Repository;

namespace SharicCommon.Data.Models
{
    public class Bus : IEntity
    {
        public int Id { get; set; }
        public int PeopleInn { get; set; }
    }
}
