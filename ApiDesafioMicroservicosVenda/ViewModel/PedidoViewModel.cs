using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosVenda.Enums;

namespace ApiDesafioMicroservicosVenda.ViewModel
{
    public class PedidoViewModel
    {
        public long Id { get; set; } 
        public long  IdProduto { get; set; } 
        EstatusPedido estatusPedido { get; set; } 
        public int quantidadeProduto { get ; set; } 
        
    }
}
