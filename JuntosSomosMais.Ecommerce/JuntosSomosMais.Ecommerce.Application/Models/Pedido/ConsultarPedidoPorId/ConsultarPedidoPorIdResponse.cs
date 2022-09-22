using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdResponse
    {
        public DateTime DataPedido { get; private set; }
        public ConsultarPedidoPorIdClienteResponse Cliente { get; private set; } //atraves da propriedade de navegacao,
                                                                                 //é possível retornar as informacoes do cliente quando um pedido é consultado
        public List<ConsultarPedidoPorIdProdutoResponse> Produtos { get; private set; } //o List lista o objeto Produtos para retornar a informacao
                                                                                        //de cada produto especificamente
    }
}
