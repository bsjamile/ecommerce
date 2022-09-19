using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdProdutoResponse
    {
        public int IdProduto { get; set; }
        public string Produto { get; set; }
        public string Quantidade { get; set; }
        public float PrecoUnitario { get; set; }
    }
}
