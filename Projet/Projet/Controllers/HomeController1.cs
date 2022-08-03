using Microsoft.AspNetCore.Mvc;

namespace Projet.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
