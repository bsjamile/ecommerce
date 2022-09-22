using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Repositories
{
    public interface IRepository<T> 
    {
        Task Cadastrar(T obj);

        //foi criada para que outras interfaces herdassem tudo o que foi atribuido a essa interface
        //e recebessem seus repectivos objetos
    }
}
