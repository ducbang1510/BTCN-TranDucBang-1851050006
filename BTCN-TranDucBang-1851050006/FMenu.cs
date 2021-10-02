using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesShop.BUS;

namespace ShoesShop
{
    public partial class FMenu : Form
    {
        public string username;
        BUS_NhanVien busNV;

        public FMenu()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
        }

        private void btQuanLyGiay_Click(object sender, EventArgs e)
        {
            FQuanLyGiay f = new FQuanLyGiay();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            FQuanLyDonHang f = new FQuanLyDonHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btQuanLyKH_Click(object sender, EventArgs e)
        {
            FQuanLyKhachHang f = new FQuanLyKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btNhaCC_Click(object sender, EventArgs e)
        {
            FNhaCungCap f = new FNhaCungCap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btQuanLyNV_Click(object sender, EventArgs e)
        {          
            FQuanLyNhanVien f = new FQuanLyNhanVien();
            f.username = username;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();       
        }

        //Đặt hàng
        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyKhachHang f = new FQuanLyKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            FQuanLyBaoCao f = new FQuanLyBaoCao();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
