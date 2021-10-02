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
    public partial class FDatHang : Form
    {
        public int maDH;
        public int maKH;
        public string tenKH;

        DataTable dtSanPham;

        BUS_Giay busGiay;
        public FDatHang()
        {
            InitializeComponent();
            busGiay = new BUS_Giay();
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

        private void FChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = maKH.ToString();
            txtTenKH.Text = tenKH;
            HienThiDSSanPham();

            dtSanPham = new DataTable();

            dtSanPham.Columns.Add("ShoesID");
            dtSanPham.Columns.Add("ShoesName");
            dtSanPham.Columns.Add("UnitPrice");
            dtSanPham.Columns.Add("Quantity");
            dGVCTDH.DataSource = dtSanPham;

            dGVCTDH.Columns[0].Width = (int)(0.22 * dGVCTDH.Width);
            dGVCTDH.Columns[1].Width = (int)(0.22 * dGVCTDH.Width);
            dGVCTDH.Columns[2].Width = (int)(0.25 * dGVCTDH.Width);
            dGVCTDH.Columns[3].Width = (int)(0.22 * dGVCTDH.Width);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(txtMaGiay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool kiemtra = true;
                // duyet tung dong trong datatable
                // neu maSP co, tang so luong, chua co
                // them dong moi

                foreach (DataRow item in dtSanPham.Rows)
                {
                    if (item[0].ToString() == txtMaGiay.Text) //co maSP hay ko
                    {
                        kiemtra = false;
                        // tang so luong
                        item[3] = int.Parse(item[3].ToString()) + ((int)numSoLuong.Value);
                        break;
                    }
                }

                if (kiemtra)
                {
                    DataRow r = dtSanPham.NewRow();

                    r[0] = txtMaGiay.Text;
                    r[1] = txtTenGiay.Text;
                    r[2] = txtDonGia.Text;
                    r[3] = numSoLuong.Value.ToString();

                    dtSanPham.Rows.Add(r);
                }
            } 
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(txtMaGiay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dtSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm để xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int dem = -1;
                foreach (DataRow item in dtSanPham.Rows)
                {
                    dem++;
                    if (dem == dGVCTDH.CurrentCell.RowIndex)
                    {
                        item[2] = decimal.Parse(txtDonGia.Text);
                        item[3] = int.Parse(numSoLuong.Value.ToString());
                        break;
                    }
                }
            } 
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGiay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dtSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm để xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewCell c in dGVCTDH.SelectedCells)
                {
                    if (c.Selected)
                        dGVCTDH.Rows.RemoveAt(c.RowIndex);
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
                txtDonGia.Text = dGVGiay.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            }
        }

        private void dGVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVCTDH.Rows.Count)
            {
                txtMaGiay.Text = dGVCTDH.Rows[e.RowIndex].Cells["ShoesID"].Value.ToString();
                numSoLuong.Text = dGVCTDH.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtTenGiay.Text = dGVCTDH.Rows[e.RowIndex].Cells["ShoesName"].Value.ToString();
                txtDonGia.Text = dGVCTDH.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            }
        }

        private void btDatHang_Click(object sender, EventArgs e)
        {
            FXacNhanDonHang fHoaDon = new FXacNhanDonHang();

            fHoaDon.maKH = int.Parse(txtMaKH.Text);
            fHoaDon.tenKH = txtTenKH.Text;
            fHoaDon.dtSanPham = this.dtSanPham;

            fHoaDon.ShowDialog();
        }
    }
}
