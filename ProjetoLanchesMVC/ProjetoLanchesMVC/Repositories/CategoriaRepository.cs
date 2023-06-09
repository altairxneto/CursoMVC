using ProjetoLanchesMVC.Context;
using ProjetoLanchesMVC.Models;
using ProjetoLanchesMVC.Repositories.Interfaces;

namespace ProjetoLanchesMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categoria;
    }
}
