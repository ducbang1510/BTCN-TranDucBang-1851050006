using BTCN_TranDucBang_1851050006.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCN_TranDucBang_1851050006
{
    public partial class FQuanLyDonHang : Form
    {
        BUS_DonHang busDH;
        public FQuanLyDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }

        private void FQuanLyDonHang_Load(object sender, EventArgs e)
        {
            HienThiDSDonHang();
            busDH.LayDSKhachHang(cbKhachHang);
            busDH.LayDSNhanVien(cbNhanVien);
        }

        private void HienThiDSDonHang()
        {
            gVDH.DataSource = null;
            busDH.HienThiDSDonHang(gVDH);
            gVDH.Columns[0].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.25 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.25 * gVDH.Width);
        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDatHang.Text = gVDH.Rows[e.RowIndex].Cells["OrderDate"].Value.ToString();
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Order d = new Order();

            d.OrderDate = dtpNgayDatHang.Value;
            d.CustomerID = cbKhachHang.SelectedValue.ToString();
            d.EmployeeID = Int32.Parse(cbNhanVien.SelectedValue.ToString());

            if (busDH.TaoDonHang(d))
            {
                MessageBox.Show("Tạo đơn hàng thành công");
                busDH.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order d = new Order();

            d.OrderID = int.Parse(txtMaDH.Text);
            d.OrderDate = dtpNgayDatHang.Value;
            d.CustomerID = cbKhachHang.SelectedValue.ToString();
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            int maDH;
            maDH = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            //goi Form
            FChiTietDonHang c = new FChiTietDonHang();
            //truyen bien
            c.maDonHang = maDH;
            c.ShowDialog();
        }
    }
}
