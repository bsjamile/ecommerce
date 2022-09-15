using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoRequest
    {
        public int Quantidade { get; set; }
        public int IdCliente { get; set; }
        public List<int> IdProdutos { get; set; }
    }
}
