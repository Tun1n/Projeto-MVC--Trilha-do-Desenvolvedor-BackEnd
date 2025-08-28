using WebApplication1.Models;

namespace WebApplication1.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> categorias { get; }
    }
}
