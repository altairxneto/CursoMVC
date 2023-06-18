using Microsoft.AspNetCore.Mvc;
using ProjetoLanchesMVC.Repositories.Interfaces;
using ProjetoLanchesMVC.ViewModels;

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

            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheListViewModel);
        }
    }
}
