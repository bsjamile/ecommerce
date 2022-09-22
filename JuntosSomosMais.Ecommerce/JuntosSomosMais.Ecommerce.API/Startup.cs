using JuntosSomosMais.Ecommerce.Application.Mappings;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.AtualizarProdutoRequest;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.CadastrarProduto;
using JuntosSomosMais.Ecommerce.Application.Models.Produto.ConsultarProdutoPorId;
using JuntosSomosMais.Ecommerce.Application.UseCases;
using JuntosSomosMais.Ecommerce.Application.UseCases.ClienteUseCase;
using JuntosSomosMais.Ecommerce.Application.UseCases.PedidoUseCase;
using JuntosSomosMais.Ecommerce.Application.UseCases.ProdutoUseCase;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using JuntosSomosMais.Ecommerce.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace JuntosSomosMais.Ecommerce.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            /*
           Injeção de dependencia para tornar as classes independentes das classes que normalmente dependeria
           Desacopla as classes, o que as tornam independentes uma da outra
           O que facilita na organizacao e manutencao do codigo
           */

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();           

            services.AddScoped<IUseCaseOneAsync<List<ListarClienteResponse>>, ListarClienteUseCase>();
            services.AddScoped<IUseCaseAsync<CadastrarClienteRequest, IActionResult>, CadastrarClienteUseCase>();

            services.AddScoped<IUseCaseAsync<int, ConsultarPedidoPorIdResponse>, ConsultarPedidoPorIdUseCase>();
            services.AddScoped<IUseCaseAsync<CadastrarPedidoRequest, IActionResult>, CadastrarPedidoUseCase>();
            
            services.AddScoped<IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse>, ConsultarProdutoPorIdUseCase>();
            services.AddScoped<IUseCaseAsync<CadastrarProdutoRequest, IActionResult>, CadastrarProdutoUseCase>();
            services.AddScoped<IUseCaseAsync<AtualizarProdutoRequest, IActionResult>, AtualizarProdutoUseCase>();
            services.AddScoped<IUseCaseOneAsync<List<ConsultarProdutoPorIdResponse>>, ListarProdutoUseCase>();
            services.AddScoped<IUseCaseAsync<int, IActionResult>, DeletarProdutoUseCase>();

            services.AddAutoMapper(typeof(MappingProfile)); //permite o mapeamento das informacoes presentes nas diferentes classes

            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")) //onde esta o caminho do banco de dados
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
             );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JuntosSomosMais.Ecommerce.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context) //Configurando o ApplicationContext context, informa onde esta as informacoes sobre o banco de dados
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JuntosSomosMais.Ecommerce.API v1"));
            }

            context.Database.Migrate();
            //Permite a criacao do banco de dados, as tabelas e insere os dados automaticamente quando a aplicacao for rodada

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
