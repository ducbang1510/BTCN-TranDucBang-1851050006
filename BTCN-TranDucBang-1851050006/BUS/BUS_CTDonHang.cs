using ShoesShop.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ShoesShop.BUS
{
    class BUS_CTDonHang
    {
        DAO_CTDonHang daoCTDH;

        public BUS_CTDonHang()
        {
            daoCTDH = new DAO_CTDonHang();
        }

        private DataTable InitDG()
        {
            DataTable dtCTDH = new DataTable();

            dtCTDH.Columns.Add("OrderID");
            dtCTDH.Columns.Add("ProductID");
            dtCTDH.Columns.Add("UnitPrice");
            dtCTDH.Columns.Add("Quantity");

            return dtCTDH;
        }

        public void HienThiDSCTDH(DataGridView dg, int maDH)
        {
            var ds = daoCTDH.LayDSCTDH(maDH);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDG();
            }
        }

        public bool ThemCTDonHang(int maDH, DataTable dtSanPham) //
        {
            bool ketQua = false;
            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in dtSanPham.Rows)
                    {
                        Order_Detail d = new Order_Detail();
                        d.OrderID = maDH;
                        d.ShoesID = int.Parse(item[0].ToString());
                        d.UnitPrice = decimal.Parse(item[2].ToString());
                        d.Quantity = short.Parse(item[3].ToString());

                        if (daoCTDH.KiemTraSPDH(d))
                        {
                            daoCTDH.ThemCTDonHang(d);
                        }
                        else
                        {
                            throw new Exception("Sản phẩm đã tồn tại, vui lòng thử lại" + d.ShoesID);
                        }
                    }

                    tran.Complete();
                    ketQua = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ketQua = false;
                }
            }

            return ketQua;
        }

        public void SuaCTDonHang(Order_Detail d)
        {
            if (daoCTDH.SuaCTDonHang(d))
            {
                MessageBox.Show("Sửa chi tiết đơn hàng thành công",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa chi tiết đơn hàng thất bại",
                          "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void XoaCTDonHang(int maDH, int maGiay)
        {
            if (daoCTDH.XoaCTDonHang(maDH, maGiay))
            {
                MessageBox.Show("Xóa CTDH thành công",
                          "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa CTDH thất bại",
                          "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
