using Microsoft.EntityFrameworkCore;
using SharicApi.Controllers;
using SharicCommon.Data.Difinitions;
using SharicCommon.Data.Models;

namespace SharicApi
{
    public class AppDbContext : DbContext
    {
        DbSet<User> Users { get; set; } = null!;
        DbSet<Driver> Drivers { get; set; } = null!;
        DbSet<Point> Points { get; set; } = null!;
        DbSet<Road> Roads { get; set; } = null!;
        DbSet<Trip> Trips { get; set; } = null!;
        DbSet<Issue> Tasks { get; set; } = null!;
        DbSet<StateTask> StateTasks { get; set; } = null!;
        DbSet<Bus> Buses { get; set; } = null!;

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
