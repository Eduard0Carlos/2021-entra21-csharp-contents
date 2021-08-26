using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataInfrastructure.Mappings
{
    internal class ClientMapConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c => c.Name).IsRequired().IsUnicode(false).HasMaxLength(70);
            builder.Property(c => c.PhoneNumber).IsRequired().IsUnicode(false).HasMaxLength(13);
            builder.Property(c => c.Email).IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.HasIndex(c => c.Email).IsUnique();
            builder.Property(c => c.CPF).IsRequired().IsUnicode(false).IsFixedLength().HasMaxLength(11);
            builder.HasIndex(c => c.CPF).IsUnique();
            builder.Property(c => c.BirthDate).IsRequired();

            builder.HasMany(c => c.Locations).WithOne(c => c.Client).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
