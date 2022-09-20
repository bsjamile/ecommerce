using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases
{
    public interface IUseCaseOneAsync<TResponse>
    {
        //UseCase para aceitar apenas um parametro e usar no ListarClientes que só retorna, nao recebe nenhuma informacao
        Task<TResponse> ExecuteAsync();
    }
}
