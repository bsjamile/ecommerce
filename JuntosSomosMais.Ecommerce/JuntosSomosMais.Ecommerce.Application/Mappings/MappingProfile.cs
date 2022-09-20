using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;

namespace JuntosSomosMais.Ecommerce.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Endereco, ListarClienteEnderecoResponse>()
                .ForMember(dest => dest.IdEndereco, fonte => fonte.MapFrom(src => src.Id));

            CreateMap<Cliente, ListarClienteResponse>()
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.DataNasc, fonte => fonte.MapFrom(src => src.DataNasc))
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Senha, fonte => fonte.MapFrom(src => src.Senha))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            CreateMap<CadastrarClienteEnderecoRequest, Endereco>();

            CreateMap<CadastrarClienteRequest, Cliente>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.DataNasc, fonte => fonte.MapFrom(src => src.DataNasc))
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Senha, fonte => fonte.MapFrom(src => src.Senha))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            CreateMap<Cliente, ConsultarPedidoPorIdClienteResponse>();

            CreateMap<PedidoProduto, ConsultarPedidoPorIdProdutoResponse>()
                .ForMember(dest => dest.Produto, fonte => fonte.MapFrom(src => src.Produto.Nome))
                .ForMember(dest => dest.Quantidade, fonte => fonte.MapFrom(src => src.Quantidade))
                .ForMember(dest => dest.PrecoUnitario, fonte => fonte.MapFrom(src => src.Produto.Preco));

            CreateMap<Pedido, ConsultarPedidoPorIdResponse>()
                .ForMember(dest => dest.DataPedido, fonte => fonte.MapFrom(src => src.DataPedido))
                .ForMember(dest => dest.Cliente, fonte => fonte.MapFrom(src => src.Cliente))
                .ForMember(dest => dest.Produtos, fonte => fonte.MapFrom(src => src.PedidoProdutos));

            CreateMap<CadastrarPedidoProdutoRequest, PedidoProduto>()
                .ForMember(dest => dest.IdProduto, fonte => fonte.MapFrom(src => src.IdProduto))
                .ForMember(dest => dest.Quantidade, fonte => fonte.MapFrom(src => src.Quantidade));

            CreateMap<Pedido, CadastrarPedidoRequest>()
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.IdCliente));

            CreateMap<Produto, ConsultarProdutoPorIdResponse>()
                .ForMember(dest => dest.IdProduto, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Preco, fonte => fonte.MapFrom(src => src.Preco));

            CreateMap<GetFilterProduto, Produto>()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Produto));

            CreateMap<CadastrarProdutoRequest, Produto>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Preco, fonte => fonte.MapFrom(src => src.Preco));
        }
    }
}
