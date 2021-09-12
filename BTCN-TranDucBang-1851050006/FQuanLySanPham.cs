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
    public partial class FQuanLySanPham : Form
    {
        BUS_SanPham busSP;
        public FQuanLySanPham()
        {
            InitializeComponent();
            busSP = new BUS_SanPham();
        }

        public void HienThiDSSanPham()
        {
            gVSanPham.DataSource = null;
            busSP.LayDSSanPham(gVSanPham);
            gVSanPham.Columns[0].Width = (int)(gVSanPham.Width * 0.1);
            gVSanPham.Columns[1].Width = (int)(gVSanPham.Width * 0.2);
            gVSanPham.Columns[2].Width = (int)(gVSanPham.Width * 0.15);
            gVSanPham.Columns[3].Width = (int)(gVSanPham.Width * 0.15);
            gVSanPham.Columns[4].Width = (int)(gVSanPham.Width * 0.2);
            gVSanPham.Columns[5].Width = (int)(gVSanPham.Width * 0.15);
        }

        private void FQuanLySanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            busSP.LayDSLoaiSP(cbLoaiSP);
            busSP.LayDSNCC(cbNCC);
        }
    }
}
