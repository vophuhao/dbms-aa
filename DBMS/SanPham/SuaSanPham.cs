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
    public partial class SuaSanPham : Form
    {
        public SuaSanPham()
        {
            InitializeComponent();
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
        mydb mydb = new mydb();
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string price = textBoxPrice.Text;
            string des = textBoxDes.Text;
            string category = textBoxPhanLoai.Text;
            int id = Convert.ToInt32(label6.Text);
            MemoryStream pic = new MemoryStream();

            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("CapNhatSanPham", mydb.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maSP", id);
            cmd.Parameters.AddWithValue("@Ten", name);
            cmd.Parameters.AddWithValue("@giaBan", price);
            cmd.Parameters.AddWithValue("@phanloai", category);
            cmd.Parameters.AddWithValue("@moTa", des);
            cmd.Parameters.Add("@hinhAnh", SqlDbType.Image).Value = pic.ToArray();

            cmd.ExecuteNonQuery();
            MessageBox.Show("chinh sua thanh cong");
            mydb.closeConnection();


        }
    }
}
