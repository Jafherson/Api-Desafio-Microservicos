using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosVenda.Enums;
using System.ComponentModel.DataAnnotations;

namespace ApiDesafioMicroservicosVenda.ViewModel
{
    public class PedidoViewModelCadastro
    {

        [Required] 
        public long Id { get; set; } 
        [Required]
        public long  IdProduto { get; set; }
        [Required]
        public  EstatusPedido estatus { get; set; } 
        [Required] 
        public int quantidadeProduto { get; set; }
        [Required]
        public Produto produto;
       
    }
}
