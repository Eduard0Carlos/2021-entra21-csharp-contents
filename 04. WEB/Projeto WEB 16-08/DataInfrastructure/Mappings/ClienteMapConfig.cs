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
    internal class ClienteMapConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // NVARCHAR -> VARCHAR      
            builder.Property(c => c.CPF).IsFixedLength().IsUnicode(false).HasMaxLength(11).IsRequired();
            builder.HasIndex(c => c.CPF).IsUnique();

            builder.Property(c => c.Nome).IsUnicode(false).HasMaxLength(60).IsRequired(); // fluent API
            builder.Property(c => c.Email).IsUnicode(false).HasMaxLength(100).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.Property(c => c.Telefone).IsUnicode(false).HasMaxLength(15).IsRequired();

            // o cliente tem varias locacoes e uma locacão tera um cliente vinculado e se deletado, não afetara em nada
            builder.HasMany(c => c.Locacao).WithOne(l => l.Cliente).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
