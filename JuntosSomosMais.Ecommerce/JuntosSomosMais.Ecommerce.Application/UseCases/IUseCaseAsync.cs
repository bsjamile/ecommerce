using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases
{
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
        //É uma task pq estamos trabalhando de forma assincrona
    }
}
