using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository //herda o que foi atribuido na interface do cliente
    {
        private readonly ApplicationContext _context; //representa o banco de dados configurado na ApplicationContext
        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente); //adicionar as informacoes do cliente 
            await _context.SaveChangesAsync(); //salvar essas informacoes no banco de dados
        }

        public async Task<IEnumerable<Cliente>> Listar()
        {
            return await _context
                .Clientes //acessar as informacoes do banco de dados da tabela Clientes que foi definido no ApplicationContext
                .Include(id => id.Endereco) //incluir as informacoes da tabela enderecos quando for listar os clientes
                .AsNoTracking() //retorna uma consulta e as informacoes nao serao armazenadas 
                .ToListAsync(); //lista as informacoes
        }
    }
}
