using Microsoft.EntityFrameworkCore;
using AldenHub.Models;

namespace AldenHub.Data
{
    public class AldenDbContext : DbContext
    {
        public AldenDbContext(DbContextOptions<AldenDbContext> options)
            : base(options)
        {
        }

        // ✅ Use the User model from AldenHub.Models
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
    }
}