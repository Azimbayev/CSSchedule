using CSSchedule.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSchedule.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "edilzhan12",
                Fullname = "Azimbayev Edilzhan",
                CreatedAt = new DateTime(2019, 10, 3)
            },
            new User
            { 
                Id = 2,
                Username = "mxmadina",
                Fullname = "Azimbayeva Madina",
                CreatedAt = new DateTime(2019, 10, 3)
            });
        }
    }
}
