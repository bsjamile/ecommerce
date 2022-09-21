using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.AtualizarProdutoRequest;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase
{
    public class AtualizarProdutoUseCase : IUseCaseAsync<AtualizarProdutoRequest, IActionResult>
    {
        public readonly IProdutoRepository _repository;
        public readonly IMapper _mapper;
        public AtualizarProdutoUseCase(IProdutoRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(AtualizarProdutoRequest request)
        {
            if (request == null)
                return null;

            var produto = _mapper.Map<Produto>(request);

            await _repository.Atualizar(produto);

            return new OkObjectResult("Produto atualizado!");
        }
    }
}
