using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SystemBarWeb.Models;

namespace SystemBarWeb.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("pedido")]
        public IActionResult GerarPedido()
        {

        }
        [HttpGet("produtos")]
        public IActionResult ConsultarPedido()
        {
            return PartialView("_listagem-produtos", new List<Produto>());
        }

        [HttpGet("pedido/{numeroPedido")]
        public IActionResult ConsultarPedido(Int64 numeroPedido) => StatusCode(200, new Pedido());


        [HttpPost("pedido/{numeroPedido}/item")]
        public IActionResult IncluirItemPedido(Int64 numeroPedido, [FromBody] ItemPedido itemPedido) => StatusCode(200, new Pedido());

        [HttpDelete("pedido/{numeroPedido}d/item`/{codigoItem}")]
        public IActionResult RemoverItemPedido(Int64 numeroPedido, Int64 codigoItem) => StatusCode(200, new Pedido());


        [HttpGet("pedido/{numeroPedido}/listar")]
        public IActionResult ListarItemPedido(Int64 numeroPedido, [FromBody] ItemPedido itemPedido) => StatusCode(200, new Pedido());

        [HttpPatch("pedido/{numeroPedido}d/item`/{codigoItem}/{quantidade}")]
        public IActionResult AlterarQuantidadeItemPedido(Int64 numeroPedido, Int64 codigoItem) => StatusCode(200, new Pedido());

        [HttpPatch("conta/{numeroPedido}")]
        public IActionResult FecharContaNumero(Int64 numeroPedido) => StatusCode(200, new Pedido());
    }
}
