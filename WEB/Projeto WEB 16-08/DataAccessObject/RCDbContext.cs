using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessObject
{
    public class RCDbContext : DbContext
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Location> Locations { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlo\Documents\RCDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
