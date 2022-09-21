using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository //herda o que foi atribuido na interface do produto
    {
        private readonly ApplicationContext _context; //representa o banco de dados configurado na ApplicationContext
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
                result = result.Where(w => w.Id == filter.Id);
            
            else if (!string.IsNullOrEmpty(filter.Produto))
                result = result.Where(w => w.Nome.Contains(filter.Produto));
            else
            {
                filter = null;
                return await Task.FromResult(_context.Find<Produto>(filter));
            }             

            return await result
                .AsNoTracking() 
                .FirstOrDefaultAsync();
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task Excluir(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}