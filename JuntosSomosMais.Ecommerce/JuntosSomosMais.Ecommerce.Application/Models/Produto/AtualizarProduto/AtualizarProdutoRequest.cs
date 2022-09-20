using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.Models.Produto.AtualizarProdutoRequest
{
    public class AtualizarProdutoRequest
    {
        public int IdProduto { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
    }
}
