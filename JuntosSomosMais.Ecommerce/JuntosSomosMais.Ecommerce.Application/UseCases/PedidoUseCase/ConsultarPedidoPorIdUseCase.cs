using System;
using System.Threading.Tasks;
using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.PedidoUseCase
{
    public class ConsultarPedidoPorIdUseCase : IUseCaseAsync<int, ConsultarPedidoPorIdResponse>
    {
        public readonly IPedidoRepository _pedidoRepository;
        public readonly IMapper _mapper;
        public ConsultarPedidoPorIdUseCase(IPedidoRepository pedidoRepository,
            IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        public Task<ConsultarPedidoPorIdResponse> ExecuteAsync(int id)
        {
            var resposta = _pedidoRepository.ConsultarPorId(id).Result;

            var response = (ConsultarPedidoPorIdResponse)null;

            if (resposta != null)
            {
                response = _mapper.Map<ConsultarPedidoPorIdResponse>(resposta);
            }

            return Task.FromResult(response);
        }
    }
}
