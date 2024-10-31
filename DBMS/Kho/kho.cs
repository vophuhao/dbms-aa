using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    
    internal class kho
    {
        mydb mydb = new mydb();

        public DataTable LayTatCaSPKho()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * from dbo.LayTatCaSanPhamTrongKho()", mydb.getConnection);



            SqlDataAdapter mydataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            mydataAdapter.Fill(dt);
            return dt;
        }
       
        public void ThayDoiTrangThaiKho(int masp)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("CapNhatTrangThai", mydb.getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maSP", masp);
            sqlCommand.ExecuteNonQuery();
            mydb.closeConnection();
        }
    }
}
