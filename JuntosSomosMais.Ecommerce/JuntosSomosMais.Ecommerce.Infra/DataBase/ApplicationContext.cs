using JuntosSomosMais.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace JuntosSomosMais.Ecommerce.Infra.DataBase
{
    public class ApplicationContext : DbContext
    {
        // o EntityFramework possibilita a conexao com o banco de dados

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PedidoProduto> PedidosProdutos { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration()); //centraliza no ApplicationContext as definicoes
                                                                         //de configuracao das tabelas do banco de dados de cada Entidade
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoProdutoConfiguration());
        }

    }
}
