using Microsoft.EntityFrameworkCore;
using System.Xml.XPath;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Services
{
    public class RelatorioVendasService
    {
        private readonly AppDbContext context;

        public RelatorioVendasService(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {

            var resultado = from obj in context.Pedidos select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado <= maxDate.Value);
            }

            return await resultado
                         .Include(l => l.PedidoItens)
                         .ThenInclude(a => a.Bebida)
                         .OrderByDescending(c => c.PedidoEnviado)
                         .ToListAsync();
        }
    }
}
