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
    public partial class FNhaCungCap : Form
    {
        BUS_NhaCungCap busNCC;
        public FNhaCungCap()
        {
            InitializeComponent();
            busNCC = new BUS_NhaCungCap();
        }

        public void CapNhatForm()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        public void HienThiDSNhaCungCap()
        {
            CapNhatForm();
            dGVNCC.DataSource = null;
            busNCC.LayDSNhaCungCap(dGVNCC);
            dGVNCC.Columns[0].Width = (int)(dGVNCC.Width * 0.10);
            dGVNCC.Columns[1].Width = (int)(dGVNCC.Width * 0.30);
            dGVNCC.Columns[2].Width = (int)(dGVNCC.Width * 0.206);
            dGVNCC.Columns[3].Width = (int)(dGVNCC.Width * 0.30);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm",
                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (MessageBox.Show("Xác nhận thêm nhà cung cấp", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Supplier s = new Supplier();
                s.CompanyName = txtTenNCC.Text;
                s.Phone = txtSDT.Text;
                s.Address = txtDiaChi.Text;

                busNCC.ThemNhaCungCap(s);
                HienThiDSNhaCungCap();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa thông tin nhà cung cấp", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Supplier s = new Supplier();
                    s.SupplierID = int.Parse(txtMaNCC.Text);
                    s.CompanyName = txtTenNCC.Text;
                    s.Phone = txtSDT.Text;
                    s.Address = txtDiaChi.Text;

                    busNCC.SuaThongTinNhaCungCap(s);
                    HienThiDSNhaCungCap();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int maNCC = int.Parse(txtMaNCC.Text);
                if (MessageBox.Show("Xác nhận xóa thông tin nhà cung cấp", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    busNCC.XoaNhaCungCap(maNCC);
                    HienThiDSNhaCungCap();
                }
            }

        }

        private void dGVNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVNCC.Rows.Count)
            {
                txtMaNCC.Text = dGVNCC.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();
                txtTenNCC.Text = dGVNCC.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                txtSDT.Text = dGVNCC.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtDiaChi.Text = dGVNCC.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }

        private void FNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDSNhaCungCap();
            txtMaNCC.Enabled = false;
        }


        // kiểm soát thông tin người dùng nhập vào

        //không cho nhập chữ
        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == char.Parse("."))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        //không cho nhập số
        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
