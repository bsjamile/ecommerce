using JuntosSomosMais.Ecommerce.Application.Mappings;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.CadastrarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Cliente.ListarCliente;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.CadastrarPedido;
using JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId;
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
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            //Injeção de dependencia para tornar as classes independentes das classes que normalmente dependeria
            //Desacopla as classes, o que as tornam independentes uma da outra

            services.AddScoped<IUseCaseAsync<ListarClienteRequest, List<ListarClienteResponse>>, ListarClienteUseCase>();
            services.AddScoped<IUseCaseAsync<CadastrarClienteRequest, CadastrarClienteResponse>, CadastrarClienteUseCase>();

            services.AddScoped<IUseCaseAsync<GetFilterPorId, ConsultarPedidoPorIdResponse>, ConsultarPedidoPorIdUseCase>();
            services.AddScoped<IUseCaseAsync<CadastrarPedidoRequest, CadastrarPedidoResponse>, CadastrarPedidoUseCase>();

            services.AddScoped<IUseCaseAsync<GetFilterProduto, ConsultarProdutoPorIdResponse>, ConsultarProdutoPorIdUseCase>();
            services.AddScoped<IUseCaseAsync<CadastrarProdutoRequest, CadastrarProdutoResponse>, CadastrarProdutoUseCase>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
             );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JuntosSomosMais.Ecommerce.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JuntosSomosMais.Ecommerce.API v1"));
            }

            //context.Database.Migrate();

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
