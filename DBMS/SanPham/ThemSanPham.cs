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
    public partial class ThemSanPham : Form
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }
        mydb mydb = new mydb();
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                string price = textBoxPrice.Text;
                string des = textBoxDes.Text;
                string category = textBoxPhanLoai.Text;

                MemoryStream pic = new MemoryStream();

                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                mydb.openConnection();

                SqlCommand cmd = new SqlCommand("ThemSanPham", mydb.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ten", name);
                cmd.Parameters.AddWithValue("@giaBan", price);
                cmd.Parameters.AddWithValue("@phanloai", category);
                cmd.Parameters.AddWithValue("@moTa", des);
                cmd.Parameters.Add("@hinhAnh", SqlDbType.Image).Value = pic.ToArray();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Them san pham mới thành công");
                mydb.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
