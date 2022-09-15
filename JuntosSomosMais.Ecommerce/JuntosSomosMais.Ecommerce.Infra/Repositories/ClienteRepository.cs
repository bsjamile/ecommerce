using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext _context;
        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cliente>> Listar()
        {
            return await _context
                .Clientes
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
