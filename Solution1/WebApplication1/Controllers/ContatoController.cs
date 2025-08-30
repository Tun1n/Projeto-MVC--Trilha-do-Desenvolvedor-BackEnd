using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
