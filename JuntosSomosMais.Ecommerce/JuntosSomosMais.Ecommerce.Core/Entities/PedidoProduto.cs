namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class PedidoProduto //a entidade representa cada tabela e colunas dessa tabela no banco de dados
    {
        public PedidoProduto(int idProduto, int quantidade) //definicao de parametros que o PedidoProduto ira receber
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