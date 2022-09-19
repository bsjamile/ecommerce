using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoProdutoRequest
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
