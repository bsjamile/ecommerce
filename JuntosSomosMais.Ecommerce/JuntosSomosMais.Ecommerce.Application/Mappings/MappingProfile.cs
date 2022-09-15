using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;

namespace JuntosSomosMais.Ecommerce.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ListarClienteResponse>()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.DataNasc, fonte => fonte.MapFrom(src => src.DataNasc))                
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Senha, fonte => fonte.MapFrom(src => src.Senha))
                .ForMember(dest => dest.Enderecos, fonte => fonte.MapFrom(src => src.Enderecos));

            CreateMap<GetFilterPorId, Pedido> ()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id));

            CreateMap<Pedido, ConsultarPedidoPorIdResponse>()
                .ForMember(dest => dest.DataPedido, fonte => fonte.MapFrom(src => src.DataPedido));

            CreateMap<GetFilterProduto, Produto>()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Produto));

            CreateMap<Produto, ConsultarProdutoPorIdResponse>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Preco, fonte => fonte.MapFrom(src => src.Preco));
        }
    }
}
