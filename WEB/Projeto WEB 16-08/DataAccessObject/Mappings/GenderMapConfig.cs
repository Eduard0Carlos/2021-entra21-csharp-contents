using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataInfrastructure.Mappings
{
    internal class GenderMapConfig : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.Property(g => g.Name).IsRequired().IsUnicode(false).HasMaxLength(70);
            builder.HasIndex(g => g.Name).IsUnique();
        }
    }
}
