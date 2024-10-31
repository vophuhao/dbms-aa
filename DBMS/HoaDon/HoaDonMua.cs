using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class HoaDonMua : Form
    {
        public HoaDonMua()
        {
            InitializeComponent();
        }
        tichdiem tk = new tichdiem();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void hoadonmua_Load(object sender, EventArgs e)
        {


            labelhd.Text = tk.laymahd().ToString();

            labelngay.Text = DateTime.Now.ToString();
            if (textBoxsdt.Text.Length <= 0) {
                textBoxdiemdung.Visible = false;
            }

            int tongtien = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++) {

                tongtien += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            label6.Text = tongtien.ToString();
            label7.Text=0.ToString();
            int thanhtien = tongtien - Convert.ToInt32(label7.Text);
            label8.Text=thanhtien.ToString();
        }
    


    private void textBoxsdt_TextChanged(object sender, EventArgs e)
    {
        textBoxdiemdung.Visible = true;
        if (textBoxsdt.Text.Length == 10)
        {
            DataTable dt = new DataTable();
            dt = tk.laytktheosdt(textBoxsdt.Text.ToString());
            if (dt != null)
            {

                labeldiem.Text = dt.Rows[0][2].ToString();
            }
        }



    }

        private void textBoxdiemdung_TextChanged(object sender, EventArgs e)
        {
           

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(labeldiem.Text))
            {
                MessageBox.Show("Khong duoc dung diem cao hon diem dang co");
                label7.Text = 0.ToString();
            }
         
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tam = Convert.ToInt32(label8.Text);
            label7.Text = textBoxdiemdung.Text.ToString();

           
            
            
                label8.Text = (Convert.ToInt32(label8.Text) - Convert.ToInt32(label7.Text)).ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime=Convert.ToDateTime(labelngay.Text);

           
            int thanhtien = Convert.ToInt32(label8.Text);
            int diemtich = thanhtien * 5 / 100;
           
            int mahd=Convert.ToInt32(labelhd.Text);
            if (textBoxsdt.Text.Length<=0)
            {
               
                if (tk.taohoadon2(dateTime, thanhtien, 0))
                {
                    
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        tk.taomuahang(mahd, Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value));
                    }
                    MessageBox.Show("Tao hoa don thanh cong");

                }
            }
            else
            {
                string sdt = textBoxsdt.Text.ToString();
                DataTable dt = new DataTable();
                int diemdangco = 0;
                dt = tk.laytktheosdt(textBoxsdt.Text.ToString());
                if (dt != null)
                {

                    diemdangco = Convert.ToInt32(dt.Rows[0][2]);
                    
                }
                if (textBoxdiemdung.Text.Length > 0)
                {
                  
                    int diem = diemdangco - Convert.ToInt32(textBoxdiemdung.Text);
                    MessageBox.Show(diem.ToString());
                    tk.congdiem(sdt, diem);
                }
                if (tk.taohoadon(dateTime, sdt, thanhtien, diemtich))
                {
                    try
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            tk.taomuahang(mahd, Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value), Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value));
                        }
                        MessageBox.Show("Tao hoa don thanh cong");
                        DataTable dt2 = new DataTable();
                        int diemdangco1 = 0;
                        dt2 = tk.laytktheosdt(textBoxsdt.Text.ToString());
                        if (dt2 != null)
                        {

                            diemdangco1 = Convert.ToInt32(dt2.Rows[0][2]);
                        }
                        
                        diemdangco1 += diemtich;
                        tk.congdiem(sdt, diemdangco1);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemTKTD tk=new ThemTKTD();
            tk.Show();
        }
    }

        
    
}
