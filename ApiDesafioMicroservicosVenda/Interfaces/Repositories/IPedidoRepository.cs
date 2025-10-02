using ApiDesafioMicroservicosVenda.Models;
using ApiDesafioMicroservicosVenda.ViewModel;

namespace ApiDesafioMicroservicosVenda.Interfaces.Repositories
{
    public interface IPedidoRepository
    {
        List<Pedido> ListarPedidoEstatus(long Id);
        List<Pedido> ListarPedido();
        void Add(Pedido pedido);


    }
}

