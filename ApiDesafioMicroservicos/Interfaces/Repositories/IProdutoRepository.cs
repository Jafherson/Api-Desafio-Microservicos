using ApiDesafioMicroservicos.Models;

namespace ApiDesafioMicroservicosProduto.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();

        Produto? GetById(long id);

        void Add(Produto produto);
             
        void Update(Produto produto);
    }  
}
