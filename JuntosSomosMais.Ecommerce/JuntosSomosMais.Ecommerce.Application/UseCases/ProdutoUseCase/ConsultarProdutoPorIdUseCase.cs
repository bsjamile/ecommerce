using System;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using System.Threading.Tasks;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using AutoMapper;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class ConsultarProdutoPorIdUseCase : IUseCaseAsync<int, ConsultarProdutoPorIdResponse>
    {
        public readonly IProdutoRepository _produtoRepository;
        public readonly IMapper _mapper;
        public ConsultarProdutoPorIdUseCase(IProdutoRepository produtoRepository,
            IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public Task<ConsultarProdutoPorIdResponse> ExecuteAsync(int request)
        {
            var resposta = _produtoRepository.ConsultarPorId(request).Result;

            var response = (ConsultarProdutoPorIdResponse)null;

            if (resposta != null)
            {
                response = _mapper.Map<ConsultarProdutoPorIdResponse>(resposta);
            }

            return Task.FromResult(response);
        }
    }
}
