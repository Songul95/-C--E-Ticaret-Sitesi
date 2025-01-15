using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public class TUrunIslemleri : IDatabaseIslemleri, IUrun
    {
        public override DbShopEntities Context { get; set; }

        public TUrunIslemleri()
        {
            base.ConnectDb();
        }

        public bool AddProduct(TblÜrün Urun, out string Message)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int UrunId, out string Message)
        {
            throw new NotImplementedException();
        }

        public bool EditProduct(int UrunId, TblÜrün Urun, out string Message)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TblKategori> GetAllProducts(int CategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
