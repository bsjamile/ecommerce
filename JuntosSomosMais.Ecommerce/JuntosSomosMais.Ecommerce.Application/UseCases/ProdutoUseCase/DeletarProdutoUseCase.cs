using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class DeletarProdutoUseCase : IUseCaseAsync<int, IActionResult>
    {
        public readonly IProdutoRepository _repository;
        public DeletarProdutoUseCase(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> ExecuteAsync(int id)
        {          
            var produto = _repository.Excluir(id);

            if (produto == null)
                return new NotFoundObjectResult("Produto não encontrado!");

            return new OkObjectResult("Produto Deletado!");
        }
    }
}
