using JuntosSomosMais.Ecommerce.Application.Models.Produto.AtualizarProdutoRequest;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Application.UseCases;
using JuntosSomosMais.Ecommerce.Core.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public readonly IUseCaseAsync<AtualizarProdutoRequest, IActionResult> _useCaseAtualizarProduto;
        public readonly IUseCaseOneAsync<List<ConsultarProdutoPorIdResponse>> _useCaseListarProduto;
        public readonly IUseCaseAsync<int, IActionResult> _useCaseDeletarProduto;
        //Injecao de Dependencia

        public ProdutosController(IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse> useCaseConsultarProdutoPorId,
                                 IUseCaseAsync<CadastrarProdutoRequest, IActionResult> useCaseCadastrarProduto,                                 
                                 IUseCaseAsync<AtualizarProdutoRequest, IActionResult> useCaseAtualizarProduto,
                                 IUseCaseAsync<int, IActionResult> useCaseDeletarProduto,
                                 IUseCaseOneAsync<List<ConsultarProdutoPorIdResponse>> useCaseListarProduto)
        {
            _useCaseConsultarProdutoPorId = useCaseConsultarProdutoPorId;
            _useCaseCadastrarProduto = useCaseCadastrarProduto;
            _useCaseAtualizarProduto = useCaseAtualizarProduto;
            _useCaseDeletarProduto = useCaseDeletarProduto;
            _useCaseListarProduto = useCaseListarProduto;
        }

        [HttpGet]
        public async Task<List<ConsultarProdutoPorIdResponse>> GetListarProduto()
        {
            return await _useCaseListarProduto.ExecuteAsync();
        }

        [HttpGet("id")]
        public async Task<ActionResult<ConsultarProdutoPorIdResponse>> GetProdutoPorId([FromQuery] GetFilterProduto filter)
        {
            var response = await _useCaseConsultarProdutoPorId.ExecuteAsync(filter);

            if (response == null)
                return new NotFoundObjectResult("Digite um ID ou um Produto Válido!");

            return new OkObjectResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> PostCadastrarProduto([FromBody] CadastrarProdutoRequest cadastrarProdutoRequest)
        {
            return await _useCaseCadastrarProduto.ExecuteAsync(cadastrarProdutoRequest);
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AtualizarProdutoRequest produto)
        {
           return await _useCaseAtualizarProduto.ExecuteAsync(produto);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            return await _useCaseDeletarProduto.ExecuteAsync(id);
        }
    }
}
