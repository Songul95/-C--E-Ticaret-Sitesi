using Layer.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public class TKategoriIslemleri : IKategori
    {

        private DbShopEntities Context;
        public TKategoriIslemleri()
        {
            Context = new DbShopEntities();
        }

        public bool AddProduct(TblKategori Kategori, out string Message)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int KategoriId, out string Message)
        {
            throw new NotImplementedException();
        }

        public bool EditProduct(int KategoriId, TblKategori Kategori, out string Message)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TblKategori> GetCategories()
        {
            return (from data in Context.TblKategori
                    orderby data.KategoriAdi
                    select data).
                   AsQueryable().
                   AsNoTracking();
        }
    }
}
