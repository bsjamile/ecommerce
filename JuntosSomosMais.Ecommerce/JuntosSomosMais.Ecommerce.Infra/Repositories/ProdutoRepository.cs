using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;
        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<Produto> ConsultarPorId(GetFilterProduto filter)
        {
            var result = _context
                .Produtos
                .AsQueryable();

            if (filter.Id != 0)
            {
                result = result.Where(w => w.Id == filter.Id);
            }
            else if (!string.IsNullOrEmpty(filter.Produto))
            {
                result = result.Where(w => w.Nome.Contains(filter.Produto));
            }
            else
            {
                filter = null;
                return await Task.FromResult(_context.Find<Produto>(filter));
            }

            return await result
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}