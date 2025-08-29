using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class BebidaListViewModel
    {
        public IEnumerable<Bebida> Bebidas { get; set; }

        public string CategoriaAtual { get; set; }

        }
}
