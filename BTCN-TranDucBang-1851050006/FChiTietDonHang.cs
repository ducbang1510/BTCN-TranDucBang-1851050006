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
    public partial class FChiTietDonHang : Form
    {
        public int maDH;
        BUS_CTDonHang busCTDH;
        public FChiTietDonHang()
        {
            InitializeComponent();
            busCTDH = new BUS_CTDonHang();
        }

        private void HienThiDSCTDonHang()
        {
            gVCTDH.DataSource = null;
            busCTDH.HienThiDSCTDH(gVCTDH, maDH);
            gVCTDH.Columns[0].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[1].Width = (int)(0.2 * gVCTDH.Width);
            gVCTDH.Columns[2].Width = (int)(0.25 * gVCTDH.Width);
            gVCTDH.Columns[3].Width = (int)(0.25 * gVCTDH.Width);
        }

        private void FChiTietDonHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();
            HienThiDSCTDonHang();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //gọi form đặt hàng
            FDatHang f = new FDatHang();
            //truyền maDH qua form đặt hàng
            f.maDH = this.maDH;
            f.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Order_Detail d = new Order_Detail();

            d.OrderID = int.Parse(txtMaDH.Text);
            d.ShoesID = int.Parse(txtMaGiay.Text);
            d.Quantity = int.Parse(txtSoLuong.Text);
            d.UnitPrice = decimal.Parse(txtGia.Text);

            busCTDH.SuaCTDonHang(d);
            HienThiDSCTDonHang();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maDH = int.Parse(gVCTDH.CurrentRow.Cells["OrderID"].Value.ToString());
            int maGiay = int.Parse(gVCTDH.CurrentRow.Cells["ShoesID"].Value.ToString());
            busCTDH.XoaCTDonHang(maDH, maGiay);

            HienThiDSCTDonHang();
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                txtMaGiay.Text = gVCTDH.Rows[e.RowIndex].Cells["ShoesID"].Value.ToString();
                txtGia.Text = gVCTDH.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }
    }
}
