using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Core.Entities;
using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente
{
    public class CadastrarClienteRequest
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public CadastrarClienteEnderecoRequest Endereco { get; set; }
    }
}
