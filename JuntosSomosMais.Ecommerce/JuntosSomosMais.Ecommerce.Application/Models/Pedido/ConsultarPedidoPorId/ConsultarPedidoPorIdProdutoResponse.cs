namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdProdutoResponse //informacoes dos produtos que sao retornadas quando um pedido é consultado
    {
        public int IdProduto { get; private set; }
        public string Produto { get; private set; }
        public string Quantidade { get; private set; }
        public float PrecoUnitario { get; private set; }
    }
}
