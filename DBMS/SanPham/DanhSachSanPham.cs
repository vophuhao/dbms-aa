using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class DanhSachSanPham : Form
    {
        public DanhSachSanPham()
        {
            InitializeComponent();
        }
        sanpham product=new sanpham();
        private void listProduct_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = product.layTatCaSanPham();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
           //phuhao sua ơ đây
      
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ThemSanPham addProduct = new ThemSanPham();
            addProduct.ShowDialog();
        }

        int row;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow.Index;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuaSanPham editproduct = new SuaSanPham();
            editproduct.textBoxName.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            editproduct.textBoxDes.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            editproduct.textBoxPrice.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            editproduct.textBoxPhanLoai.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            editproduct.label6.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            editproduct.pictureBox1.Image = Image.FromStream(picture);
            editproduct.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tensp = textBox1.Text;
            dataGridView1.DataSource = product.LaySanPhamTheoTen(tensp);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phanloai = comboBox1.Text;
            dataGridView1.DataSource = product.LaySanPhamTheoPhanLoai(phanloai);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = product.layTatCaSanPham();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
    }
}
