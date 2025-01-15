using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public interface IAdminIslemleri
    {
        bool Register(TblAdmin Admin, out string Message);
        bool Login(string KullaniciAdi, string Sifre, out TblAdmin Admin, out string Message);
    }
}
