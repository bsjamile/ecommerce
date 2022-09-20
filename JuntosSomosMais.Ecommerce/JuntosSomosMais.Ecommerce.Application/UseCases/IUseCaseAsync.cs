using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases
{
    public interface IUseCaseAsync<TRequest, TResponse> //Todas as classes que herdam dessa, vai ser obrigada a receber 2 parametros
    {
        Task<TResponse> ExecuteAsync(TRequest request);
        //É uma task pq estamos trabalhando de forma assincrona
    }
}
