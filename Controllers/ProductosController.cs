using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}