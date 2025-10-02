using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosVenda.Models;
using Microsoft.EntityFrameworkCore;


namespace ApiDesafioMicroservicos.Infraestrutura
{
    public class ConnectionContext : DbContext
    { 
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; } 


        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost;"+"Port=5432;Database=DesafioMicroServicos;"
            +"User Id=postgres;"+"Password=1234;");    }
}
