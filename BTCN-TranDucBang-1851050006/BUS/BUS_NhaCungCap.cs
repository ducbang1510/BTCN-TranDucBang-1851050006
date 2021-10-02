using ShoesShop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.BUS
{
    class BUS_NhaCungCap
    {
        DAO_NhaCungCap daoNCC;
        public BUS_NhaCungCap()
        {
            daoNCC = new DAO_NhaCungCap();
        }

        public void LayDSNhaCungCap(DataGridView dg)
        {
            dg.DataSource = daoNCC.LayDSNhaCungCap();
        }

        public void ThemNhaCungCap(Supplier s)
        {
            if (daoNCC.ThemNhaCungCap(s))
            {
                MessageBox.Show("Thêm nhà cung cấp mới thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp mới thất bại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SuaThongTinNhaCungCap(Supplier s)
        {
            if (daoNCC.SuaThongTinNhaCungCap(s))
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp thất bại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void XoaNhaCungCap(int maNCC)
        {
            if (daoNCC.XoaNhaCungCap(maNCC))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại",
                       "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
