using JuntosSomosMais.Ecommerce.Core.Entities;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<Pedido> ConsultarPorId(int id);
    }
}
