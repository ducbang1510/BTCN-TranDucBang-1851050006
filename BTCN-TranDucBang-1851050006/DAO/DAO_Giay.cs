using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.DAO
{
    class DAO_Giay
    {
        ShoesShopDBEntities db;
        
        public DAO_Giay()
        {
            db = new ShoesShopDBEntities();
        }

        public dynamic LayDSNhaCungCap()
        {
            var ds = db.Suppliers.Select(s => new
            {
                s.SupplierID,
                s.CompanyName
            }).ToList();

            return ds;
        }

        public dynamic LayDSSanPham()
        {
            var ds = db.Shoes.Select(s => new
            {
                s.ShoesID,
                s.ShoesName,
                s.UnitPrice,
                s.QuantityRemaining,
                s.Size,
                s.Supplier.CompanyName,
            }).ToList();
            return ds;
        }

        public bool ThemThongTinGiay(Sho s)
        {
            bool tinhTrang = false;
            try
            {
                db.Shoes.Add(s);
                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool SuaThongTinGiay(Sho s)
        {
            bool tinhTrang = false;
            try
            {
                Sho shoes = db.Shoes.Find(s.ShoesID);

                shoes.ShoesName = s.ShoesName;
                shoes.QuantityRemaining = s.QuantityRemaining;
                shoes.UnitPrice = s.UnitPrice;
                shoes.SupplierID = s.SupplierID;
                shoes.Size = s.Size;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool XoaThongTinGiay(int maGiay)
        {
            bool tinhTrang = true;
            try
            {
                Sho s = db.Shoes.Find(maGiay);
                db.Shoes.Remove(s);
                db.SaveChanges();

                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }
        // report section
        public List<Sho> LayDSSanPhamReport()
        {
            var ds = db.Shoes.Select(s => s).ToList();
            return ds;
        }
    }
}
