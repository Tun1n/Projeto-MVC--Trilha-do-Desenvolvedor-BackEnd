using Microsoft.AspNetCore.Mvc;
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

        public IActionResult List()
        {
            var bebidasListViewModel = new BebidaListViewModel();
            bebidasListViewModel.Bebidas = _bebidaRepository.Bebidas;
            bebidasListViewModel.CategoriaAtual = "Categoria Atual";

            return View(bebidasListViewModel);

        }
    }
}
