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
    public partial class FQuanLyNhanVien : Form
    {
        public string username;
        BUS_NhanVien busNV;

        public FQuanLyNhanVien()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
        }

        public void HienThiDSNhanVien()
        {
            CapNhatForm();
            dGVNhanVien.DataSource = null;
            busNV.LayDSNhanVien(dGVNhanVien);
        }

        public void CapNhatForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cbVaiTro.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void FQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien(); 
            txtMaNV.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!busNV.isAdmin(username))
            {
                MessageBox.Show("Chỉ Admin mới được phép truy cập chức năng này",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtHoTen.Text == "" || txtGioiTinh.Text == "" || txtEmail.Text == ""
                || txtSDT.Text == "" || txtVaiTro.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (busNV.KiemTraTenTaiKhoan(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
                txtTaiKhoan.Text = "";
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm thông tin nhân viên", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Employee nv = new Employee();
                    nv.FullName = txtHoTen.Text;
                    nv.DateOfBirth = dtpNgaySinh.Value.Date;
                    nv.Gender = txtGioiTinh.Text;
                    nv.Email = txtEmail.Text;
                    nv.Phone = txtSDT.Text;
                    nv.Address = txtDiaChi.Text;
                    nv.UserRole = cbVaiTro.Text;
                    nv.Username = txtTaiKhoan.Text;
                    nv.Password = txtMatKhau.Text;

                    busNV.ThemNhanVien(nv);
                    HienThiDSNhanVien();
                }
            }
        }


        public bool kiemTraTaiKhoan()
        {
            bool ketQua = true;
            if (txtTaiKhoan.Text != username)
                ketQua = false;

            return ketQua;
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!busNV.isMyUsername(username, int.Parse(txtMaNV.Text)))
            {
                MessageBox.Show("Chỉ được phép sửa thông tin của mình", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!kiemTraTaiKhoan())
            {
                MessageBox.Show("Không được phép sửa tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Xác nhận sửa thông tin", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Employee nv = new Employee();
                    nv.EmployeeID = int.Parse(txtMaNV.Text);
                    nv.FullName = txtHoTen.Text;
                    nv.Email = txtEmail.Text;
                    nv.Phone = txtSDT.Text;
                    nv.Address = txtDiaChi.Text;
                    nv.Password = txtMatKhau.Text;

                    busNV.SuaThongTinNhanVien(nv);
                    HienThiDSNhanVien();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!busNV.isAdmin(username))
            {
                MessageBox.Show("Chỉ Admin mới được phép truy cập chức năng này",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int maNV = int.Parse(txtMaNV.Text);

                if (MessageBox.Show("Xác nhận xóa thông tin nhân viên", "Xác nhận",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    busNV.XoaNhanVien(maNV);
                    HienThiDSNhanVien();
                }
            }
        }

        private void dGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVNhanVien.Rows.Count)
            {
                txtMaNV.Text = dGVNhanVien.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtHoTen.Text = dGVNhanVien.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtGioiTinh.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                dtpNgaySinh.Text = dGVNhanVien.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
                txtEmail.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtSDT.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtDiaChi.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtVaiTro.Text = dGVNhanVien.Rows[e.RowIndex].Cells["UserRole"].Value.ToString();
                cbVaiTro.Text = dGVNhanVien.Rows[e.RowIndex].Cells["UserRole"].Value.ToString();
                txtTaiKhoan.Text = dGVNhanVien.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                txtMatKhau.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
        }

        // kiểm soát thông tin người dùng nhập vào

        //không cho nhập số
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        //không cho nhập chữ và kí tự đặc biệt 
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == char.Parse("."))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        //hide password when dataGridView showing
        private void dGVNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 9 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        
    }
}
