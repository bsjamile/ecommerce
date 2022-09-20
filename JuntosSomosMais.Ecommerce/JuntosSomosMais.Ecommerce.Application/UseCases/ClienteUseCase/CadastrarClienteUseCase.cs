using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ClienteUseCase
{
    public class CadastrarClienteUseCase : IUseCaseAsync<CadastrarClienteRequest, IActionResult>
    {
        public readonly IClienteRepository _clienteRepository;
        public readonly IMapper _mapper;

        public CadastrarClienteUseCase(IClienteRepository clienteRepository,
                                       IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> ExecuteAsync(CadastrarClienteRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var cliente = _mapper.Map<Cliente>(request);

            await _clienteRepository.Cadastrar(cliente);

            return new OkResult();
        }
    }
}
