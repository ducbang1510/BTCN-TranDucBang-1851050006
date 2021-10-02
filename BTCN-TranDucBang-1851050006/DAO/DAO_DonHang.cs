using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop.DAO
{
    class DAO_DonHang
    {
        ShoesShopDBEntities db;

        public DAO_DonHang()
        {
            db = new ShoesShopDBEntities();
        }

        public dynamic LayDSDonHang()
        {
            dynamic ds = db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                Customer = s.Customer.FullName,
                Employee = s.Employee.FullName,
                s.TotalPrice
            }).ToList();

            return ds;
        }

        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(s => new
            {
                s.CustomerID,
                s.FullName,
            }).ToList();

            return ds;
        }

        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.FullName,
            }).ToList();

            return ds;
        }

        public bool ThemDonHang(Order d)
        {
            bool tinhTrang = true;

            try
            {
                db.Orders.Add(d);
                db.SaveChanges();
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool SuaDonHang(Order donHang)
        {
            bool tinhTrang = true;

            try
            {
                Order d = db.Orders.Find(donHang.OrderID);

                d.OrderDate = donHang.OrderDate;
                d.CustomerID = donHang.CustomerID;
                d.EmployeeID = donHang.EmployeeID;

                db.SaveChanges();
            }
            catch (Exception)
            {
                tinhTrang = false;
            }

            return tinhTrang;        
        }

        public bool XoaDonHang(int maDH)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa tat ca chi tiet don hang co OrderID = maDH
                var ds = db.Order_Details.Where(s => s.OrderID == maDH).Select(s => s);
                db.Order_Details.RemoveRange(ds);
                db.SaveChanges();

                // Xoa don hang co OrderID = maDH
                Order d = db.Orders.Find(maDH);
                if (d != null)
                {
                    db.Orders.Remove(d);
                    db.SaveChanges();

                    tinhTrang = true;
                }
                else
                    tinhTrang = false;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public List<Order> LayDSDonHangReport()
        {
            var ds = db.Orders.Select(s => s).ToList();
            return ds;
        }
    }
}
