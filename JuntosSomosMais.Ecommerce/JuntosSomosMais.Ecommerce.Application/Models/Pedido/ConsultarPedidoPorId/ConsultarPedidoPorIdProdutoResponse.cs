namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdProdutoResponse
    {
        public int IdProduto { get; private set; }
        public string Produto { get; private set; }
        public string Quantidade { get; private set; }
        public float PrecoUnitario { get; private set; }
    }
}
