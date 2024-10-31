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
    public partial class XemChiTietHoaDon : Form
    {
        private int maHoaDon;
        private int loaiHoaDon;
        sanpham pro = new sanpham();

        public XemChiTietHoaDon(int maHoaDon,int loaiHoaDon)
        {
            this.maHoaDon = maHoaDon;
            this.loaiHoaDon = loaiHoaDon;
            InitializeComponent();
        }

        private void xemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            
            // Neu la hoa don nhap
            if(loaiHoaDon == 0) 
            {
                textBoxLoaiHoaDon.Text = "Hoa Don Nhap";  
            }

            // Neu la hoa don mua
            else
            {
                textBoxLoaiHoaDon.Text = "Hoa Don Mua";
            }
            textBoxMaHoaDon.Text = this.maHoaDon.ToString();
            dataGridView1.DataSource = pro.xemChiTietHoaDon(maHoaDon, loaiHoaDon);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;

            int tongTien = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows )
            {
                tongTien += (int)row.Cells[3].Value;
            }
            textBox1.Text = tongTien.ToString();
        }

    }
}
