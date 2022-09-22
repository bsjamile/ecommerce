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
        public readonly IClienteRepository _clienteRepository; //representacao do repositorio para chamar a task que deseja executar
        public readonly IMapper _mapper; //mapper para permitir o mapeamento das informacoes

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

            return new OkObjectResult("Cliente cadastrado!");
        }
    }
}
