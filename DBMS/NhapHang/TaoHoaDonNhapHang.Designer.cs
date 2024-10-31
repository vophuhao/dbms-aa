namespace DBMS
{
    partial class TaoHoaDonNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_danhSachSanPham = new System.Windows.Forms.DataGridView();
            this.panel_timKiem = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.panel_Chon = new System.Windows.Forms.Panel();
            this.btn_catNhat = new System.Windows.Forms.Button();
            this.numericUpDown_catNhat = new System.Windows.Forms.NumericUpDown();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label_tongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nhapHang = new System.Windows.Forms.Button();
            this.dataGridView_danhSachChon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).BeginInit();
            this.panel_timKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_Chon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_catNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_danhSachSanPham
            // 
            this.dataGridView_danhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_danhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachSanPham.Location = new System.Drawing.Point(25, 69);
            this.dataGridView_danhSachSanPham.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView_danhSachSanPham.Name = "dataGridView_danhSachSanPham";
            this.dataGridView_danhSachSanPham.RowHeadersWidth = 62;
            this.dataGridView_danhSachSanPham.RowTemplate.Height = 28;
            this.dataGridView_danhSachSanPham.Size = new System.Drawing.Size(661, 621);
            this.dataGridView_danhSachSanPham.TabIndex = 0;
            this.dataGridView_danhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhSachSanPham_CellClick);
            // 
            // panel_timKiem
            // 
            this.panel_timKiem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_timKiem.Controls.Add(this.btn_them);
            this.panel_timKiem.Controls.Add(this.numericUpDown1);
            this.panel_timKiem.Controls.Add(this.label1);
            this.panel_timKiem.Controls.Add(this.btn_Tim);
            this.panel_timKiem.Controls.Add(this.textBox_timKiem);
            this.panel_timKiem.Controls.Add(this.dataGridView_danhSachSanPham);
            this.panel_timKiem.Location = new System.Drawing.Point(0, 0);
            this.panel_timKiem.Name = "panel_timKiem";
            this.panel_timKiem.Size = new System.Drawing.Size(716, 801);
            this.panel_timKiem.TabIndex = 1;
            this.panel_timKiem.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_timKiem_Paint);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(485, 712);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 54);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(271, 723);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm:";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(561, 22);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(125, 40);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(166, 26);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(364, 32);
            this.textBox_timKiem.TabIndex = 1;
            // 
            // panel_Chon
            // 
            this.panel_Chon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Chon.Controls.Add(this.btn_catNhat);
            this.panel_Chon.Controls.Add(this.numericUpDown_catNhat);
            this.panel_Chon.Controls.Add(this.btn_xoa);
            this.panel_Chon.Controls.Add(this.label_tongTien);
            this.panel_Chon.Controls.Add(this.label2);
            this.panel_Chon.Controls.Add(this.btn_nhapHang);
            this.panel_Chon.Controls.Add(this.dataGridView_danhSachChon);
            this.panel_Chon.Location = new System.Drawing.Point(715, 0);
            this.panel_Chon.Name = "panel_Chon";
            this.panel_Chon.Size = new System.Drawing.Size(804, 801);
            this.panel_Chon.TabIndex = 2;
            // 
            // btn_catNhat
            // 
            this.btn_catNhat.Location = new System.Drawing.Point(194, 641);
            this.btn_catNhat.Name = "btn_catNhat";
            this.btn_catNhat.Size = new System.Drawing.Size(140, 45);
            this.btn_catNhat.TabIndex = 7;
            this.btn_catNhat.Text = "Cật nhật";
            this.btn_catNhat.UseVisualStyleBackColor = true;
            this.btn_catNhat.Click += new System.EventHandler(this.btn_catNhat_Click);
            // 
            // numericUpDown_catNhat
            // 
            this.numericUpDown_catNhat.Location = new System.Drawing.Point(42, 649);
            this.numericUpDown_catNhat.Name = "numericUpDown_catNhat";
            this.numericUpDown_catNhat.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown_catNhat.TabIndex = 6;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(553, 631);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(204, 40);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label_tongTien
            // 
            this.label_tongTien.AutoSize = true;
            this.label_tongTien.Location = new System.Drawing.Point(472, 690);
            this.label_tongTien.Name = "label_tongTien";
            this.label_tongTien.Size = new System.Drawing.Size(107, 24);
            this.label_tongTien.TabIndex = 5;
            this.label_tongTien.Text = "Tổng tiền : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm:";
            // 
            // btn_nhapHang
            // 
            this.btn_nhapHang.Location = new System.Drawing.Point(268, 726);
            this.btn_nhapHang.Name = "btn_nhapHang";
            this.btn_nhapHang.Size = new System.Drawing.Size(204, 40);
            this.btn_nhapHang.TabIndex = 3;
            this.btn_nhapHang.Text = "Nhập hàng ";
            this.btn_nhapHang.UseVisualStyleBackColor = true;
            this.btn_nhapHang.Click += new System.EventHandler(this.btn_nhapHang_Click);
            // 
            // dataGridView_danhSachChon
            // 
            this.dataGridView_danhSachChon.AllowUserToAddRows = false;
            this.dataGridView_danhSachChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_danhSachChon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_danhSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_danhSachChon.Location = new System.Drawing.Point(26, 49);
            this.dataGridView_danhSachChon.Name = "dataGridView_danhSachChon";
            this.dataGridView_danhSachChon.RowHeadersWidth = 62;
            this.dataGridView_danhSachChon.RowTemplate.Height = 28;
            this.dataGridView_danhSachChon.Size = new System.Drawing.Size(731, 576);
            this.dataGridView_danhSachChon.TabIndex = 0;
            this.dataGridView_danhSachChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhSachChon_CellClick);
            this.dataGridView_danhSachChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhSachChon_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // nhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 775);
            this.Controls.Add(this.panel_Chon);
            this.Controls.Add(this.panel_timKiem);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "nhapHang";
            this.Text = "nhapHang";
            this.Load += new System.EventHandler(this.nhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).EndInit();
            this.panel_timKiem.ResumeLayout(false);
            this.panel_timKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_Chon.ResumeLayout(false);
            this.panel_Chon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_catNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_danhSachSanPham;
        private System.Windows.Forms.Panel panel_timKiem;
        private System.Windows.Forms.Panel panel_Chon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox textBox_timKiem;
        private System.Windows.Forms.Button btn_nhapHang;
        private System.Windows.Forms.DataGridView dataGridView_danhSachChon;
        private System.Windows.Forms.Label label_tongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_catNhat;
        private System.Windows.Forms.NumericUpDown numericUpDown_catNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}