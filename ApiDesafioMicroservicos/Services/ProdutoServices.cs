using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicos.ViewModel;
using ApiDesafioMicroservicosProduto.Exceptions;
using ApiDesafioMicroservicosProduto.Interfaces.Repositories;
using ApiDesafioMicroservicosProduto.Interfaces.Services;

namespace ApiDesafioMicroservicosProduto.Services
{
    public class ProdutoServices : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoServices(IProdutoRepository produtoRepository)
        {
            _produtoRepository=produtoRepository;
        }

        public bool Add(ProdutoViewModelCadastro produtoViewModel)
        {
            if (string.IsNullOrEmpty(produtoViewModel.nome))
            {
                throw new RequisicaoInvalidaException("Nome do produto não informado");
            }

            if (produtoViewModel.quantidade <= 0)
            {
                throw new RequisicaoInvalidaException("Quantidade do produto não pode" +
                    " ser menor ou igual a zero");
            }

            if (produtoViewModel.preco <= 0)
            {
                throw new RequisicaoInvalidaException("Preço do produto não pode" +
                    " ser menor ou igual a zero");
            }

            if (string.IsNullOrEmpty(produtoViewModel.descricao))
            {
                throw new RequisicaoInvalidaException("Descrição do produto não informada");
            }

            _produtoRepository.Add(CriarProduto(produtoViewModel));
            return true;
        }

        private Produto CriarProduto(ProdutoViewModelCadastro viewModel)
        {
            return new Produto
            {
                Nome = viewModel.nome,
                Preco = viewModel.preco,
                Descricao = viewModel.descricao,
                Quantidade = viewModel.quantidade,
            };
        }

        public List<Produto> ListarProdutos()
        {
            return _produtoRepository.GetAll();
        }

        public long SubtrairQuantidadeProduto(long id, int quantidade)
        {
            if (quantidade == 0)
                throw new RequisicaoInvalidaException("A quantidade deve ser maior que zero");

            var produto = _produtoRepository.GetById(id);
            if (produto == null)
                throw new RequisicaoInvalidaException("Produto não encontrado");

            if (produto.Quantidade < quantidade)
                throw new RequisicaoInvalidaException ("Quantidade insuficiente em estoque");

            produto.Quantidade -= quantidade;
            _produtoRepository.Update(produto);

            return produto.Quantidade;
        }
     
    }
}
    

