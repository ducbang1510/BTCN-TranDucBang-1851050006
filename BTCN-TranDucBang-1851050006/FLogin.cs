using ShoesShop.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop
{
    public partial class FLogin : Form
    {
        BUS_NhanVien busNV;

        public FLogin()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (busNV.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    this.Hide();
                    FMenu f = new FMenu();
                    f.username = txtTenDangNhap.Text;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
