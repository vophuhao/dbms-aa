using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class TaoHoaDonNhapHang : Form
    {
        mydb mydb = new mydb();
        int tongtien = 0;
        public TaoHoaDonNhapHang()
        {
            InitializeComponent();
        }
        sanpham product = new sanpham();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_danhSachChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhapHang_Load(object sender, EventArgs e)
        {
            this.dataGridView_danhSachChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_danhSachSanPham.AllowUserToAddRows = false;
            dataGridView_danhSachSanPham.RowTemplate.Height = 80;
            DataTable dt = new DataTable();
            dt = product.layTatCaSanPham();
            dt.Columns.RemoveAt(3); // xoa cot phan loai
            dt.Columns.RemoveAt(3); // xoa cot mo ta
            dataGridView_danhSachSanPham.DataSource = dt;
            picCol = (DataGridViewImageColumn)dataGridView_danhSachSanPham.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dataGridView_danhSachSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_nhapHang_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoadonnhaphang = new HoaDonNhap();
            foreach (DataGridViewRow row in dataGridView_danhSachChon.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                hoadonnhaphang.dataGridView2.Rows.Add(newRow);
            }
            hoadonnhaphang.Show();
            

        }
        public int checkMaSP(int maSP)
        {
            foreach (DataGridViewRow row in dataGridView_danhSachChon.Rows)
            {
                if (maSP == (int)row.Cells[0].Value)
                {
                    return row.Index;
                }
            }
            return -1;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            int dongia = (int)dataGridView_danhSachSanPham.CurrentRow.Cells[2].Value;
            int soluong = (int)numericUpDown1.Value;
            int thanhtien = dongia * soluong;
            if (checkMaSP(idSP) >= 0)
            {
                dataGridView_danhSachChon.Rows[checkMaSP(idSP)].Cells[3].Value = (int)dataGridView_danhSachChon.Rows[checkMaSP(idSP)].Cells[3].Value + soluong;
            }
            else
            {
                dataGridView_danhSachChon.Rows.Add(idSP, tenSP, dongia, soluong);
            }

            tongtien += thanhtien;
            label_tongTien.Text = "Tổng tiền: " + tongtien.ToString();
        }
        int idSP;
        String tenSP;
        private void dataGridView_danhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSP = (int)dataGridView_danhSachSanPham.CurrentRow.Cells[0].Value;
            tenSP = dataGridView_danhSachSanPham.CurrentRow.Cells[1].Value.ToString();
            numericUpDown1.Value = 1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                tongtien -= (int)dataGridView_danhSachChon.CurrentRow.Cells[4].Value;
                int index = dataGridView_danhSachChon.CurrentRow.Index;
                dataGridView_danhSachChon.Rows.RemoveAt(index);
                label_tongTien.Text = "Tổng tiền: " + tongtien.ToString();
            }
            catch { }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_timKiem.Text == "")
                {
                    MessageBox.Show("Nhap thong tin de tim kiem", "Tim Kiem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand command = new SqlCommand("Select maSP,Ten,giaBan,hinhAnh from SanPham WHERE CONCAT(maSP,Ten,phanloai,giaBan) LIKE '%" + textBox_timKiem.Text + "%'", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_danhSachSanPham.DataSource = table;
                dataGridView_danhSachSanPham.Columns[0].HeaderText = "Ma SP";
                dataGridView_danhSachSanPham.Columns[1].HeaderText = "Ten";
                dataGridView_danhSachSanPham.Columns[2].HeaderText = "Gia Ban";
                dataGridView_danhSachSanPham.Columns[3].HeaderText = "Hinh Anh";
            }
            catch { }
        }

        private void dataGridView_danhSachChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_catNhat.Value = Convert.ToInt32(dataGridView_danhSachChon.CurrentRow.Cells[3].Value);
        }

        private void btn_catNhat_Click(object sender, EventArgs e)
        {
            dataGridView_danhSachChon.CurrentRow.Cells[3].Value = (int)numericUpDown_catNhat.Value;
        }

        private void panel_timKiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
