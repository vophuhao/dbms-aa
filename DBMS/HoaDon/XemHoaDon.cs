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
    public partial class XemHoaDon : Form
    {
        public XemHoaDon()
        {
            InitializeComponent();
        }
        sanpham pro = new sanpham();
        int loaihoadon = 0;
        private void buttonXem_Click(object sender, EventArgs e)
        {
            DateTime datefrom = dateTimePicker1.Value.Date;
            DateTime dateto = dateTimePicker2.Value.Date;
            if (datefrom > dateto)
            {
                MessageBox.Show("Vui lòng chọn ngày sau ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 0 la xem hoa don nhap
            if (radioButton_hoaDonNhap.Checked)
            {
                loaihoadon = 0;
                dataGridView1.DataSource = pro.xemHoaDon(0, datefrom, dateto);
            }

            // 1 la xem hoa don mua
            else
            {
                loaihoadon = 1;
                dataGridView1.DataSource = pro.xemHoaDon(1, datefrom, dateto);

            }    


        }

        private void xemHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int maHoaDon = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                DialogResult result = MessageBox.Show("Bạn có muốn xem chi tiết hóa đơn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Nếu người dùng nhấn OK, mở form chi tiết hóa đơn
                    XemChiTietHoaDon chiTietForm = new XemChiTietHoaDon(maHoaDon, loaihoadon); // Truyền mã hóa đơn vào form
                    chiTietForm.ShowDialog(); // Mở form xem chi tiết
                }
            }
        }
    }
}