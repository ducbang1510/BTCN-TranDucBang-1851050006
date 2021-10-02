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
    public partial class FXacNhanDonHang : Form
    {
        public int maKH;
        public string tenKH;
        public DataTable dtSanPham;
        private decimal total = 0;

        BUS_KhachHang busKH;
        BUS_NhanVien busNV;
        BUS_DonHang busDH;
        BUS_CTDonHang busCTDH;

        public FXacNhanDonHang()
        {
            InitializeComponent();
            busKH = new BUS_KhachHang();
            busNV = new BUS_NhanVien();
            busDH = new BUS_DonHang();
            busCTDH = new BUS_CTDonHang();
        }

        private void HienThiDSDonHang()
        {
            gVDH.DataSource = null;
            busDH.HienThiDSDonHang(gVDH);
            gVDH.Columns[0].Width = (int)(0.1 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[4].Width = (int)(0.2 * gVDH.Width);
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            busKH.LayDSKhachHang(cbKhachHang);
            if (maKH != 0)
            {
                cbKhachHang.Text = tenKH;
            }
            busNV.HienThiDSNhanVien(cbNhanVien);

            foreach (DataRow item in dtSanPham.Rows)
            {
                total += decimal.Parse(item[2].ToString()) * int.Parse(item[3].ToString());
            }
            txtTongTien.Text = total.ToString();
            HienThiDSDonHang();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Order d = new Order();

            d.CustomerID = int.Parse(cbKhachHang.SelectedValue.ToString());
            d.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
            d.OrderDate = dtpNgayDatHang.Value;
            d.TotalPrice = decimal.Parse(txtTongTien.Text);

            busDH.ThemDonHang(d);
            HienThiDSDonHang();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order d = new Order();

            d.OrderID = int.Parse(txtMaDH.Text);
            d.OrderDate = dtpNgayDatHang.Value;
            d.CustomerID = int.Parse(cbKhachHang.SelectedValue.ToString());
            d.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());

            busDH.SuaDonHang(d);
            busDH.HienThiDSDonHang(gVDH);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text != "")
            {
                busDH.XoaDonHang(Int32.Parse(txtMaDH.Text));
                busDH.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn hàng để xóa");
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMaDH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để xác nhận",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int ma = int.Parse(txtMaDH.Text);

                if (busCTDH.ThemCTDonHang(ma, dtSanPham))
                {
                    MessageBox.Show("Đặt hàng thành công");
                    Close();
                }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại");
                }
            }
        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDatHang.Text = gVDH.Rows[e.RowIndex].Cells["OrderDate"].Value.ToString();
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells["Customer"].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells["Employee"].Value.ToString();
                //txtTongTien.Text = gVDH.Rows[e.RowIndex].Cells["TotalPrice"].Value.ToString();
            }
        }
    }
}
