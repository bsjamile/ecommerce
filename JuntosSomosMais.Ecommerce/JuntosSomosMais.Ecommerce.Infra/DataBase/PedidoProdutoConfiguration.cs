using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
            builder.ToTable("pedido_produto");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Quantidade)
                .HasColumnType("INT")
                .IsRequired();
            builder.HasOne(fk => fk.Pedido)
                .WithMany(fk => fk.PedidoProdutos)
                .HasForeignKey(fk => fk.IdPedido);
            builder.HasOne(fk => fk.Produto)
                .WithMany(fk => fk.PedidoProdutos)
                .HasForeignKey(fk => fk.IdProduto);
        }
    }
}