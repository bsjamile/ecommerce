using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class Pedido 
    {
        public Pedido(DateTime dataPedido, int idCliente, List<PedidoProduto> pedidoProdutos) 
        {
            DataPedido = dataPedido;
            IdCliente = idCliente;
            PedidoProdutos = pedidoProdutos;
        }

        protected Pedido(){}

        public int Id {get; private set; }
        public DateTime DataPedido { get; private set; }
        public int IdCliente { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<PedidoProduto> PedidoProdutos { get; private set; }
    }
}
