using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessObject
{
    public class ErpDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlo\Documents\ErpDataBase.mdf;Integrated Security = True; Connect Timeout = 30";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
