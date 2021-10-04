using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN_TranDucBang_1851050006.DAO
{
    class DAO_CTDonHang
    {
        NorthwindEntities db;

        public DAO_CTDonHang()
        {
            db = new NorthwindEntities();
        }

        public dynamic LayDSCTDH(int maDH)
        {
            dynamic ds;

            ds = db.Order_Details.Where(s => s.OrderID == maDH)
                .Select(s => new
                {
                    s.OrderID,
                    s.ProductID,
                    s.UnitPrice,
                    s.Quantity
                }).ToList();

            return ds;
        }

        public bool ThemDanhSachCTDH(List<Order_Detail> ds)
        {
            bool tinhTrang = true;
            try
            {
                db.Order_Details.AddRange(ds);
                db.SaveChanges();

                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
                throw;
            }

            return tinhTrang;
        }

        public bool KiemTraSPDH(Order_Detail d)
        {
            int? sl;
            sl = db.sp_KiemTraSPDonHang(d.OrderID, d.ProductID).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;
        }

        public void ThemCTDH(Order_Detail d)
        { 
            db.Order_Details.Add(d);
            db.SaveChanges();
        }

        public bool SuaCTDH(Order_Detail d)
        {
            bool tinhTrang = false;
            try
            {
                Order_Detail ct = db.Order_Details.First(s => s.OrderID == d.OrderID && s.ProductID == d.ProductID);

                ct.Quantity = d.Quantity;
                ct.UnitPrice = d.UnitPrice;
                ct.Discount = d.Discount;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool XoaCTDH(int maDH, int maSP)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa chi tiet don hang co OrderID = maDH va ProductID = maSP
                Order_Detail d = db.Order_Details.Single(s => s.OrderID == maDH && s.ProductID == maSP);
                db.Order_Details.Remove(d);
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
