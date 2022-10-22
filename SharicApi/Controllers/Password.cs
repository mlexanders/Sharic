using SharicApi.Repository;

namespace SharicApi.Controllers
{
    public class Password: IEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
