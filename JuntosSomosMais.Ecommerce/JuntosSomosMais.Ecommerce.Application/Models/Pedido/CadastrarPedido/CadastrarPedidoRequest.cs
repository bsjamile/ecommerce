using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoRequest     
    {
        //informacoes solicitadas para cadastrar o pedido do cliente.
        //um cliente pode fazer varios pedidos. Entao, atraves da lista do objeto Produtos,
        //solicitamos as informacoes referentes a cada produto adicionado ao pedido

        public int IdCliente { get; set; }
        public List<CadastrarPedidoProdutoRequest> Produtos { get; set; } 

        //o list lista as informações do objeto Produtos para que seja possível
        //cadastrar vários produtos em um pedido       
        
    }
}
