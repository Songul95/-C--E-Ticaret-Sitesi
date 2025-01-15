using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public class TAdminIslemleri : IAdminIslemleri
    {
        private DbShopEntities Context;

        public TAdminIslemleri()
        {
            Context = new DbShopEntities();
        }
        public bool Login(string KullaniciAdi, string Sifre, out TblAdmin Admin, out string Message)
        {
            bool result = false;
            Message = "Hatalı kullanıcı adı veya şifre";
            Admin = (from data in Context.TblAdmin
                     where
                     data.KullaniciAdi == KullaniciAdi
                     select data).FirstOrDefault();
            if (Admin != null)
            {
                if (Admin.Sifre == Sifre)
                {

                    result = true;
                }
            }
            return result;


        }

        public bool Register(TblAdmin Admin, out string Message)
        {
            throw new NotImplementedException();
        }
    }

}
