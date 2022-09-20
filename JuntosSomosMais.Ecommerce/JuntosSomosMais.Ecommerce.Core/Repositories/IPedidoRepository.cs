using JuntosSomosMais.Ecommerce.Core.Entities;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        //alem de ConsultarPorId, tambem vai ser atribuida a essa interface o que foi atribuida a interface IRepository,
        //ou seja, vai herdar a Task Cadastrar para o objeto Pedido

        Task<Pedido> ConsultarPorId(int id);
    }
}
