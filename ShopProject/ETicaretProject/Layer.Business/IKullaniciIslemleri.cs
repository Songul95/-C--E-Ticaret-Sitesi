using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public interface IKullaniciIslemleri
    {
        bool GirisYap(string KullaniciAdi, string Sifre);
        bool KayitOl(TblKullanici Kullanici, out string HataMesaji);
    }
}
