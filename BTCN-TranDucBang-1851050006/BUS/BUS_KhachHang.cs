using ShoesShop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang daoKH;

        public BUS_KhachHang()
        {
            daoKH = new DAO_KhachHang();
        }

        public void LayDSKhachHang(DataGridView dg)
        {
            dg.DataSource = daoKH.LayDSKhachHang();

        }

        public void LayDSKhachHang(ComboBox cb)
        {
            cb.DisplayMember = "FullName";
            cb.ValueMember = "CustomerID";
            cb.DataSource = daoKH.LayDSKhachHang2();
        }

        public void ThemKhachHang(Customer c)
        {
            if (daoKH.ThemKhachHang(c))
            {
                MessageBox.Show("Thêm khách hàng mới thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SuaThongTinKhachHang(Customer c)
        {
            if (daoKH.SuaThongTinKhachHang(c))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void XoaThongTinKhachHang(int maKH)
        {
            if (daoKH.XoaThongTinKhachHang(maKH))
            {
                MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thông tin khách hàng thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
