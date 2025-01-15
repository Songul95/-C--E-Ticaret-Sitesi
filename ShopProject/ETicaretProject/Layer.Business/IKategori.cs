using Layer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public interface IKategori
    {
        IQueryable<TblKategori> GetCategories();
        bool AddProduct(TblKategori Kategori, out string Message);
        bool EditProduct(int KategoriId, TblKategori Kategori, out string Message);
        bool DeleteProduct(int KategoriId, out string Message);
    }
}
