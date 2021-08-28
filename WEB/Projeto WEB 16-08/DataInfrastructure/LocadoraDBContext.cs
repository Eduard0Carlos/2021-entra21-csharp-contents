using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace DataInfrastructure
{
    public class LocadoraDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\LocasexDB.mdf;Integrated Security=True;Connect Timeout=5", x => x.EnableRetryOnFailure(5));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // procura as config de mapping dentro do projeto 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // retorna um projeto que contem o metodo em execução

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }




    }
}
