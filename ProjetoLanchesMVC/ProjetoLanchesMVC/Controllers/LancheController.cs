using Microsoft.AspNetCore.Mvc;
using ProjetoLanchesMVC.Repositories.Interfaces;

namespace ProjetoLanchesMVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {

            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            return View(lanches);
        }
    }
}
