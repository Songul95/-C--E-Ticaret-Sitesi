using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class UrünlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
