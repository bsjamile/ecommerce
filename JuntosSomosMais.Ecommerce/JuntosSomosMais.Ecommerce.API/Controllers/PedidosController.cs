using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidosController : Controller
    {
        //O Controller aciona as informacoes do UseCase, onde consta as regras de negocio 
        //O UseCase faz a conexao com o repositorio para acionar a acao que deseja executar no banco de dados

        public readonly IUseCaseAsync<int, ConsultarPedidoPorIdResponse> _useCaseConsultarPedidoPorId;
        public readonly IUseCaseAsync<CadastrarPedidoRequest, IActionResult> _useCaseCadastrarPedido;
        //Injecao de Dependencia

        public PedidosController(IUseCaseAsync<int, ConsultarPedidoPorIdResponse> useCaseConsultarPedidoPorId,
                                 IUseCaseAsync<CadastrarPedidoRequest, IActionResult> useCaseCadastrarPedido)
        {
            _useCaseConsultarPedidoPorId = useCaseConsultarPedidoPorId;
            _useCaseCadastrarPedido = useCaseCadastrarPedido;
        }

        [HttpGet]
        public async Task<ActionResult<ConsultarPedidoPorIdResponse>> GetPedidoPorId([FromQuery] int id)
        {
            var response = await _useCaseConsultarPedidoPorId.ExecuteAsync(id);

            if (response == null)
                return new NotFoundObjectResult("Digite um ID válido!");

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> PostCadastrarPedido([FromBody] CadastrarPedidoRequest cadastrarPedidoRequest)
        {
            return await _useCaseCadastrarPedido.ExecuteAsync(cadastrarPedidoRequest);
        }
    }
}
