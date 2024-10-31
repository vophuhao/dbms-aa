using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class ThemTKTD : Form
    {
        public ThemTKTD()
        {
            InitializeComponent();
        }
        tichdiem taikhoantichdiem=new tichdiem();
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sdt = textBox2.Text;
            if (taikhoantichdiem.themTk(name, sdt))
            {
                MessageBox.Show("them thành công");
            }
            else
            {
                MessageBox.Show("them that bai");
            }
          



            
        }
    }
}
