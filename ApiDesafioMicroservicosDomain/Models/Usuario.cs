using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesafioMicroservicosDomain.Models
{
    [Table("Usuario")]
    internal class Usuario
    {
        [Key]
        public int id { get; set; } 
        public string nome { get; set; } 

        public string senha { get ; set; }

        public Usuario(int id, string nome, string senha)
        {
            this.id=id;
            this.nome=nome;
            this.senha=senha;
        }
    }
}
