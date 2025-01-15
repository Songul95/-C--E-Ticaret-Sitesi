using Layer.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
   public abstract class AbsKullaniciIslemleri :DbShopEntities, IKullaniciIslemleri
    {
        public virtual bool GirisYap(string KullaniciAdi, string Sifre)
        {
            {
                bool result = false;

                var Kullanici = (from data in TblKullanici
                                 where data.KullaniciAdi == KullaniciAdi
                                 select data).AsNoTracking().FirstOrDefault();
                if (Kullanici != null)
                {
                    if (Kullanici.Sifre == Sifre)
                        result = true;
                }

                return result;
            }
        }

        public virtual bool KayitOl(TblKullanici Kullanici, out string HataMesaji)
        {

            bool result = false;
            HataMesaji = String.Empty;

            bool KullaniciKayitliMi = KullaniciVarmi(Kullanici.KullaniciAdi, Kullanici.Sifre);

            if (KullaniciKayitliMi)
                HataMesaji = "Kullanıcı adı veya mail adresi kullanımda";
            else
            {
                TblKullanici.Add(Kullanici);
                SaveChanges();
                result = true;
            }

            return result;
        }
        private  bool KullaniciVarmi(string KullaniciAdi, string Email)
        {
            bool result = (from data in TblKullanici
                           where data.KullaniciAdi == KullaniciAdi || data.EMail == Email
                           select data).Any();

            return result;
        }
    }
    
}
