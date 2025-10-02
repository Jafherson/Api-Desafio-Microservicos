
using ApiDesafioMicroservicos.Models;
using ApiDesafioMicroservicosProduto.Exceptions;
using ApiDesafioMicroservicosVenda.DTOs;
using ApiDesafioMicroservicosVenda.Enums;
using ApiDesafioMicroservicosVenda.Interfaces.Repositories;
using ApiDesafioMicroservicosVenda.Interfaces.Services;
using ApiDesafioMicroservicosVenda.Models;
using ApiDesafioMicroservicosVenda.Services;
using ApiDesafioMicroservicosVenda.ViewModel;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using System.Collections.Immutable;

namespace ApiDesafioMicroservicosVenda.Controllers
{
    [Route("api/v1/Pedidos")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService=pedidoService;
        }

        [HttpPost]
        public IActionResult Add(PedidoViewModelCadastro pedidoViewModel)
        {
             _pedidoService.Add(pedidoViewModel);
            return Ok("Pedido criada com sucesso");
        }

        [HttpGet("Lista")]
        public IActionResult ListarPedidos()
        {
            var pedidos = _pedidoService.ListarPedidos(); 

            return Ok(pedidos);

        }
        [HttpGet("estatus")]
        public IActionResult ListarPedidoEstatus(long Id)
        {
            var pedido = _pedidoService.ListarPedidoEstatus(Id).Select(p => new PedidoEstatusDto
            {
                Id = p.Id, 
                EstatusPedido = p.EstatusPedido.GetDisplayName(),
            });
           
                
            
           
            return Ok(pedido) ;  
                          
        }

            
    }
}
