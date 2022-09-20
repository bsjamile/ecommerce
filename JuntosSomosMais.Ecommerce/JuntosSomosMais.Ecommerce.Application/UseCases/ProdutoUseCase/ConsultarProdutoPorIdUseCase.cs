using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class ConsultarProdutoPorIdUseCase : IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse>
    {
        public readonly IProdutoRepository _produtoRepository;
        public readonly IMapper _mapper;
        public ConsultarProdutoPorIdUseCase(IProdutoRepository produtoRepository,
            IMapper mapper)
        {
            _produtoRepository = produtoRepository; //representacao do repositorio para chamar a task que deseja executar
            _mapper = mapper; //mapper para permitir o mapeamento das informacoes
        }

        public Task<ConsultarProdutoPorIdResponse> ExecuteAsync(GetFilterProduto filter)
        {
            var produto = _produtoRepository.ConsultarPorId(filter).Result;

            var response = (ConsultarProdutoPorIdResponse)null;

            if (produto != null)
            {
                response = _mapper.Map<ConsultarProdutoPorIdResponse>(produto);
            }

            return Task.FromResult(response);
        }
    }
}
