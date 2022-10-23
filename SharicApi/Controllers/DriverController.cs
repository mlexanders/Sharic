using Microsoft.AspNetCore.Mvc;
using SharicApi.Repository;
using SharicCommon.Data.Models;

namespace SharicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : BaseCrudController<Driver>
    {
        private readonly BaseCrudRepository<Driver> repository;

        public DriverController(BaseCrudRepository<Driver> repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
