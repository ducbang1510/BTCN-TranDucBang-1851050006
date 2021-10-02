using ShoesShop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop.BUS
{
    class BUS_NhanVien
    {
        DAO_NhanVien daoNV;

        public BUS_NhanVien()
        {
            daoNV = new DAO_NhanVien();
        }

        //check isAdmin
        public bool isAdmin(string username)
        {
            return daoNV.isAdmin(username);
        }

        //check isMyUsername
        public bool isMyUsername(string username, int maNV)
        {
            return daoNV.isMyUsername(username, maNV);
        }


        public void HienThiDSNhanVien(ComboBox cb)
        {
            cb.DisplayMember = "FullName";
            cb.ValueMember = "EmployeeID";
            cb.DataSource = daoNV.LayDSNhanVien2();
        }

        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = daoNV.LayDSNhanVien();
        }

        public void ThemNhanVien(Employee nv)
        {
            if (daoNV.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên mới thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên mới thất bại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SuaThongTinNhanVien(Employee nv)
        {
            if (daoNV.SuaThongTinNhanVien(nv))
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }
        }

        public void XoaNhanVien(int maNV)
        {
            if (daoNV.XoaNhanVien(maNV))
            {
                MessageBox.Show("Xóa nhân viên thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool KiemTraTenTaiKhoan(string username)
        {
            bool tinhTrang = false;

            if (daoNV.KiemTraTenTaiKhoan(username))
            {
                tinhTrang = true;
            }

            return tinhTrang;
        }

        public bool DangNhap(string username, string password)
        {
            bool tinhTrang = false;

            if (daoNV.DangNhap(username, password))
            {
                MessageBox.Show("Đăng nhập thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tinhTrang = true;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return tinhTrang;
        }
    }
}
