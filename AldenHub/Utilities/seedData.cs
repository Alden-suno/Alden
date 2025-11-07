using System.Collections.Generic;
using System.Linq;
using AldenHub.Data;
using AldenHub.Models;

namespace AldenHub.Utilities
{
    public static class SeedData
    {
        public static void Initialize(AldenDbContext context)
        {
            context.Database.EnsureCreated();

            // ✅ Seed Users
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        Email = "admin@aldenhub.com",
                        PasswordHash = "admin123hashed",
                        FullName = "Alden Admin",
                        IsAdmin = true,
                        IsVerified = true
                    },
                    new User
                    {
                        Email = "user@aldenhub.com",
                        PasswordHash = "user123hashed",
                        FullName = "Regular User",
                        IsVerified = true
                    }
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }

            // ✅ Seed Businesses
            if (!context.Businesses.Any())
            {
                var businesses = new List<Business>
                {
                    new Business { Name = "Alden Hub Bakery", Description = "Fresh bread and cakes", Owner = "Alden Admin" },
                    new Business { Name = "Alden Fitness", Description = "Gym and wellness center", Owner = "Regular User" }
                };

                context.Businesses.AddRange(businesses);
                context.SaveChanges();
            }
        }
    }
}