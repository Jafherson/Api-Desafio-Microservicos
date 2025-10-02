
using ApiDesafioMicroservicos.Infraestrutura;
using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosProduto.Interfaces.Repositories;
using ApiDesafioMicroservicosProduto.Interfaces.Services;
using ApiDesafioMicroservicosProduto.Services;
using ApiDesafioMicroservicosVenda.Infraestrutura;
using ApiDesafioMicroservicosVenda.Interfaces.Repositories;
using ApiDesafioMicroservicosVenda.Interfaces.Services;
using ApiDesafioMicroservicosVenda.Services;

namespace ApiDesafioMicroservicosVenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
            builder.Services.AddTransient<IPedidoService, PedidoServices>();
            builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
            builder.Services.AddTransient<IProdutoService, ProdutoServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
