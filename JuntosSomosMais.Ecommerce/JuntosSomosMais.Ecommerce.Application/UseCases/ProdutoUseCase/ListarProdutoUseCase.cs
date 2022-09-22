using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class ListarProdutoUseCase : IUseCaseOneAsync<List<ConsultarProdutoPorIdResponse>>
    {
        public readonly IProdutoRepository _produtoRepository; //representacao do repositorio para chamar a task que deseja executar
        public readonly IMapper _mapper; //mapper para permitir o mapeamento das informacoes
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
