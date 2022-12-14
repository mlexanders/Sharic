using SharicApi.Repository;

namespace SharicCommon.Data.Models
{
    public class Driver : IEntity
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public Password Password { get; set; }
        public string? Token { get; set; }
        public bool IsFree { get; set; }
    }
}
