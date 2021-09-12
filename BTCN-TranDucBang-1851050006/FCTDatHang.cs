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
    public partial class FCTDatHang : Form
    {
        BUS_DonHang busDH;
        BUS_CTDonHang busCTDH;
        BUS_SanPham busSP;

        public int maDH;
        bool co = false;
        DataTable dtSanPham;
        public FCTDatHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
            busCTDH = new BUS_CTDonHang();
            busSP = new BUS_SanPham();
        }

        private void FCTDatHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();

            busSP.LayDSSanPham(cbSP);
            co = true;

            dtSanPham = new DataTable();

            dtSanPham.Columns.Add("ProductID");
            dtSanPham.Columns.Add("UnitPrice");
            dtSanPham.Columns.Add("Quantity");
            dtSanPham.Columns.Add("Discount");
            dGSP.DataSource = dtSanPham;

            dGSP.Columns[0].Width = (int)(0.22 * dGSP.Width);
            dGSP.Columns[1].Width = (int)(0.22 * dGSP.Width);
            dGSP.Columns[2].Width = (int)(0.25 * dGSP.Width);
            dGSP.Columns[3].Width = (int)(0.22 * dGSP.Width);
        }

        void HienThiThongTinSP(string maSP)
        {
            int ma = int.Parse(maSP);
            Product s = busSP.HienThiDSSP(ma);
            txtLoaiSP.Text = s.Category.CategoryName.ToString();
            txtNhaCC.Text = s.Supplier.CompanyName.ToString();
            txtDonGia.Text = s.UnitPrice.ToString();
        }

        private void btTaoDonHang_Click(object sender, EventArgs e)
        {
            if(busCTDH.ThemCTDH(maDH, dtSanPham))
            {
                MessageBox.Show("Đặt hàng thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Đặt hàng thất bại");
            }
            //var ds = new List<Order_Detail>();
            //foreach (DataRow item in dtSanPham.Rows)
            //{
            //    Order_Detail d = new Order_Detail();

            //    d.OrderID = int.Parse(txtMaDH.Text);
            //    d.ProductID = int.Parse(item[0].ToString());
            //    d.UnitPrice = decimal.Parse(item[1].ToString());
            //    d.Quantity = short.Parse(item[2].ToString());
            //    d.Discount = float.Parse(item[3].ToString());

            //    ds.Add(d);
            //}
            //busCTDH.ThemDanhSachCTDH(ds);
        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                HienThiThongTinSP(cbSP.SelectedValue.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;
            // duyet tung dong trong datatable
            // neu maSP co, tang so luong, chua co
            // them dong moi

            foreach (DataRow item in dtSanPham.Rows)
            {
                if (item[0].ToString() == cbSP.SelectedValue.ToString()) //co maSP hay ko
                {
                    kiemtra = false;
                    // tang so luong
                    item[2] = int.Parse(item[2].ToString()) + int.Parse(numSoLuong.Value.ToString());
                    break;
                }
            }

            if (kiemtra)
            {
                DataRow r = dtSanPham.NewRow();

                r[0] = cbSP.SelectedValue.ToString();
                r[1] = txtDonGia.Text;
                r[2] = numSoLuong.Value.ToString();
                r[3] = txtDiscount.Text;

                dtSanPham.Rows.Add(r);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dGSP.SelectedCells)
            {
                if (c.Selected)
                    dGSP.Rows.RemoveAt(c.RowIndex);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int dem = -1;
            foreach (DataRow item in dtSanPham.Rows)
            {
                dem++;
                if (dem == dGSP.CurrentCell.RowIndex)
                {
                    item[1] = decimal.Parse(txtDonGia.Text);
                    item[2] = int.Parse(numSoLuong.Value.ToString());
                    item[3] = float.Parse(txtDiscount.Text);
                    break;
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count)
            {
                cbSP.SelectedIndex = int.Parse(dGSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString()) - 1;
                numSoLuong.Text = dGSP.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtDiscount.Text = dGSP.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            }
        }
    }
}
