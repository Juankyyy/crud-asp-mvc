using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}