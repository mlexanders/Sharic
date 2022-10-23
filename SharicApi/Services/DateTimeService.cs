namespace SharicApi.Services
{
    public static class DateTimeService
    {
        public static DateTime DateTimeCurrent { get; private set; } = DateTime.UtcNow;

        public delegate void DateTimeHandler();

        public static event DateTimeHandler? SetTime;


        public static void Set(DateTime dateTime)
        {
            DateTimeCurrent = dateTime;
            SetTime?.Invoke();
        }

        //public async Task Set(DateTime dateTime)
        //{
        //    DateTimeCurrent = dateTime;
        //    var day = dateTime.Day;

        //    var tripIdsInDay = (await tripRepository.Read(t => t.Date.Day == day)).Select(trip => trip.Id);
        //    var tripId = (await issueRepository.Read(t => t.Trip.Date.Day == day)).Select(issue => issue.TripId);

        //    var newTripIds = new HashSet<int>(tripIdsInDay);
        //    newTripIds.SymmetricExceptWith(tripId);

        //    foreach (var newTripId in newTripIds)
        //    {
        //        await CreateIssue(newTripId);
        //    }
        //}

        //private async Task CreateIssue(int newTripId)
        //{
        //    var issue = new Issue()   // IssueService
        //    {
        //        TripId = newTripId,
        //        StateTask = new StateTask()
        //    };
        //    // Driver, Bus
        //    await issueRepository.Create(issue);
        //}
    }
}
