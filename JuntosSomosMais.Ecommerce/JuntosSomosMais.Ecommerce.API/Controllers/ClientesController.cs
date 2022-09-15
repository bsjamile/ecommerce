using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        public readonly IUseCaseAsync<ListarClienteRequest, List<ListarClienteResponse>> _useCaseListarCliente;
        public readonly IUseCaseAsync<CadastrarClienteRequest, CadastrarClienteResponse> _useCaseCadastrarCliente;

        public ClientesController(IUseCaseAsync<ListarClienteRequest, List<ListarClienteResponse>> useCaseListarCliente, 
                                  IUseCaseAsync<CadastrarClienteRequest, CadastrarClienteResponse> useCaseCadastrarCliente)
        {
            _useCaseListarCliente = useCaseListarCliente;
            _useCaseCadastrarCliente = useCaseCadastrarCliente;
        }

        [HttpGet]
        public async Task<List<ListarClienteResponse>> GetTodosClientes([FromQuery] ListarClienteRequest listarClienteRequest)
        {
            return await _useCaseListarCliente.ExecuteAsync(listarClienteRequest);
        }

        [HttpPost]
        public async Task<ActionResult<CadastrarClienteResponse>> Post([FromBody] CadastrarClienteRequest cadastrarClienteRequest)
        {
            return await _useCaseCadastrarCliente.ExecuteAsync(cadastrarClienteRequest);
        }
    }
}
