using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInfrastructure.Mappings
{
    internal class FilmeMapConfig : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.Property(f => f.Nome).IsRequired().HasMaxLength(70);

            builder.HasOne(f => f.Genero).WithMany(g => g.Filmes).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(f => f.Locacao).WithMany(l => l.Filmes).UsingEntity<Dictionary<string, object>>("FilmLocation",
              j => j.HasOne<Locacao>().WithMany().HasForeignKey("LocationsID").HasConstraintName("FK_FilmLocation_Locations_LocationsID").OnDelete(DeleteBehavior.NoAction),
              j => j.HasOne<Filme>().WithMany().HasForeignKey("FilmsID").HasConstraintName("FK_FilmLocation_Films_FilmsID").OnDelete(DeleteBehavior.NoAction));



        }
    }
}
