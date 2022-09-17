using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdResponse
    {
        public DateTime DataPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public List<ConsultarPedidoPorIdProdutoResponse> Produtos {get;set;}
        public ConsultarPedidoPorIdClienteResponse Cliente { get; set; }
    }
}
