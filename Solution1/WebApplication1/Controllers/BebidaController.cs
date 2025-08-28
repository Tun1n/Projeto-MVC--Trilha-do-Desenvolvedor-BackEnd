using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class BebidaController : Controller
    {
        private readonly BebidaRepository _bebidaRepository;

        public BebidaController(BebidaRepository bebidaRepository)
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
