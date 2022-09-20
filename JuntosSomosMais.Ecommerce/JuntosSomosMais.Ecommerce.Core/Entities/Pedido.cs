using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class Pedido //a entidade representa cada tabela e colunas dessa tabela no banco de dados
    {
        public Pedido(DateTime dataPedido, int idCliente, List<PedidoProduto> pedidoProdutos) //definicao de parametros que o Pedido ira receber
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
