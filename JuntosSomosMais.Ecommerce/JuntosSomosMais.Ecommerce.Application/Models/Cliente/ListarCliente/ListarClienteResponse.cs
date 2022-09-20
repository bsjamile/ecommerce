using System;

namespace JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente
{
    public class ListarClienteResponse
    {
        public int IdCliente { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNasc { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public ListarClienteEnderecoResponse Endereco { get; private set; }
        //Propriedade de Navegacao
    }
}
