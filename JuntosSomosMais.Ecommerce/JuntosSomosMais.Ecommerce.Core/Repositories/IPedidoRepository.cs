using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<Pedido> ConsultarPorId(GetFilterPorId filter);
    }
}
