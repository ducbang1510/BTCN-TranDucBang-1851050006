using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN_TranDucBang_1851050006.DAO
{

    class DAO_SanPham
    {
        NorthwindEntities db;

        public DAO_SanPham()
        {
            db = new NorthwindEntities();
        }

        public dynamic LayDSSanPham()
        {
            var ds = db.Products.Select(s => new
            {
                s.ProductID,
                s.ProductName,
                s.UnitPrice,
                s.QuantityPerUnit,
                s.Supplier.CompanyName,
                s.Category.CategoryName
            }).ToList();
            return ds;
        }

        public dynamic LayDSLoaiSanPham()
        {
            var ds = db.Categories.Select(s => new
            {
                s.CategoryID,
                s.CategoryName
            }).ToList();

            return ds;
        }

        public dynamic LayDSNCC()
        {
            var ds = db.Suppliers.Select(s => new
            {
                s.SupplierID,
                s.CompanyName
            }).ToList();

            return ds;
        }

        public Product LayThongTinSanPham(int maSP)
        {
            Product sp = db.Products.FirstOrDefault(s => s.ProductID == maSP);

            return sp;
        }
    }
}
