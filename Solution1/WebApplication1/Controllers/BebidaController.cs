using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class BebidaController : Controller
    {
        private readonly IBebidaRepository _bebidaRepository;

        public BebidaController(IBebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Bebida> bebidas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                bebidas = _bebidaRepository.Bebidas
                    .OrderBy(b => b.BebidaId);

                categoriaAtual = "Todas as bebidas";
            }
            else { 
                bebidas = _bebidaRepository.Bebidas
                    .Where(b => b.Categoria.CategoriaName.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(d => d.Name);

                categoriaAtual = categoria;
            }
            var bebidasListViewModel = new BebidaListViewModel
            {
                Bebidas = bebidas,
                CategoriaAtual = categoriaAtual
            };



            return View(bebidasListViewModel);

        }

        public IActionResult Details(int bebidaId)
        {
            var bebida = _bebidaRepository.Bebidas.FirstOrDefault(l => l.BebidaId == bebidaId) ;
            
            return View(bebida);
        }
    }
}
