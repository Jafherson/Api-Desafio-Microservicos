
using ApiDesafioMicroservicos.Infraestrutura;
using ApiDesafioMicroservicosProduto.Interfaces.Repositories;
using ApiDesafioMicroservicosProduto.Interfaces.Services;
using ApiDesafioMicroservicosProduto.Services;

namespace ApiDesafioMicroservicos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add services to the container.
            builder.Services.AddTransient<IProdutoService, ProdutoServices>();
            builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();

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
