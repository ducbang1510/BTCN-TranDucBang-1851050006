using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop.DAO
{
    class DAO_KhachHang
    {
        ShoesShopDBEntities db;

        public DAO_KhachHang()
        {
            db = new ShoesShopDBEntities();
        }

        public dynamic LayDSKhachHang() // Data for DataGridView
        {
            var ds = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.FullName,
                c.DateOfBirth,
                c.Phone,
                c.Email,
                c.Address
            }).ToList();
            return ds;
        }

        public dynamic LayDSKhachHang2() // Data for ComboBox
        {
            dynamic ds = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.FullName
            }).ToList();

            return ds;
        }

        public bool ThemKhachHang(Customer c)
        {
            bool tinhTrang = false;
            try
            {
                db.Customers.Add(c);
                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool SuaThongTinKhachHang(Customer c)
        {
            bool tinhTrang = false;
            try
            {
                Customer customer = db.Customers.Find(c.CustomerID);

                customer.FullName = c.FullName;
                customer.DateOfBirth = c.DateOfBirth;
                customer.Email = c.Email;
                customer.Phone = c.Phone;
                customer.Address = c.Address;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;
        }

        public bool XoaThongTinKhachHang(int maKH)
        {
            bool tinhTrang = true;
            try
            {
                Customer c = db.Customers.Find(maKH);
                db.Customers.Remove(c);
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
