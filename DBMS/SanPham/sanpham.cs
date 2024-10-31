using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBMS
{
    internal class sanpham
    {

        mydb mydb=new mydb();

        public DataTable layTatCaSanPham()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTatCaSanPham()", mydb.getConnection);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public DataTable layTatCaSanPhamConBan()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTatCaSanPhamConBan()", mydb.getConnection);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public DataTable LaySanPhamTheoPhanLoai(string phanloai)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("select * from dbo.LaySanPhamTheoPhanLoai(@phanLoai)", mydb.getConnection);
            sqlCommand.Parameters.AddWithValue("@phanLoai", phanloai);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public DataTable LaySanPhamTheoTen(string tensp)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("select * from dbo.LaySanPhamTheoTen(@tenSP)", mydb.getConnection);
            sqlCommand.Parameters.AddWithValue("@tenSP", tensp);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
        public bool taoHoaDonNhap(int maHD, int maSP, DateTime ngayIn, int thanhTien, int soLuong, int donGia)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("TaoHoaDonNhap", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            // Thêm các tham số vào thủ tục lưu trữ
            cmd.Parameters.AddWithValue("@maHD", maHD);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            cmd.Parameters.AddWithValue("@ngayIn", ngayIn);
            cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            cmd.Parameters.AddWithValue("@donGia", donGia);

            if (cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public int layMaHoaDonNhap()
        {
            mydb.openConnection();
            SqlCommand cmd1 = new SqlCommand("Select dbo.LayMaHoaDonNhap()", mydb.getConnection);
            if (cmd1.ExecuteScalar() != DBNull.Value)
            {
                int maHD = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;
                mydb.closeConnection();
                return maHD;
            }
            else
            {
                mydb.closeConnection();
                return 1;
            }


        }
        public void SuaSanPham(int maSP, string name, int price, string categoy, string des )
        {
           /* mydb.openConnection();

            SqlCommand cmd = new SqlCommand("ThemSanPham", mydb.getConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ten", name);
            cmd.Parameters.AddWithValue("@giaBan", price);
            cmd.Parameters.AddWithValue("@phanloai", category);
            cmd.Parameters.AddWithValue("@moTa", des);
            cmd.Parameters.Add("@hinhAnh", SqlDbType.Image).Value = pic.ToArray();

            cmd.ExecuteNonQuery();

            mydb.closeConnection();
*/
        }
        public DataTable xemHoaDon(int loaiHoadon, DateTime datefrom, DateTime dateto)
        {
            DataTable dt = new DataTable();
            mydb.openConnection();
            SqlCommand cmd;
            // 0 la hoa don nhap 
            if (loaiHoadon == 0)
            {
                cmd = new SqlCommand("Select * from dbo.XemHoaDonNhap(@datefrom,@dateto)",mydb.getConnection);
            }
            // 1 la hoa don mua
            else
            {
                cmd = new SqlCommand("Select * from dbo.XemHoaDonMua(@datefrom,@dateto)", mydb.getConnection);
            }
            cmd.Parameters.AddWithValue ("@datefrom",datefrom);
            cmd.Parameters.AddWithValue("@dateto",dateto);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            mydb.closeConnection();
            return dt;
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
            return mahd + 1;
        }
        public DataTable xemChiTietHoaDon(int maHoaDon,int loaiHoaDon)
        {
            DataTable dt = new DataTable();
            mydb.openConnection();
            SqlCommand cmd;

            // 0 la hoa don nhap 
            if (loaiHoaDon == 0)
            {
                cmd = new SqlCommand("Select * from dbo.XemChiTietHoaDonNhap(@maHoaDon)", mydb.getConnection);
            }

            // 1 la hoa don mua
            else
            {
                cmd = new SqlCommand("Select * from dbo.XemChiTietHoaDonMua(@maHoaDon)", mydb.getConnection);
            }
            cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}
