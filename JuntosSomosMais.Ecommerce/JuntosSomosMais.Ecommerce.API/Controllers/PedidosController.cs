using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Application.UseCases;
using JuntosSomosMais.Ecommerce.Core.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidosController : Controller
    {
        public readonly IUseCaseAsync<GetFilterPorId, ConsultarPedidoPorIdResponse> _useCaseConsultarPedidoPorId;
        public readonly IUseCaseAsync<CadastrarPedidoRequest, CadastrarPedidoResponse> _useCaseCadastrarPedido;

        public PedidosController(IUseCaseAsync<GetFilterPorId, ConsultarPedidoPorIdResponse> useCaseConsultarPedidoPorId,
                                 IUseCaseAsync<CadastrarPedidoRequest, CadastrarPedidoResponse> useCaseCadastrarPedido)
        {
            _useCaseConsultarPedidoPorId = useCaseConsultarPedidoPorId;
            _useCaseCadastrarPedido = useCaseCadastrarPedido;
        }

        [HttpGet]
        public async Task<ActionResult<ConsultarPedidoPorIdResponse>> GetPedidoPorId([FromQuery] GetFilterPorId filter)
        {
            var response = await _useCaseConsultarPedidoPorId.ExecuteAsync(filter);
            if (response == null)
                return new NotFoundObjectResult("Não encontrado");

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<ActionResult<CadastrarPedidoResponse>> Post([FromBody] CadastrarPedidoRequest cadastrarPedidoRequest)
        {
            return await _useCaseCadastrarPedido.ExecuteAsync(cadastrarPedidoRequest);
        }
    }
}
