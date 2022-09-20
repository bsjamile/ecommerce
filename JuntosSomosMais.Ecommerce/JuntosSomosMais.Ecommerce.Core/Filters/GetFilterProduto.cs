namespace JuntosSomosMais.Ecommerce.Core.Filters
{
    public class GetFilterProduto
    {
        //essa classe representa um filtro para possibilitar consultar as informacoes do produto 
        //atraves do Id ou do Nome do Produto

        public int Id { get; set; }
        public string Produto { get; set; }

    }
}
