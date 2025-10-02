using ApiDesafioMicroservicos.Infraestrutura;
using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosVenda.Interfaces.Repositories;
using ApiDesafioMicroservicosVenda.Models;

namespace ApiDesafioMicroservicosVenda.Infraestrutura
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Pedido pedido)
        {
            _context.Pedidos.Add(pedido); 
            _context.SaveChanges();
        }

        public List<Pedido> ListarPedido()
        {
            return _context.Pedidos.ToList();
        }

        public List<Pedido> ListarPedidoEstatus(long Id)
        {
            return _context.Pedidos.ToList();
        }
    }
        
}
