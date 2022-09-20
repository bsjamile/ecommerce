using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente> 
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) //configuracao das tabelas e suas colunas do banco de dados
        {
            builder.ToTable("clientes");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(70)")
                .IsRequired();
            builder.Property(p => p.DataNasc)
                .HasColumnType("DATETIME")
                .IsRequired();
            builder.Property(p => p.CPF)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();
            builder.Property(p => p.Telefone)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();
            builder.Property(p => p.Email)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder.Property(p => p.Senha)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();
            builder.HasOne(fk => fk.Endereco)
                .WithOne(fk => fk.Cliente)
                .HasForeignKey<Cliente>(fk => fk.IdEndereco);
        }
    }
}
