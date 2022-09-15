using System;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.Core.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNasc { get; private set; }
        public string CPF { get; private set; }
        public string Telefone { get; private set; }        
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public List<Endereco> Enderecos { get; private set; }
        public List<Pedido> Pedidos { get; private set; }
    }
}
