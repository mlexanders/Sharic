using Microsoft.AspNetCore.Mvc;
using SharicApi.Services;
using SharicCommon.Data.Models;

namespace SharicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly ILogger<Driver> logger;
        private readonly DateTimeService dateTimeService;

        public TimeController(ILogger<Driver> logger, DateTimeService dateTimeService)
        {
            this.logger = logger;
            this.dateTimeService = dateTimeService;
        }

        [HttpGet]
        public async Task<DateTime> Get()
        {
            return dateTimeService.DateTimeCurrent;
        }

        [HttpPost]
        public async Task<ObjectResult> Set(DateTime dateTime)
        {
            await dateTimeService.Set(dateTime);
            return Ok($"DateTime Set: {dateTimeService.DateTimeCurrent}");
        }
    }
}
