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
    public partial class FChiTietDonHang : Form
    {
        public int maDonHang;
        BUS_CTDonHang busCTDH;
        public FChiTietDonHang()
        {
            InitializeComponent();
            busCTDH = new BUS_CTDonHang();
        }

        private void HienThiDSCTDonHang()
        {
            gVCTDH.DataSource = null;
            busCTDH.HienThiDSCTDH(gVCTDH, maDonHang);
            gVCTDH.Columns[0].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[1].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[2].Width = (int)(0.25 * gVCTDH.Width);
            gVCTDH.Columns[3].Width = (int)(0.25 * gVCTDH.Width);
        }

        private void FChiTietDonHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDonHang.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FCTDatHang f = new FCTDatHang();
            f.maDH = maDonHang;

            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maDH = int.Parse(gVCTDH.CurrentRow.Cells["OrderID"].Value.ToString());
            int maSP = int.Parse(gVCTDH.CurrentRow.Cells["ProductID"].Value.ToString());
            busCTDH.XoaCTDH(maDH, maSP);
            // load lại data
            HienThiDSCTDonHang();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order_Detail d = new Order_Detail();

            d.OrderID = int.Parse(txtMaDH.Text);
            d.ProductID = int.Parse(txtMaSP.Text);
            d.Quantity = short.Parse(txtSoLuong.Text);
            d.UnitPrice = decimal.Parse(txtDonGia.Text);

            busCTDH.SuaCTDH(d);
            HienThiDSCTDonHang();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                txtMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }

        private void FChiTietDonHang_Activated(object sender, EventArgs e)
        {
            HienThiDSCTDonHang();
        }
    }
}
