using System;

namespace JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente
{
    public class CadastrarClienteRequest
    {
        //informacoes solicitadas para cadastrar o cliente e atraves da propriedade de navegacao é possível
        //solicitar as informacoes de endereco

        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public CadastrarClienteEnderecoRequest Endereco { get; set; } //Propriedade de Navegacao
    }
}
