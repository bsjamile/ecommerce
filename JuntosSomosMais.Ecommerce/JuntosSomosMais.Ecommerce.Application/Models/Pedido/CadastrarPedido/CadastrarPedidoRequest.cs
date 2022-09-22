using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoRequest     
    {
        public int IdCliente { get; set; }
        public List<CadastrarPedidoProdutoRequest> Produtos { get; set; } 

        //o list lista as informações do objeto Produtos para que seja possível
        //cadastrar vários produtos em um pedido       
        
    }
}
