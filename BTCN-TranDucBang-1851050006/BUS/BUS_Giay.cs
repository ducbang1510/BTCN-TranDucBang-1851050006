using ShoesShop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.BUS
{
    class BUS_Giay
    {
        DAO_Giay daoGiay;

        public BUS_Giay()
        {
            daoGiay = new DAO_Giay();
        }

        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = daoGiay.LayDSSanPham();

        }

        public void LayDSNhaCungCap(ComboBox cb)
        {
            cb.DataSource = daoGiay.LayDSNhaCungCap();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "SupplierID";
        }

        public void ThemThongTinGiay(Sho s)
        {
            if (daoGiay.ThemThongTinGiay(s))
            {
                MessageBox.Show("Thêm sản phẩm thành công",
                          "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại",
                          "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SuaThongTinGiay(Sho s)
        {
            if (daoGiay.SuaThongTinGiay(s))
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công",
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin sản phẩm thất bại",
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void XoaThongTinGiay(int maGiay)
        {
            if (daoGiay.XoaThongTinGiay(maGiay))
            {
                MessageBox.Show("Xóa sản phẩm thành công",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm không thành công",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // report section
        public List<Sho> LayDSSanPhamReport()
        {
            return daoGiay.LayDSSanPhamReport();
        }
    }
}
