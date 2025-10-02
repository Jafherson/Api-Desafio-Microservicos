using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicos.ViewModel;

namespace ApiDesafioMicroservicosProduto.Interfaces.Services
{
    public interface IProdutoService
    {
        bool Add(ProdutoViewModelCadastro produtoViewModel);

        List<Produto> ListarProdutos();

        long SubtrairQuantidadeProduto(long nome,int quantidade); 
    }
}
