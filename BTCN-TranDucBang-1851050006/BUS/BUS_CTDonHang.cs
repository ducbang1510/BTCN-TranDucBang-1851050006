using BTCN_TranDucBang_1851050006.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BTCN_TranDucBang_1851050006.BUS
{
    class BUS_CTDonHang
    {
        DAO_CTDonHang dCTDonHang;
        DAO_SanPham dSanPham;
        public BUS_CTDonHang()
        {
            dCTDonHang = new DAO_CTDonHang();
            dSanPham = new DAO_SanPham();
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
            var ds = dCTDonHang.LayDSCTDH(maDH);
            if (ds != null)
            {
                dg.DataSource = ds;
            }
            else
            {
                dg.DataSource = InitDG();
            }
        }

        public void ThemDanhSachCTDH(List<Order_Detail> list)
        {
            if (dCTDonHang.ThemDanhSachCTDH(list))
            {
                MessageBox.Show("Đặt hàng thành công");
            }
            else
            {
                MessageBox.Show("Đặt hàng không thành công");
            }
        }

        public bool ThemCTDH(int maDH, DataTable dtSanPham) //
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
                        d.ProductID = int.Parse(item[0].ToString());
                        d.UnitPrice = decimal.Parse(item[1].ToString());
                        d.Quantity = short.Parse(item[2].ToString());
                        d.Discount = float.Parse(item[3].ToString());
                        if(dCTDonHang.KiemTraSPDH(d))
                        {
                            dCTDonHang.ThemCTDH(d);
                        }
                        else
                        {
                            throw new Exception("Sản phẩm đã tồn tại " + d.ProductID);
                        }
                    }
                    tran.Complete();
                    ketQua = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ketQua = false;
                } 
            }

            return ketQua;
        }

        public void SuaCTDH(Order_Detail d)
        {
            if (dCTDonHang.SuaCTDH(d))
            {
                MessageBox.Show("Sửa chi tiết đơn hàng thành công");
            }
            else
            {
                MessageBox.Show("Không thấy chi tiết đơn hàng để sửa");
            }
        }

        public void XoaCTDH(int maDH, int maSP)
        {
            if (dCTDonHang.XoaCTDH(maDH, maSP))
            {
                MessageBox.Show("Xóa CTDH thành công");
            }
            else
            {
                MessageBox.Show("Xóa CTDH không thành công");
            }
        }
    }
}
