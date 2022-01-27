using Microsoft.EntityFrameworkCore;
using TaskAssignment.Data.MapConfig;
using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Data.Configuration
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserTask> UserTask => Set<UserTask>();
        public DbSet<User> User => Set<User>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // docker run --name taskdb -p 5432:5432 -e POSTGRES_PASSWORD=mysecretpassword -e POSTGRES_DB=taskdb -d --rm postgres 
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=mysecretpassword;Host=localhost;Port=5432;Database=taskdb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapConfig());
            modelBuilder.ApplyConfiguration(new UserTaskMapConfig());
        }
    }
}
