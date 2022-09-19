using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationContext _context;
        public PedidoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
        }



        public async Task<Pedido> ConsultarPorId(int id)
        {
            var result = _context
                 .Pedidos
                 .Include(i => i.PedidoProdutos)
                     .ThenInclude(i => i.Produto)
                 .Include(i => i.Cliente)
                 .AsQueryable();

            if (id != 0)
            {
                result = result.Where(w => w.Id == id);
                return await result
                 .AsNoTracking()
                 .FirstOrDefaultAsync(); //Vai no banco e busca = materializacao de busca
            }
            else
            {
                return await Task.FromResult(_context.Find<Pedido>(id));
            }             
        }
    }
}
