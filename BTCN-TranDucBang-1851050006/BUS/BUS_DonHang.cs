using ShoesShop.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.BUS
{
    class BUS_DonHang
    {
        DAO_DonHang daoDH;

        public BUS_DonHang()
        {
            daoDH = new DAO_DonHang();
        }

        public void HienThiDSDonHang(DataGridView dg)
        {
            dg.DataSource = daoDH.LayDSDonHang();
        }

        public void LayDSKH(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSKH();
            cb.DisplayMember = "FullName";
            cb.ValueMember = "CustomerID";
        }

        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSNV();
            cb.DisplayMember = "FullName";
            cb.ValueMember = "EmployeeID";
        }

        public void ThemDonHang(Order d)
        {
            if (daoDH.ThemDonHang(d))
            {
                MessageBox.Show("Thêm đơn hàng thành công", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm đơn hàng thất bại", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        public void XoaDonHang(int maDH)
        {
            if (daoDH.XoaDonHang(maDH))
            {
                MessageBox.Show("Xóa đơn hàng thành công", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa đơn hàng thất bại", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SuaDonHang(Order donHang)
        {
            if (daoDH.SuaDonHang(donHang))
            {
                MessageBox.Show("Sửa đơn hàng thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng thất bại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        public List<Order> LayDSDonHangReport()
        {
            return daoDH.LayDSDonHangReport();
        }
    }
}
