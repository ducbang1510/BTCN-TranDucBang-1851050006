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

        public bool ThemSP(Product p)
        {
            bool tinhTrang = false;
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool SuaSP(Product p)
        {
            bool tinhTrang = false;
            try
            {
                Product product = db.Products.Find(p.ProductID);

                product.ProductName = p.ProductName;
                product.UnitsInStock = p.UnitsInStock;
                product.UnitPrice = p.UnitPrice;
                product.CategoryID = p.CategoryID;
                product.SupplierID = p.SupplierID;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool XoaSP(int maSP)
        {
            bool tinhTrang = true;
            try
            {
                Product p = db.Products.Find(maSP);
                db.Products.Remove(p);
                db.SaveChanges();

                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }
    }
}
