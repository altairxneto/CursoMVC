using Microsoft.AspNetCore.Mvc;

namespace ProjetoLanchesMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
