using Microsoft.AspNetCore.Mvc;

namespace ShopProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
