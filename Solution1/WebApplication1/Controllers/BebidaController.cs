using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Interfaces;

namespace WebApplication1.Controllers
{
    public class BebidaController : Controller
    {
        private readonly IBebidaRepository _bebidaRepository;

        public BebidaController(IBebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }

        public IActionResult List()
        {
            var bebidas = _bebidaRepository.Bebidas;
            return View(bebidas);
        }
    }
}
