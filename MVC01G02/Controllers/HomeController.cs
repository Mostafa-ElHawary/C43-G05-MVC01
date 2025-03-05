using Microsoft.AspNetCore.Mvc;

namespace MVC01G02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from HomeController!");
        }

        public IActionResult SignIn(string username)
        {
            return Content($"Hello {username}, you are signed in!");
        }
    }
}
