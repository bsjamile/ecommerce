using AutoMapper;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.AtualizarProdutoRequest;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;

namespace JuntosSomosMais.Ecommerce.Application.Mappings
{
    public class MappingProfile : Profile
    {
        /*
         * Possibilita o mapeameanto das informações presentes em cada classe
         * O que é muito útil para evitar a repetição de código
         * Quando os nomes dos atributos presentes em cada classe são identicos, 
         * o mapper já subentende que é para correlacionar essas informações
        */

        public MappingProfile() 
        {
            CreateMap<Endereco, ListarClienteEnderecoResponse>()
                .ForMember(dest => dest.IdEndereco, fonte => fonte.MapFrom(src => src.Id));

            CreateMap<Cliente, ListarClienteResponse>()
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.Id));

            CreateMap<CadastrarClienteEnderecoRequest, Endereco>();

            CreateMap<CadastrarClienteRequest, Cliente>();

            CreateMap<Cliente, ConsultarPedidoPorIdClienteResponse>();

            CreateMap<PedidoProduto, ConsultarPedidoPorIdProdutoResponse>()
                .ForMember(dest => dest.Produto, fonte => fonte.MapFrom(src => src.Produto.Nome))
                .ForMember(dest => dest.PrecoUnitario, fonte => fonte.MapFrom(src => src.Produto.Preco));

            CreateMap<Pedido, ConsultarPedidoPorIdResponse>()
                .ForMember(dest => dest.Produtos, fonte => fonte.MapFrom(src => src.PedidoProdutos));

            CreateMap<CadastrarPedidoProdutoRequest, PedidoProduto>()
                .ForMember(dest => dest.IdProduto, fonte => fonte.MapFrom(src => src.IdProduto));

            CreateMap<Pedido, CadastrarPedidoRequest>();

            CreateMap<Produto, ConsultarProdutoPorIdResponse>()
                .ForMember(dest => dest.IdProduto, fonte => fonte.MapFrom(src => src.Id));

            CreateMap<GetFilterProduto, Produto>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Produto));

            CreateMap<CadastrarProdutoRequest, Produto>();

            CreateMap<AtualizarProdutoRequest, Produto>()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.IdProduto));
        }
    }
}
