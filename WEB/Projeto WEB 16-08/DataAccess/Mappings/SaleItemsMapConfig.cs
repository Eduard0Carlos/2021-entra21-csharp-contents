using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class SaleItemsMapConfig : IEntityTypeConfiguration<SaleItems>
    {
        public void Configure(EntityTypeBuilder<SaleItems> builder)
        {
            builder.HasKey(item => new { item.SaleID, item.ProductID });
        }
    }
}
