using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente
{
    public class ListarClienteEnderecoResponse
    {
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public string PontoDeReferencia { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
    }
}
