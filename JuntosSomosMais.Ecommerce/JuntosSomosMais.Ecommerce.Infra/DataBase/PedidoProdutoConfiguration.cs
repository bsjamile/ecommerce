using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
            builder.HasKey(x => new { x.IdPedido, x.IdProduto });
            builder.Property(p => p.Quantidade)
                .HasColumnType("INT")
                .IsRequired();
        }
    }
}