using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        //alem de ConsultarPorId, tambem vai ser atribuida a essa interface o que foi atribuida a interface IRepository,
        //ou seja, vai herdar a Task Cadastrar para o objeto Produto

        Task<Produto> ConsultarPorId(GetFilterProduto filter);
        Task Atualizar(Produto obj);
        Task Excluir(int id);
    }
}
