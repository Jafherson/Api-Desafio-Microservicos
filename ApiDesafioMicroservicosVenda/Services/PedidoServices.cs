using ApiDesafioMicroservicosProduto.Exceptions;
using ApiDesafioMicroservicosProduto.Interfaces.Repositories;
using ApiDesafioMicroservicosProduto.Interfaces.Services;
using ApiDesafioMicroservicosVenda.DTOs;
using ApiDesafioMicroservicosVenda.Enums;
using ApiDesafioMicroservicosVenda.Interfaces.Repositories;
using ApiDesafioMicroservicosVenda.Interfaces.Services;
using ApiDesafioMicroservicosVenda.Models;
using ApiDesafioMicroservicosVenda.ViewModel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ApiDesafioMicroservicosVenda.Services
{
    public class PedidoServices : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public PedidoServices(IPedidoRepository pedidoRepository, IProdutoRepository produtoRepository)
        {
            _pedidoRepository=pedidoRepository;
            _produtoRepository=produtoRepository;
        }

        private Pedido CriarPedido(PedidoViewModelCadastro pedidoViewModel)
        {
            return new Pedido

            {

                Produto = _produtoRepository.GetById(pedidoViewModel.IdProduto),
                IdProduto = pedidoViewModel.IdProduto, 
                QuantidadeProduto=pedidoViewModel.quantidadeProduto,
                EstatusPedido= EstatusPedido.Criado,
             


            };
                  
        }
        public bool Add(PedidoViewModelCadastro pedidoViewModel)
        {
            var produto = _produtoRepository.GetById(pedidoViewModel.IdProduto);

            if (produto == null) {
                throw new RequisicaoInvalidaException("Produto não encontrado");
            }


            if (pedidoViewModel.quantidadeProduto <= 0)
            {
                throw new RequisicaoInvalidaException("A Quantidade do produto deve ser maior que zero");
            }
                    

           _pedidoRepository.Add(CriarPedido(pedidoViewModel));
           return true; 
        }
        

        public List<Pedido> ListarPedidos()

        {
            return _pedidoRepository.ListarPedido();

        }
        public List<Pedido> ListarPedidoEstatus(long Id)
        {
            var pedido = _pedidoRepository.ListarPedido().Where(p => p.Id == Id).ToList(); 
           
            return pedido;
        }

     }
}
