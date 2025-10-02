using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosVenda.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDesafioMicroservicosVenda.Models
{
    [Table("pedido")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }
        [Column("idproduto")]
        public long IdProduto { get; set; }

        [Column("estatuspedido")]
        public EstatusPedido EstatusPedido { get; set; }

        [Column("quantidadeproduto")]
        public int QuantidadeProduto { get; set; }

        [Column("produto")]
        public Produto Produto;

        public Pedido(long id, long idproduto, Produto produto, int quantidadeproduto, EstatusPedido estatusPedido)
        {
            Id=id;
            IdProduto=idproduto; 
            QuantidadeProduto=quantidadeproduto;
            EstatusPedido=estatusPedido;
            Produto=produto; 
        }
        public Pedido()
        {

        }
    }
    
}
