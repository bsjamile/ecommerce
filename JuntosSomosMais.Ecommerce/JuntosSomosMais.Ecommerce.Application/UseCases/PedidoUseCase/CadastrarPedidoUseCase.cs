using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;

namespace JuntosSomosMais.Ecommerce.Application.UseCases.PedidoUseCase
{
    public class CadastrarPedidoUseCase : IUseCaseAsync<CadastrarPedidoRequest, CadastrarPedidoResponse>
    {        
        public readonly IPedidoRepository _pedidoRepository;
        public readonly IMapper _mapper;

        public CadastrarPedidoUseCase(IPedidoRepository pedidoRepository,
                                       IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }
        public async Task<CadastrarPedidoResponse> ExecuteAsync(CadastrarPedidoRequest request)
        {
            if (request == null)
                return null;

            //var pedido = _mapper.Map<Pedido>(request);

            var pedidoProdutos = new List<PedidoProduto>();

            foreach (var quantidade in request.Quantidade)             
                foreach (var produtoId in request.IdProdutos)
                    pedidoProdutos.Add(new PedidoProduto(produtoId, quantidade));

            var pedido = new Pedido(DateTime.Now, request.IdCliente, pedidoProdutos);

            await _pedidoRepository.Cadastrar(pedido);

            return new CadastrarPedidoResponse();
        }
    }
}

