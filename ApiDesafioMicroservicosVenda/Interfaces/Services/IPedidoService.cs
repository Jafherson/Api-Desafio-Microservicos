using ApiDesafioMicroservicosVenda.Models;
using ApiDesafioMicroservicosVenda.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesafioMicroservicosVenda.Interfaces.Services
{
    public interface IPedidoService
    {
         List<Pedido> ListarPedidos();
         bool Add(PedidoViewModelCadastro pedidoViewModel);
         List<Pedido> ListarPedidoEstatus(long Id);
        

    }
}
