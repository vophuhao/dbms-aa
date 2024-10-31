using System;
using System.Collections;
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
    public partial class BaoCaoDoanhThu : Form
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        mydb mydb = new mydb();
        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select  distinct sp.maSP, hdm.ngayIn, sp.Ten, SUM(mh.soLuong) as soluong ,  mh.donGia*SUM(mh.soluong) from HoaDonMua hdm join MuaHang mh on hdm.maHD = mh.maHD join SanPham sp on sp.maSP = mh.maSP Group by sp.maSP, hdm.ngayIn, sp.Ten,mh.soLuong, mh.donGia", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            int tong = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tong += (int)row.Cells[4].Value;
            }
            textBox1.Text = tong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;
           
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * from dbo.BAOCAODOANHTHU(@ngay1,@ngay2)", mydb.getConnection);

            // Thêm tham số cho ngày bắt đầu và ngày kết thúc
            cmd.Parameters.Add("@ngay1", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@ngay2", SqlDbType.DateTime).Value = toDate;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            int tong = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tong += (int)row.Cells[4].Value;
            }
            textBox1.Text = tong.ToString();
        }

    }
}
