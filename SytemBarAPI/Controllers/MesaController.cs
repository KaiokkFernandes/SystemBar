using Microsoft.AspNetCore.Mvc;

namespace SytemBarAPI.Controllers
{
    public class MesaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
