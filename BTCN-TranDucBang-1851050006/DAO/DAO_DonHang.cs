using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN_TranDucBang_1851050006.DAO
{
    class DAO_DonHang
    {
        NorthwindEntities db;

        public DAO_DonHang()
        {
            db = new NorthwindEntities();
        }

        public dynamic LayDSKhachHang()
        {
            dynamic ds = db.Customers.Select(s => new 
            { 
                s.CustomerID, 
                s.CompanyName 
            }).ToList();

            return ds;
        }

        // Xử lý Employee
        public dynamic LayDSNhanVien()
        {
            var ds = db.Employees.Select(s => new 
            { 
                s.EmployeeID, 
                s.LastName, 
                s.FirstName 
            }).ToList();

            return ds;
        }

        // Xử lý Order
        public dynamic LayDSDonHang()
        {
            dynamic ds = db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                s.Customer.CompanyName,
                s.Employee.FirstName
            }).ToList();

            return ds;
        }

        public bool KTDonHang(Order donHang)
        {
            Order d = db.Orders.Find(donHang.OrderID);
            if (d != null)
            {
                return true;
            }
            else
                return false;
        }

        public void ThemDonHang(Order d)
        {
            db.Orders.Add(d);
            db.SaveChanges();
        }

        public void SuaDonHang(Order donHang)
        {
            Order d = db.Orders.Find(donHang.OrderID);

            d.OrderDate = donHang.OrderDate;
            d.CustomerID = donHang.CustomerID;
            d.EmployeeID = donHang.EmployeeID;

            db.SaveChanges();
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
    }
}
