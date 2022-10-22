using SharicApi.Repository;

namespace SharicCommon.Data.Models
{
    public class Point : IEntity
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
    }
}
