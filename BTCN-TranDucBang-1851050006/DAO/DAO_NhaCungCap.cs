using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.DAO
{
    class DAO_NhaCungCap
    {
        ShoesShopDBEntities db;
        public DAO_NhaCungCap()
        {
            db = new ShoesShopDBEntities();
        }

        public dynamic LayDSNhaCungCap()
        {
            var ds = db.Suppliers.Select(s => new
            {
                s.SupplierID,
                s.CompanyName,
                s.Phone,
                s.Address,

            }).ToList();

            return ds;
        }

        public bool ThemNhaCungCap(Supplier s)
        {
            bool tinhTrang = false;
            try
            {
                db.Suppliers.Add(s);
                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool SuaThongTinNhaCungCap(Supplier s)
        {
            bool tinhTrang = false;
            try
            {
                Supplier sp = db.Suppliers.Find(s.SupplierID);
                sp.CompanyName = s.CompanyName;
                sp.Phone = s.Phone;
                sp.Address = s.Address;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception ex)
            {
                tinhTrang = false;
                MessageBox.Show(ex.Message);
            }

            return tinhTrang;
        }

        public bool XoaNhaCungCap(int maNCC)
        {
            bool tinhTrang = false;
            try
            {
                Supplier sp = db.Suppliers.Find(maNCC);

                db.Suppliers.Remove(sp);
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
