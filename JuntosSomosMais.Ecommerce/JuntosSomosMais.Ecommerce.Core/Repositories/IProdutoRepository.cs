using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> ConsultarPorId(int id);
    }
}
