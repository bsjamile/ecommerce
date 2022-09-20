using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using System.Threading.Tasks;

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
            var pedido = _pedidoRepository.ConsultarPorId(id).Result;

            var response = (ConsultarPedidoPorIdResponse)null;

            if (pedido != null)
            {
                response = _mapper.Map<ConsultarPedidoPorIdResponse>(pedido);
            }

            return Task.FromResult(response);
        }
    }
}
