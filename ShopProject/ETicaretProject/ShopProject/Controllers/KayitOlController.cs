using Layer.Business;
using Layer.Data;
using Microsoft.AspNetCore.Mvc;

namespace ShopProject.Controllers
{
    public class KayitOlController : Controller
    {
        private readonly Layer.Data.DbShopEntities _context;
        public KayitOlController()
        {
            _context = new Layer.Data.DbShopEntities();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register()
        {
            string HataMesaji;

            string TxtFullName = Request.Form["TxtFullName"].ToString();
            string TxtUsername = Request.Form["TxtUsername"].ToString();
            string TxtEMail = Request.Form["TxtEMail"].ToString();
            string TxtSifre = Request.Form["TxtSifre"].ToString();
            TblKullanici kullanici = new TblKullanici();
            kullanici.AdSoyad = TxtFullName;
            kullanici.KullaniciAdi = TxtUsername;
            kullanici.Sifre = TxtSifre;
            kullanici.EMail = TxtEMail;

            TKullaniciIslemleri kullaniciIslemleri = new TKullaniciIslemleri();
            bool Success = kullaniciIslemleri.KayitOl(kullanici, out HataMesaji);
            if (Success)
                return RedirectToAction("~/Home/Index");
            else
                return RedirectToAction("Index");
        }

    }
}
