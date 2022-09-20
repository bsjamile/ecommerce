using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdResponse
    {
        public DateTime DataPedido { get; private set; }
        public ConsultarPedidoPorIdClienteResponse Cliente { get; private set; }
        public List<ConsultarPedidoPorIdProdutoResponse> Produtos { get; private set; }
    }
}
