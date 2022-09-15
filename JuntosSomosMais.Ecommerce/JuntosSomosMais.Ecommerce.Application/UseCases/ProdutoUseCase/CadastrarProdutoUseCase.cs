using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class CadastrarProdutoUseCase : IUseCaseAsync<CadastrarProdutoRequest, CadastrarProdutoResponse>
    {
        public readonly IProdutoRepository _produtoRepository;
        public readonly IMapper _mapper;

        public CadastrarProdutoUseCase(IProdutoRepository produtoRepository,
                                       IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public async Task<CadastrarProdutoResponse> ExecuteAsync(CadastrarProdutoRequest request)
        {
            if (request == null)
                return null;

            var produto = _mapper.Map<Produto>(request);

            await _produtoRepository.Cadastrar(produto);

            return new CadastrarProdutoResponse();
        }
    }
}
