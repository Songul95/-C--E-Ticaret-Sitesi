using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class KategorilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
