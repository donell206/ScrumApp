using Microsoft.EntityFrameworkCore;
using Kamban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kamban.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<User> UsersVendredi { get; set; }
        public DbSet<ScrumTask> VendrediScrumTasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { UserId = 1, Name = "Timothy" },
                new User() { UserId = 2, Name = "Francis" },
                new User() { UserId = 3, Name = "Ruben" },
                new User() { UserId = 4, Name = "Mauro" },
                new User() { UserId = 5, Name = "Jarno" }
                );
            modelBuilder.Entity<ScrumTask>().HasData(
                new ScrumTask() { ScrumTaskId = 1, Category = Category.NotCheckedOut, Title = "Microsoft Visual Studio", Description = "Used to develop computer programs, web services, and mobile applications. ", UserId = 2 },
                new ScrumTask() { ScrumTaskId = 2, Category = Category.Done, Title = "Xbox 360", Description = "Gaming console released in 2001", UserId = 1 },
                new ScrumTask() { ScrumTaskId = 3, Category = Category.CheckedOut, Title = "Microsoft Office", Description = "The launch of Microsoft Word, followed by Excel, and Powerpoint in the mid-1980s ", UserId = 3 },
                new ScrumTask() { ScrumTaskId = 4, Category = Category.NotCheckedOut, Title = "Internet Explorer", Description = "The creation and release of Internet Explorer in 1995", UserId = 4 }
                );
        }
    }
}
