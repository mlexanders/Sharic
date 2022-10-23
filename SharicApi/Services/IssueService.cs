using SharicApi.Repository;
using SharicCommon.Data.Difinitions;
using SharicCommon.Data.Models;

namespace SharicApi.Services
{
    public class IssueService
    {
        private readonly BaseCrudRepository<Issue> issueRepository;
        private readonly BaseCrudRepository<Trip> tripRepository;

        public IssueService(BaseCrudRepository<Issue> issueService, BaseCrudRepository<Trip> tripService)
        {
            this.issueRepository = issueService;
            this.tripRepository = tripService;
        }

        public void Foo()
        {
        }

        public async Task Set(DateTime dateTime)
        {
            var day = dateTime.Day;

            var tripIdsInDay = (await tripRepository.Read(t => t.Date.Day == day)).Select(trip => trip.Id);
            var tripId = (await issueRepository.Read(t => t.Trip.Date.Day == day)).Select(issue => issue.TripId);

            var newTripIds = new HashSet<int>(tripIdsInDay);
            newTripIds.SymmetricExceptWith(tripId);

            foreach (var newTripId in newTripIds)
            {
                await CreateIssue(newTripId);
            }
        }

        private async Task CreateIssue(int newTripId)
        {
            var issue = new Issue()   // IssueService
            {
                TripId = newTripId,
                StateTask = new StateTask()
            };
            // Driver, Bus
            await issueRepository.Create(issue);
        }
    }
}
