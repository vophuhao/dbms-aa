using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }
        tichdiem tk = new tichdiem();
        sanpham product = new sanpham();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void hoadonmua_Load(object sender, EventArgs e)
        {
            dataGridView2.AllowUserToAddRows = false;
            labelhd.Text = tk.laymahdnhap().ToString();

            labelngay.Text = DateTime.Now.ToString();

            int tongtien = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                tongtien += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            label6.Text = tongtien.ToString();
            int thanhtien = tongtien;
            label8.Text = thanhtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maHD = product.layMaHoaDonNhap();
            int maSP;
            DateTime ngayIn;
            int thanhTien;
            int soLuong;
            int donGia;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                maSP = Convert.ToInt32(row.Cells[0].Value);
                //MessageBox.Show(maSP.ToString());
                ngayIn = DateTime.Now;
                soLuong = Convert.ToInt32(row.Cells[3].Value);
                donGia = Convert.ToInt32(row.Cells[2].Value);
                thanhTien = Convert.ToInt32(label8.Text);
                if (!product.taoHoaDonNhap(maHD, maSP, ngayIn, thanhTien, soLuong, donGia))
                {
                    MessageBox.Show("Nhap that bai");
                    return;
                }

            }
            MessageBox.Show("Nhap thanh cong");
        }
    }



}
