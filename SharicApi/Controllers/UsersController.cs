using Microsoft.AspNetCore.Mvc;
using SharicApi.Repository;

namespace SharicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "ADMIN")]
    public class UsersController : BaseCrudController<User>
    {
        private readonly BaseCrudRepository<User> repository;

        public UsersController(BaseCrudRepository<User> repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
