using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaoHoaDonMuaHang hoadonMua=    new TaoHoaDonMuaHang();
            hoadonMua.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachSanPham list=new DanhSachSanPham();
            list.Show();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhSachTKTD tk=new DanhSachTKTD();
            tk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SanPhamTrongKho kho=new SanPhamTrongKho();
            kho.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TaoHoaDonNhapHang nhap=new TaoHoaDonNhapHang();
            nhap.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XemHoaDon xemhd = new XemHoaDon();
            xemhd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu doanhThu=new BaoCaoDoanhThu();
            doanhThu.Show();
        }
    }
}
