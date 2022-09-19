using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoRequest
    {        
        public int IdCliente { get; set; }
        public List<int> IdProdutos { get; set; }
        public List<int> Quantidade { get; set; }
    }
}
