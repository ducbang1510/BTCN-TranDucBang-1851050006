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
    public partial class FQuanLyGiay : Form
    {
        BUS_Giay busGiay;
        public FQuanLyGiay()
        {
            InitializeComponent();
            busGiay = new BUS_Giay();
        }

        public void CapNhatForm()
        {
            txtMaGiay.Text = "";
            txtTenGiay.Text = "";
            cbNCC.Text = "";
            txtGia.Text = "";
            txtSoLuongTon.Text = "";
        }

        public void HienThiDSSanPham()
        {
            dGVGiay.DataSource = null;
            busGiay.LayDSSanPham(dGVGiay);
            dGVGiay.Columns[0].Width = (int)(dGVGiay.Width * 0.08);
            dGVGiay.Columns[1].Width = (int)(dGVGiay.Width * 0.3);
            dGVGiay.Columns[2].Width = (int)(dGVGiay.Width * 0.15);
            dGVGiay.Columns[3].Width = (int)(dGVGiay.Width * 0.17);
            dGVGiay.Columns[4].Width = (int)(dGVGiay.Width * 0.1);
            dGVGiay.Columns[5].Width = (int)(dGVGiay.Width * 0.15);
        }

        private void FQuanLyGiay_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            busGiay.LayDSNhaCungCap(cbNCC);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenGiay.Text == "" || cbNCC.Text == "" || txtGia.Text == ""
                || txtSoLuongTon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm thông tin sản phẩm", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Sho s = new Sho();

                    s.ShoesName = txtTenGiay.Text;
                    s.QuantityRemaining = int.Parse(txtSoLuongTon.Text);
                    s.UnitPrice = decimal.Parse(txtGia.Text);
                    s.Size = (int)numSize.Value;
                    s.SupplierID = int.Parse(cbNCC.SelectedValue.ToString());

                    busGiay.ThemThongTinGiay(s);
                    HienThiDSSanPham();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaGiay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa thông tin sản phẩm", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Sho s = new Sho();

                    s.ShoesID = int.Parse(dGVGiay.Rows[dGVGiay.CurrentRow.Index].Cells[0].Value.ToString());
                    s.ShoesName = txtTenGiay.Text;
                    s.QuantityRemaining = int.Parse(txtSoLuongTon.Text);
                    s.UnitPrice = decimal.Parse(txtGia.Text);
                    s.Size = (int)numSize.Value;
                    s.SupplierID = int.Parse(cbNCC.SelectedValue.ToString());

                    busGiay.SuaThongTinGiay(s);
                    HienThiDSSanPham();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGiay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int maGiay = int.Parse(dGVGiay.Rows[dGVGiay.CurrentRow.Index].Cells[0].Value.ToString());

                if (MessageBox.Show("Xác nhận xóa thông tin sản phẩm", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    busGiay.XoaThongTinGiay(maGiay);
                    HienThiDSSanPham();
                }
            }
        }

        private void dGVGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVGiay.Rows.Count)
            {
                txtMaGiay.Enabled = false;
                txtMaGiay.Text = dGVGiay.Rows[e.RowIndex].Cells["ShoesID"].Value.ToString();
                txtTenGiay.Text = dGVGiay.Rows[e.RowIndex].Cells["ShoesName"].Value.ToString();
                txtGia.Text = dGVGiay.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSoLuongTon.Text = dGVGiay.Rows[e.RowIndex].Cells["QuantityRemaining"].Value.ToString();
                if(dGVGiay.Rows[e.RowIndex].Cells["Size"].Value != null)
                    numSize.Value = decimal.Parse(dGVGiay.Rows[e.RowIndex].Cells["Size"].Value.ToString());
                if (dGVGiay.Rows[e.RowIndex].Cells["CompanyName"].Value != null)
                    cbNCC.Text = dGVGiay.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
            }
        }

        // kiểm soát thông tin người dùng nhập vào

        //không cho nhập chữ và kí tự đặc biệt 
        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == char.Parse("."))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }
    }
}
