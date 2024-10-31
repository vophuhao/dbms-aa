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
    public partial class SanPhamTrongKho : Form
    {
        public SanPhamTrongKho()
        {
            InitializeComponent();
        }
        kho kho=new kho();
        private void Kho_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = kho.LayTatCaSPKho();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void Kho_DoubleClick(object sender, EventArgs e)
        {
           
        }
        int row;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow.Index;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int masp = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
         

            DialogResult result = MessageBox.Show("Bạn có muốn dừng bán sản phẩm này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                kho.ThayDoiTrangThaiKho(masp);
               
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = kho.LayTatCaSPKho();
              
            }
        }
    }
}
