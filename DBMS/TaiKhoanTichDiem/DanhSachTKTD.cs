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
    public partial class DanhSachTKTD : Form
    {
        public DanhSachTKTD()
        {
            InitializeComponent();
        }
        tichdiem tichdiem=new tichdiem();
        private void taikhoantichdiem_Load(object sender, EventArgs e)
        {
           
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = tichdiem.layTaiKhoanTichDiem();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemTKTD add=new ThemTKTD();
            add.ShowDialog();
        }
    }
}
