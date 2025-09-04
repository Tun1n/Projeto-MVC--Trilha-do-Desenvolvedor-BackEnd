
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminBebidasController : Controller
    {
        private readonly AppDbContext _context;

        public AdminBebidasController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Bebidas.Include(l => l.Categoria);
            return View(await appDbContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bebida = await _context.Bebidas
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.BebidaId == id);
            if (bebida == null)
            {
                return NotFound();
            }

            return View(bebida);
        }

        
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BebidaId,Name,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsBebidaPreferida,EmEstoque,CategoriaId")] Bebida bebida )
        {
            if (ModelState.IsValid)
            {
                _context.Add(bebida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", bebida.CategoriaId);
            return View(bebida);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bebida = await _context.Bebidas.FindAsync(id);
            if (bebida == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", bebida.CategoriaId);
            return View(bebida);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BebidaId,Name,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsBebidaPreferida,EmEstoque,CategoriaId")] Bebida bebida)
        {
            if (id != bebida.BebidaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bebida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BebidaExists(bebida.BebidaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", bebida.CategoriaId);
            return View(bebida);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bebida = await _context.Bebidas
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.BebidaId == id);
            if (bebida == null)
            {
                return NotFound();
            }

            return View(bebida);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bebida = await _context.Bebidas.FindAsync(id);
            _context.Bebidas.Remove(bebida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BebidaExists(int id)
        {
            return _context.Bebidas.Any(e => e.BebidaId == id);
        }
    }
}
