namespace JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente
{
    public class ListarClienteEnderecoResponse 
    {
        //informacoes de endereco do cliente que sao retornadas quando é solicitado a listagem dos clientes

        public int IdEndereco { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public string PontoDeReferencia { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }

        //o private assegura que essas informações são sejam alteradas a partir de outras classes
    }
}
