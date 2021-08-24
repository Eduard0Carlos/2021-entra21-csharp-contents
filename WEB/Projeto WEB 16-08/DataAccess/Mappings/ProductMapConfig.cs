using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class ProductMapConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CategoryID).IsRequired();

            builder.HasIndex(p => p.Name).IsUnique();
            builder.HasOne(p => p.Category).WithMany(c => c.Products).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
