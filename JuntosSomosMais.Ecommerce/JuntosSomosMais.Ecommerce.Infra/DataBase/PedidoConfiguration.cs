using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder) //configuracao das tabelas e suas colunas do banco de dados
        {
            builder.ToTable("pedidos");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.DataPedido)
                .HasColumnType("DATETIME")
                .IsRequired();            
            builder.HasOne(fk => fk.Cliente)
                .WithMany(fk => fk.Pedidos)
                .HasForeignKey(fk => fk.IdCliente);
        }
    }
}
