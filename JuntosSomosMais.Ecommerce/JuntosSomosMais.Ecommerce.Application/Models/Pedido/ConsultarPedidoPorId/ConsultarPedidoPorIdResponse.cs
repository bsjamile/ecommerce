using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdResponse
    {
        public DateTime DataPedido { get; set; }                
        public ConsultarPedidoPorIdClienteResponse Cliente { get; set; }
        public List<ConsultarPedidoPorIdProdutoResponse> Produtos { get; set; }
    }
}
