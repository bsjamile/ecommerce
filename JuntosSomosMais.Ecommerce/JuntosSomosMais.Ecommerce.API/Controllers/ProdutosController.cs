using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Application.UseCases;
using JuntosSomosMais.Ecommerce.Core.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutosController : ControllerBase
    {
        //O Controller aciona as informacoes do UseCase, onde consta as regras de negocio 
        //O UseCase faz a conexao com o repositorio para acionar a acao que deseja executar no banco de dados

        public readonly IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse> _useCaseConsultarProdutoPorId;
        public readonly IUseCaseAsync<CadastrarProdutoRequest, IActionResult> _useCaseCadastrarProduto;
        //Injecao de Dependencia

        public ProdutosController(IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse> useCaseConsultarProdutoPorId,
                                 IUseCaseAsync<CadastrarProdutoRequest, IActionResult> useCaseCadastrarProduto)
        {
            _useCaseConsultarProdutoPorId = useCaseConsultarProdutoPorId;
            _useCaseCadastrarProduto = useCaseCadastrarProduto;
        }

        [HttpGet]
        public async Task<ActionResult<ConsultarProdutoPorIdResponse>> GetProdutoPorId([FromQuery] GetFilterProduto filter)
        {
            var response = await _useCaseConsultarProdutoPorId.ExecuteAsync(filter);

            if (response == null)
                return new NotFoundObjectResult("Digite um ID ou um Produto Válido!"); //se o filtro recebido for nulo, retorne essa mensagem

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> PostCadastrarProduto([FromBody] CadastrarProdutoRequest cadastrarProdutoRequest)
        {
            return await _useCaseCadastrarProduto.ExecuteAsync(cadastrarProdutoRequest);
        }
    }
}
