using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories.Interfaces;

namespace WebApplication1.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.categorias.OrderBy(c => c.CategoriaName);
            return View(categorias);

            
        }   
    }
}
