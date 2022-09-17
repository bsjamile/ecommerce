using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Rua)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder.Property(p => p.Bairro)
                .HasColumnType("VARCHAR(30)")
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
                .HasColumnType("VARCHAR(30)")
                .IsRequired();
            builder.Property(p => p.Estado)
                .HasColumnType("CHAR(2)")
                .IsRequired();
            builder.Property(p => p.Pais)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();
        }
    }
}
