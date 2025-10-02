using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDesafioMicroservicos.Models
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("preco")]
        public double Preco { get; set; }

        [Column("quantidade")]
        public long Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(long id, string nome, string descricao, double preco, int quantidade)
        {
            Id=id;
            Nome=nome;
            Descricao=descricao;
            Preco=preco;
            Quantidade=quantidade;
        }
        
    }
}
