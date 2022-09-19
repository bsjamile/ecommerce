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
        public readonly IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse> _useCaseConsultarProdutoPorId;
        public readonly IUseCaseAsync<CadastrarProdutoRequest, CadastrarProdutoResponse> _useCaseCadastrarProduto;

        public ProdutosController(IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse> useCaseConsultarProdutoPorId,
                                 IUseCaseAsync<CadastrarProdutoRequest, CadastrarProdutoResponse> useCaseCadastrarProduto)
        {
            _useCaseConsultarProdutoPorId = useCaseConsultarProdutoPorId;
            _useCaseCadastrarProduto = useCaseCadastrarProduto;
        }

        [HttpGet]
        public async Task<ActionResult<ConsultarProdutoPorIdResponse>> GetProdutoPorId([FromQuery] GetFilterProduto filter)
        {
            var response = await _useCaseConsultarProdutoPorId.ExecuteAsync(filter);
            if (response == null)
                return new NotFoundObjectResult("Digite um ID ou um Produto Válido!");

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<ActionResult<CadastrarProdutoResponse>> Post([FromBody] CadastrarProdutoRequest cadastrarProdutoRequest)
        {
            return await _useCaseCadastrarProduto.ExecuteAsync(cadastrarProdutoRequest);
        }
    }
}
