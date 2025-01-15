using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public interface IUrun
    {
        bool AddProduct(TblÜrün Urun, out string Message);
        bool EditProduct(int UrunId, TblÜrün Urun, out string Message);
        bool DeleteProduct(int UrunId, out string Message);
        IQueryable<TblKategori> GetAllProducts(int CategoryId);

    }
}
