using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IBebidaRepository _bebidaRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IBebidaRepository bebidaRepository, CarrinhoCompra carrinhoCompra)
        {
            _bebidaRepository = bebidaRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }

        public IActionResult AdicionarItemNoCarrinhoCompra(int bebidaId)
        {
            var bebidaSelecionada = _bebidaRepository.Bebidas.FirstOrDefault(j => j.BebidaId == bebidaId);
            if (bebidaSelecionada != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(bebidaSelecionada);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int bebidaId)
        {
            var bebidaSelecionada = _bebidaRepository.Bebidas.FirstOrDefault(m => m.BebidaId == bebidaId);
            if(bebidaSelecionada != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(bebidaSelecionada);
            }

            return RedirectToAction("Index");

        }
    }

}
