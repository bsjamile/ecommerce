namespace JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId
{
    public class ConsultarProdutoPorIdResponse //informacoes do produto que sao retornadas quando um produto é consultado
    {
        public int IdProduto { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
    }
}
