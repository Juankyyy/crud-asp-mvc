using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}