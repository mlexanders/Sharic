using SharicCommon.Data.Difinitions;
using SharicCommon.Data.Interfaces;

namespace SharicCommon.Data.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public Role Role { get; set; }
        public string Login { get; set; }
        public Password Password { get; set; }
    }
}