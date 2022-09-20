namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class Endereco //a entidade representa cada tabela e colunas dessa tabela no banco de dados
    {
        public int Id { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public string PontoDeReferencia { get; private set; }
        public string Cidade { get; private set; }        
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public Cliente Cliente { get; private set; }
    }
}

