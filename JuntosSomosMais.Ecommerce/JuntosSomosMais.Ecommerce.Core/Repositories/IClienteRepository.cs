using JuntosSomosMais.Ecommerce.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>    
    {
        //alem de Listar, tambem vai ser atribuida a essa interface o que foi atribuida a interface IRepository,
        //ou seja, vai herdar a Task Cadastrar para o objeto Cliente

        Task<IEnumerable<Cliente>> Listar();

        //Task para conseguirmos trabalhar de forma assincrona (Async)
    }
}
