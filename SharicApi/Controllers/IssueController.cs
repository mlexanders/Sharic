using Microsoft.AspNetCore.Mvc;
using SharicApi.Repository;
using SharicApi.Services;
using SharicCommon.Data.Models;

namespace SharicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssueController : ControllerBase
    {
        private readonly BaseCrudRepository<Issue> repository;

        public IssueController(BaseCrudRepository<Issue> repository)
        {
            this.repository = repository;
        }

        public async Task<Issue[]> Get()
        {
            var date = DateTimeService.DateTimeCurrent.Day;
            var issue = await repository.Read(t => t.Trip.Date.Day == date);
            return issue;
        }
    }
}
