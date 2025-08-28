using WebApplication1.Models;

namespace WebApplication1.Repositories.Interfaces
{
    public interface IBebidaRepository
    {
        IEnumerable<Bebida> Bebidas { get; }
        IEnumerable<Bebida> BebidasPreferidas { get; }
        Bebida GetBebidaById(int bebidaId);
    }
}
