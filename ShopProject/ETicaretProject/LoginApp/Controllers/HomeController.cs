using Layer.Business;
using Layer.Data;
using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (Request.Method == "POST")
            {
                TAdminIslemleri kullaniciIslemleri = new();
                string TxtSifre = Request.Form["TxtSifre"].ToString();
                string TxtKullaniciAdi = Request.Form["TxtKullaniciAdi"].ToString();
                string Message;
                TblAdmin Admin;
                bool Success = kullaniciIslemleri.Login(TxtKullaniciAdi, TxtSifre, out Admin, out Message);
                if (Success)
                {
                    HttpContext.Session.SetString("Login", "1");
                    HttpContext.Session.SetString("KullaniciId", Admin.KullaniciId.ToString());
                    return Redirect("~/Yonetim");
                }
            }
            return View();
        }
    }
    
}
