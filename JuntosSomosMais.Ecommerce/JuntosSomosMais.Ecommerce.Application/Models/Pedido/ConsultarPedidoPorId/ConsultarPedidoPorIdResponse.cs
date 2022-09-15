using System;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdResponse
    {
        public DateTime DataPedido { get; set; }
        public int Quantidade { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
    }
}
