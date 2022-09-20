using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder) //configuracao das tabelas e suas colunas do banco de dados
        {
            builder.ToTable("enderecos");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Rua)
                .HasColumnType("VARCHAR(70)")
                .IsRequired();
            builder.Property(p => p.Bairro)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder.Property(p => p.Numero)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();
            builder.Property(p => p.Cep)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();
            builder.Property(p => p.Complemento)
                .HasColumnType("VARCHAR(50)");
            builder.Property(p => p.PontoDeReferencia)
                .HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Cidade)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder.Property(p => p.Estado)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder.Property(p => p.Pais)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
        }
    }
}
