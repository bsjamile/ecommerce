using System;
using System.Threading.Tasks;
using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ClienteUseCase
{
    public class CadastrarClienteUseCase : IUseCaseAsync<CadastrarClienteRequest, CadastrarClienteResponse>
    {
        public readonly IClienteRepository _clienteRepository;
        public readonly IMapper _mapper;

        public CadastrarClienteUseCase(IClienteRepository clienteRepository,
                                       IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public async Task<CadastrarClienteResponse> ExecuteAsync(CadastrarClienteRequest request)
        {
            if (request == null)
                return null;

            var cliente = _mapper.Map<Cliente>(request);

            await _clienteRepository.Cadastrar(cliente);

            return new CadastrarClienteResponse();
        }
    }
}
