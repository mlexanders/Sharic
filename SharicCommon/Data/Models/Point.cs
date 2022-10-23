using SharicCommon.Data.Interfaces;

namespace SharicCommon.Data.Models
{
    public class Point : IEntity
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
    }
}
