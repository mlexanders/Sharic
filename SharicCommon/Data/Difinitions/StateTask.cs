using SharicApi.Repository;

namespace SharicCommon.Data.Difinitions
{
    public class StateTask : IEntity
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeOnboard { get; set; }
        public DateTime TimeUnBoard { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}