using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataInfrastructure.Mappings
{
    internal class FilmMapConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(f => f.Name).IsRequired().IsUnicode(false).HasMaxLength(100);       
            builder.HasIndex(f => f.Name).IsUnique();
            builder.Property(f => f.ReleaseYear).IsRequired();
            builder.Property(f => f.ParentalRating).IsRequired();

            builder.HasOne(f => f.Gender).WithMany(g => g.Films).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
