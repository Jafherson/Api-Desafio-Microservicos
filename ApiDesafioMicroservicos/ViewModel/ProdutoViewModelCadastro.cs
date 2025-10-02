using System.ComponentModel.DataAnnotations;

namespace ApiDesafioMicroservicos.ViewModel
{
    public class ProdutoViewModelCadastro
    {
        [Required]
        public string nome { get; set; }
      
        [Required]
        public string descricao { get; set; }
       
        [Required]
        public double preco { get; set; }
        
        [Required]
        public int quantidade { get; set; }
    }
}
