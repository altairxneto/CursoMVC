using ProjetoLanchesMVC.Models;

namespace ProjetoLanchesMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
