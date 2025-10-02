using ApiDesafioMicroservicos.ViewModel;
using ApiDesafioMicroservicosProduto.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesafioMicroservicos.Controllers
{
    [ApiController]
    [Route("Api/v1/Produto")]
    public class ProdutoController : ControllerBase
    {   
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
           _produtoService = produtoService; 
        }

        [HttpPost("Cadastrar")]
        public IActionResult Add(ProdutoViewModelCadastro produtoViewModel)
        {
            _produtoService.Add(produtoViewModel);
            return Ok("Produto criado");
        }

        [HttpGet("Listar")]
        public IActionResult Get()
        {
            return Ok(_produtoService.ListarProdutos());
        }

        [HttpPatch("Atualizar/Quantidade")]
        public IActionResult SubtrairQuantidade(long idProduto, int quantidade)
        {
            var novaQuantidade = _produtoService.SubtrairQuantidadeProduto(idProduto , quantidade);
            return Ok("A nova quantidade do produto " + idProduto + " é " + novaQuantidade);    
        }
    }

}


