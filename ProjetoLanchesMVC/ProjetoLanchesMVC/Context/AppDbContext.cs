using Microsoft.EntityFrameworkCore;
using ProjetoLanchesMVC.Models;

namespace ProjetoLanchesMVC.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Lanche> Lanche { get; set; }

    }
}
