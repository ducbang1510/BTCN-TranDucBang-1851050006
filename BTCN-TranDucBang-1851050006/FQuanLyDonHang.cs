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
    public partial class FQuanLyDonHang : Form
    {
        BUS_DonHang busDH;
        public FQuanLyDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }

        public void CapNhatForm()
        {
            txtMaDH.Text = "";
            cbNhanVien.Text = "";
            cbKhachHang.Text = "";
            txtTongTien.Text = "";
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

        private void FQuanLyDonHang_Load(object sender, EventArgs e)
        {
            busDH.LayDSKH(cbKhachHang);
            busDH.LayDSNV(cbNhanVien);
            HienThiDSDonHang();
        }

        //kiểm tra ngày hiện tại
        public bool isToday()
        {
            return dtpNgayDatHang.Value.ToShortDateString().ToString() == DateTime.Today.ToShortDateString().ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!isToday())
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayDatHang.Value = DateTime.Today;
            }
            else
                if (txtTongTien.Text == "" || cbNhanVien.Text == "" ||
                    cbKhachHang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Xác nhận thêm thông tin đơn hàng", "Xác nhận",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Order d = new Order();

                        d.CustomerID = int.Parse(cbKhachHang.SelectedValue.ToString());
                        d.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
                        d.OrderDate = dtpNgayDatHang.Value;
                        d.TotalPrice = decimal.Parse(txtTongTien.Text);

                        busDH.ThemDonHang(d);
                        HienThiDSDonHang();
                    }
                }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng muốn sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa thông tin đơn hàng", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Order d = new Order();

                    d.OrderID = int.Parse(txtMaDH.Text);
                    d.OrderDate = dtpNgayDatHang.Value;
                    d.CustomerID = int.Parse(cbKhachHang.SelectedValue.ToString());
                    d.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());

                    busDH.SuaDonHang(d);
                    busDH.HienThiDSDonHang(gVDH);
                    CapNhatForm();
                }
            }        
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text != "")
            {
                if (MessageBox.Show("Xác nhận xóa đơn hàng", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    busDH.XoaDonHang(Int32.Parse(txtMaDH.Text));
                    busDH.HienThiDSDonHang(gVDH);
                    CapNhatForm();
                }    
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn hàng để xóa", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtTongTien.Text = gVDH.Rows[e.RowIndex].Cells["TotalPrice"].Value.ToString();
            }
        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            int maDH;
            maDH = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());

            FChiTietDonHang c = new FChiTietDonHang();
            c.maDH = maDH;
            c.ShowDialog();
        }  
    }
}
