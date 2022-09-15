using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IRepository<T>
    {
        Task Cadastrar(T obj);
    }
}
