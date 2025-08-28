using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;

namespace WebApplication1.Repositories
{
    public class BebidaRepository : IBebidaRepository
    {
        private readonly AppDbContext _context;
        public BebidaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Bebida> Bebidas => _context.Bebidas.Include(c => c.Categoria);

        public IEnumerable<Bebida> BebidasPreferidas => _context.Bebidas.
            Where(l => l.IsBebidaPreferida)
            .Include(c => c.Categoria);

        public Bebida GetBebidaById(int bebidaId)
        {
            return _context.Bebidas.FirstOrDefault(l => l.BebidaId == bebidaId);
        }
    }
}
