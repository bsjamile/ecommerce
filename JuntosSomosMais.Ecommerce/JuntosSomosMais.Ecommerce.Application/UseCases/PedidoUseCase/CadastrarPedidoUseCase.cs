using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.PedidoUseCase
{
    public class CadastrarPedidoUseCase : IUseCaseAsync<CadastrarPedidoRequest, IActionResult>
    {        
        public readonly IPedidoRepository _pedidoRepository; //representacao do repositorio para chamar a task que deseja executar

        public CadastrarPedidoUseCase(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public async Task<IActionResult> ExecuteAsync(CadastrarPedidoRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var pedidoProdutos = new List<PedidoProduto>();

            foreach (var produtos in request.Produtos)
                pedidoProdutos.Add(new PedidoProduto(produtos.IdProduto, produtos.Quantidade));

            var pedido = new Pedido(DateTime.Now, request.IdCliente, pedidoProdutos);

            await _pedidoRepository.Cadastrar(pedido);

            return new OkObjectResult("Pedido realizado!");
        }
    }
}

