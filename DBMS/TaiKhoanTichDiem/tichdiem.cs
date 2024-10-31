using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace DBMS
{
    internal class tichdiem
    {
        mydb mydb = new mydb();

        public DataTable layTaiKhoanTichDiem()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTatCaTaiKhoanTichDiem()", mydb.getConnection);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;

        }
        public DataTable laytktheosdt(string sdt)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTaiKhoanTichDiem(@sdt)", mydb.getConnection);
            sqlCommand.Parameters.AddWithValue("sdt", sdt);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public bool themTk(string name,string sdt)
        {
            try
            {
                mydb.openConnection();
                SqlCommand cmd = new SqlCommand("TaoTaiKhoanTichDiem", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", name);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@tongDiemTich", 0);
                cmd.ExecuteNonQuery();

                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public int laymahd()
        {
            mydb.openConnection();
            int mahd;
            SqlCommand cmd = new SqlCommand("select  dbo.LayMaHoaDon()", mydb.getConnection);
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                return 1;
            }
            else
            {
                mahd = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return mahd+1;
        }
        public int laymahdnhap()
        {
            mydb.openConnection();
            int mahd;
            SqlCommand cmd = new SqlCommand("select  dbo.LayMaHoaDonNhap()", mydb.getConnection);
            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                return 1;
            }
            else
            {
                mahd = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return mahd + 1;
        }
        public bool taohoadon2(DateTime day,  int thanhtien, int diemtich)
        {
            try
            {
                mydb.openConnection();
                SqlCommand cmd = new SqlCommand("ThemHoaDonMua", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngayIn", day);
                cmd.Parameters.AddWithValue("@sdt", DBNull.Value);
                cmd.Parameters.AddWithValue("@thanhTien", thanhtien);
                cmd.Parameters.AddWithValue("@diemTich", diemtich);
                cmd.ExecuteNonQuery();

                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void congdiem(string sdt,int diem)
        {
            try
            {
                mydb.openConnection();
                SqlCommand cmd = new SqlCommand("CapNhatTaiKhoanTichDiem", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tongDiemTich", diem);
                cmd.Parameters.AddWithValue("@sdt", sdt);
               
                cmd.ExecuteNonQuery();

                mydb.closeConnection();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public bool taohoadon(DateTime day,String sdt,int thanhtien,int diemtich)
        {
            try
            {
                mydb.openConnection();
                SqlCommand cmd = new SqlCommand("ThemHoaDonMua", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngayIn", day);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@thanhTien", thanhtien);
                cmd.Parameters.AddWithValue("@diemTich", diemtich);
                cmd.ExecuteNonQuery();

                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool taomuahang(int mahd,int masp,int soluong,int dongia)
        {
            try
            {
                mydb.openConnection();
                SqlCommand cmd = new SqlCommand("ThemMuaHang", mydb.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHD", mahd);
                cmd.Parameters.AddWithValue("@maSP",masp);
                cmd.Parameters.AddWithValue("@soLuong", soluong);
                cmd.Parameters.AddWithValue("@donGia", dongia);
                cmd.ExecuteNonQuery();

                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
