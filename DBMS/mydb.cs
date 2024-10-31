using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    

    internal class mydb
    {

        
            SqlConnection con = new SqlConnection(@"Data Source=26.168.186.68;Initial Catalog=DOAN;Persist Security Info=True;User ID=sa;Password=123");
            // get the connection
            public SqlConnection getConnection
            {
                get
                {
                    return con;
                }
            }

            // open the connection
            public void openConnection()
            {
                if ((con.State == ConnectionState.Closed))
                {
                    con.Open();
                }

            }
            // close the connection
            public void closeConnection()
            {
                if ((con.State == ConnectionState.Open))
                {
                    con.Close();
                }

            }
        }
    }

