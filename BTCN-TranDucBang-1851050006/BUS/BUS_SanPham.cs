using BTCN_TranDucBang_1851050006.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCN_TranDucBang_1851050006.BUS
{
    class BUS_SanPham
    {
        DAO_SanPham dSanPham;

        public BUS_SanPham()
        {
            dSanPham = new DAO_SanPham();
        }

        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = dSanPham.LayDSSanPham();

        }

        public void LayDSLoaiSP(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSLoaiSanPham();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryID";
        }

        public void LayDSNCC(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSNCC();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "SupplierID";
        }

        public void LayDSSanPham(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSSanPham();
            cb.DisplayMember = "ProductName";
            cb.ValueMember = "ProductID";
        }
        public Product HienThiDSSP(int maSP)
        {
            var s = dSanPham.LayThongTinSanPham(maSP);

            return s;
        }
    }
}
