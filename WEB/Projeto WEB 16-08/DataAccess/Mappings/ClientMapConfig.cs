using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class ClientMapConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(70);
            builder.Property(c => c.CPF).IsRequired().IsUnicode(false).IsFixedLength().HasMaxLength(11);
            builder.Property(c => c.RG).IsRequired().IsUnicode(false).HasMaxLength(13);
            builder.Property(c => c.Email).IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(c => c.PhoneNumber).IsRequired().IsUnicode(false).HasMaxLength(13);

            builder.HasIndex(c => c.CPF).IsUnique();
            builder.HasIndex(c => c.RG).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
