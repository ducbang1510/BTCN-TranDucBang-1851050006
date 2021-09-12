using BTCN_TranDucBang_1851050006.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCN_TranDucBang_1851050006.BUS
{
    class BUS_DonHang
    {
        DAO_DonHang dDonHang;

        public BUS_DonHang()
        {
            dDonHang = new DAO_DonHang();
        }

        public void LayDSKhachHang(ComboBox cb)
        {
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "CustomerID";
            cb.DataSource = dDonHang.LayDSKhachHang();
        }

        // Phần xử lý nhân viên
        public void LayDSNhanVien(ComboBox cb)
        {
            cb.DisplayMember = "FirstName";
            cb.ValueMember = "EmployeeID";
            cb.DataSource = dDonHang.LayDSNhanVien();
        }

        // Phần xử lý đơn hàng
        public void HienThiDSDonHang(DataGridView dg)
        {
            dg.DataSource = dDonHang.LayDSDonHang();
        }

        public bool TaoDonHang(Order d)
        {
            try
            {
                dDonHang.ThemDonHang(d);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void XoaDonHang(int maDH)
        {
            if (dDonHang.XoaDonHang(maDH))
            {
                MessageBox.Show("Xóa đơn hàng thành công");
            }
            else
            {
                MessageBox.Show("Không thấy đơn hàng để xóa");
            }
        }

        public bool SuaDonHang(Order donHang)
        {
            if (dDonHang.KTDonHang(donHang))
            {
                try
                {
                    dDonHang.SuaDonHang(donHang);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
