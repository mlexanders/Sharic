using SharicApi.Repository;

namespace SharicCommon.Data.Models
{
    public class Road : IEntity
    {
        public int Id { get; set; }
        public int SourcePointId { get; set; }
        public int TargetPointId { get; set; }
        public int Distance { get; set; }
    }
}
