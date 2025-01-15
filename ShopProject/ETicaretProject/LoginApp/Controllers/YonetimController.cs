using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class YonetimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
