using Microsoft.EntityFrameworkCore;
using SharicApi.Controllers;

namespace SharicApi
{
    public class AppDbContext : DbContext
    {
        DbSet<User> Users { get; set; } = null!;

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
