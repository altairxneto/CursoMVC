using ProjetoLanchesMVC.Models;

namespace ProjetoLanchesMVC.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
