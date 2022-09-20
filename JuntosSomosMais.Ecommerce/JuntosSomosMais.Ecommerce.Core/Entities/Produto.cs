using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class Produto //a entidade representa cada tabela e colunas dessa tabela no banco de dados
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public List<PedidoProduto> PedidoProdutos { get; private set; }
    }
}
