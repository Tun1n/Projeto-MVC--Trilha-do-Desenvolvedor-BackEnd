using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

namespace WebApplication1.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;
        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }
        public string CarrinhoCompraId { get; set; }

        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }   

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            
            ISession session = 
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            
            var context = services.GetService<AppDbContext>();

            
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            
            session.SetString("CarrinhoId", carrinhoId);

            
            return new CarrinhoCompra(context) { CarrinhoCompraId = carrinhoId };
        }

        public void AdicionarAoCarrinho(Bebida bebida)
        {
            
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                s => s.Bebida.BebidaId == bebida.BebidaId && 
                s.CarrinhoCompraId == CarrinhoCompraId);

            if (carrinhoCompraItem == null)
            {
                
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Bebida = bebida,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                
                carrinhoCompraItem.Quantidade++;
            }
            
            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Bebida bebida)
        {
            
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                s => s.Bebida.BebidaId == bebida.BebidaId && 
                s.CarrinhoCompraId == CarrinhoCompraId);

            var quantidadeLocal = 0;

            if (carrinhoCompraItem != null)
            {
                if (carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
                }
                
                _context.SaveChanges();
            }

            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItems ??
                   (CarrinhoCompraItems = _context.CarrinhoCompraItens
                       .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                       .Include(s => s.Bebida)
                       .ToList());
        }

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoCompraItens
                .Where(c => c.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItens.RemoveRange(carrinhoItens);

            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoCompraItens
                .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                .Select(c => c.Bebida.Preco * c.Quantidade).Sum();
            return total;
        }

    }
}
