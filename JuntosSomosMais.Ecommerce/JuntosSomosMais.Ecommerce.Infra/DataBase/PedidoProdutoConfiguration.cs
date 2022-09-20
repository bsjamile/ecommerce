using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)  //configuracao das tabelas e suas colunas do banco de dados
        {
            builder.ToTable("pedidos_produtos");
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