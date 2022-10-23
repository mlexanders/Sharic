using Microsoft.AspNetCore.Mvc;
using SharicApi.Repository;
using SharicCommon.Data.Models;

namespace SharicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly BaseCrudRepository<Driver> driversRepository;
        private readonly ILogger<Driver> logger;

        public AuthController(BaseCrudRepository<Driver> driversRepository, ILogger<Driver> logger)
        {
            this.driversRepository = driversRepository;
            this.logger = logger;
        }

        [HttpPost("Registrate")]
        public async Task<ObjectResult> Registrate([FromBody] RegistrationModel registrationModel)
        {
            Driver driver = new()
            {
                Login = registrationModel.Login,
                Password = new Password { Value = registrationModel.Password },
            };

            await driversRepository.Create(driver);
            logger.LogInformation($"User registrate. Login: {driver.Login}");
            return Ok("Registration successful.");
        }

        [HttpPost]
        public async Task<ObjectResult> Auth(AuthModel authModel)
        {
            //Cookie_1=value => token=ahgfjdiogjafodgijaidofg
            var driver = await driversRepository.ReadFirst(d => d.Login == authModel.Login && d.Password.Value == authModel.Password.Value, d => d.Password.Value);
            if (driver != null)
            {
                var token = Guid.NewGuid().ToString();
                driver.Token = token;
                await driversRepository.Update(driver);
                return Ok(driver);
            }
            return StatusCode(401, "User not found.");
        }
    }
}
