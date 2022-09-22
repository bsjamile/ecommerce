using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class ListarProdutoUseCase : IUseCaseOneAsync<List<ConsultarProdutoPorIdResponse>>
    {
        public readonly IProdutoRepository _produtoRepository;
        public readonly IMapper _mapper;
        public ListarProdutoUseCase(IProdutoRepository produtoRepository,
            IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public async Task<List<ConsultarProdutoPorIdResponse>> ExecuteAsync()
        {
            var produtos = await _produtoRepository.Listar();
            var produtoResponse = _mapper.Map<List<ConsultarProdutoPorIdResponse>>(produtos);

            return produtoResponse;

        }
    }
}
