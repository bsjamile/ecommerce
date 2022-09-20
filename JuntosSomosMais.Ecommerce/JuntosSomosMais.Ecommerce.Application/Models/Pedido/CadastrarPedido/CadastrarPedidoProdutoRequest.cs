namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido
{
    public class CadastrarPedidoProdutoRequest //informacoes solicitadas para cadastrar o pedido do cliente
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; } 
        
        //como a finalidade é cadastrar um novo pedido,
        //nao utiliza o private no set para que seja possivel realizar o cadastro
        
    }
}
