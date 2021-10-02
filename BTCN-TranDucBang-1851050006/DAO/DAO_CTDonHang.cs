using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.DAO
{
    class DAO_CTDonHang
    {
        ShoesShopDBEntities db;

        public DAO_CTDonHang()
        {
            db = new ShoesShopDBEntities();
        }

        public dynamic LayDSCTDH(int maDH)
        {
            dynamic ds;

            ds = db.Order_Details.Where(s => s.OrderID == maDH)
                .Select(s => new
                {
                    s.OrderID,
                    s.ShoesID,
                    s.UnitPrice,
                    s.Quantity
                }).ToList();

            return ds;
        }

        public bool KiemTraSPDH(Order_Detail d)
        {
            bool tinhTrang = true;
            int? sl;
            sl = db.sp_KiemTraSPDonHang(d.OrderID, d.ShoesID).FirstOrDefault();

            if (sl == 1)
                tinhTrang = false;

            return tinhTrang;
        }

        public void ThemCTDonHang(Order_Detail d)
        {
            db.Order_Details.Add(d);
            db.SaveChanges();
        }

        public bool SuaCTDonHang(Order_Detail d)
        {
            bool tinhTrang = false;
            try
            {
                Order_Detail ct = db.Order_Details.First(s => s.OrderID == d.OrderID && s.ShoesID == d.ShoesID);

                ct.Quantity = d.Quantity;
                ct.UnitPrice = d.UnitPrice;

                db.SaveChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
            }
            return tinhTrang;
        }

        public bool XoaCTDonHang(int maDH, int maGiay)
        {
            bool tinhTrang = true;
            try
            {
                // Xoa chi tiet don hang co OrderID = maDH va ProductID = maSP
                Order_Detail d = db.Order_Details.Single(s => s.OrderID == maDH && s.ShoesID == maGiay);
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
