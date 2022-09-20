using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoRequest
    {        
        public int IdCliente { get; set; }
        public List<CadastrarPedidoProdutoRequest> Produtos { get; set; }
    }
}
