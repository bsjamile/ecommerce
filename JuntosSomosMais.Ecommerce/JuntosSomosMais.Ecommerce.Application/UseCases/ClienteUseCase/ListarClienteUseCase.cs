using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ClienteUseCase
{
    public class ListarClienteUseCase : IUseCaseOneAsync<List<ListarClienteResponse>>
    {
        public readonly IClienteRepository _clienteRepository; 
        public readonly IMapper _mapper;
        public ListarClienteUseCase(IClienteRepository clienteRepository,
            IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public async Task<List<ListarClienteResponse>> ExecuteAsync()
        {
            var clientes = await _clienteRepository.Listar();
            var clientesResponse = _mapper.Map<List<ListarClienteResponse>>(clientes);

            return clientesResponse;

        }
    }
}
