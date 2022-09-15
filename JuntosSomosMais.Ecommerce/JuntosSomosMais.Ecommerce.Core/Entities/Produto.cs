using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public List<PedidoProduto> PedidoProdutos { get; private set; }
    }
}
