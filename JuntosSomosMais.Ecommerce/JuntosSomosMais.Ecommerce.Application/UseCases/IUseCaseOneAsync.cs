using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases
{
    public interface IUseCaseOneAsync<TResponse> //UseCase para aceitar apenas um parametro
    {        
        Task<TResponse> ExecuteAsync();
    }
}
