namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class PedidoProduto 
    {
        public PedidoProduto(int idProduto, int quantidade) 
        {
            IdProduto = idProduto;
            Quantidade = quantidade;
        }

        public int Id { get; private set; }
        public int IdPedido { get; private set; }
        public Pedido Pedido { get; private set; }
        public int IdProduto { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
    }
}