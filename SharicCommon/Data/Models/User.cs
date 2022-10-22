using SharicApi.Repository;
using SharicCommon.Data.Difinitions;

namespace SharicApi.Controllers
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public Role Role { get; set; }
    }
}