using JuntosSomosMais.Ecommerce.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> Listar();
        //Task para conseguirmos trabalhar de forma assincrona (Async)
    }
}
