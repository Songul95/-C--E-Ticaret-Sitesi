using Layer.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public class TKullaniciIslemleri : AbsKullaniciIslemleri
    {
        public override DbSet<TblAdmin> TblAdmin { get => base.TblAdmin; set => base.TblAdmin = value; }
        public override DbSet<TblKategori> TblKategori { get => base.TblKategori; set => base.TblKategori = value; }
        public override DbSet<TblKullanici> TblKullanici { get => base.TblKullanici; set => base.TblKullanici = value; }
        public override DbSet<TblÜrün> TblÜrün { get => base.TblÜrün; set => base.TblÜrün = value; }

        public override bool GirisYap(string KullaniciAdi, string Sifre)
        {
            return base.GirisYap(KullaniciAdi, Sifre);
        }

        public override bool KayitOl(TblKullanici Kullanici, out string HataMesaji)
        {
            return base.KayitOl(Kullanici, out HataMesaji);
        }
    }
}
