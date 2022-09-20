using System;

namespace JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente
{
    public class ListarClienteResponse    
    {
        //informacoes do cliente que sao retornadas quando é solicitado a listagem dos clientes
        //e atraves da propriedade de navegacao é possível retornar as informacoes de endereco

        public int IdCliente { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNasc { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public ListarClienteEnderecoResponse Endereco { get; private set; } //propriedade de Navegacao
    }
}
