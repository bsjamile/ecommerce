using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> ConsultarPorId(GetFilterProduto filter);
        Task<IEnumerable<Produto>> Listar();
        Task Atualizar(Produto obj);
        Task Excluir(int id);
    }
}
