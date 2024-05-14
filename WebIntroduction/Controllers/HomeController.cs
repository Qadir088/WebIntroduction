using Microsoft.AspNetCore.Mvc;

namespace WebIntroduction.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
