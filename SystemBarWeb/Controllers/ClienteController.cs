using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using SystemBarWeb.Models;

namespace SystemBarWeb.Controllers
{
    public class ClienteController : Controller
    {
        [Route("/cliente/novo")]
        public IActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        [Route("/cliente/novo{regex:(^\\d{3}.d{3}.d{3}-d{3})$}")]
        public IActionResult Cadastrar([FromForm]Cliente cliente)
        {

            return View();
        }

        [Route("/cliente/buscar/{cpf}")]
        public IActionResult Cadastrar( Int64 cpf)
        {

            return View();
        }
    }
}
