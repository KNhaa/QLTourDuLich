
namespace GUI_PresentationLayer
{
    partial class Form_ChiTietTour
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
            this.lb_MaTour = new System.Windows.Forms.Label();
            this.lb_TenTour = new System.Windows.Forms.Label();
            this.lb_KhachSan = new System.Windows.Forms.Label();
            this.lb_DacDiem = new System.Windows.Forms.Label();
            this.lb_NoiDung = new System.Windows.Forms.Label();
            this.lb_LoaiHinh = new System.Windows.Forms.Label();
            this.lb_GiaThanh = new System.Windows.Forms.Label();
            this.data_GiaTour = new System.Windows.Forms.DataGridView();
            this.col_NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_DiaDiem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ThemGia = new System.Windows.Forms.Button();
            this.lb_ThemDiaDiem = new System.Windows.Forms.Button();
            this.col_DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_GiaTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaTour
            // 
            this.lb_MaTour.AutoSize = true;
            this.lb_MaTour.Location = new System.Drawing.Point(38, 49);
            this.lb_MaTour.Name = "lb_MaTour";
            this.lb_MaTour.Size = new System.Drawing.Size(74, 20);
            this.lb_MaTour.TabIndex = 0;
            this.lb_MaTour.Text = "Mã Tour : ";
            this.lb_MaTour.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_TenTour
            // 
            this.lb_TenTour.AutoSize = true;
            this.lb_TenTour.Location = new System.Drawing.Point(192, 49);
            this.lb_TenTour.Name = "lb_TenTour";
            this.lb_TenTour.Size = new System.Drawing.Size(76, 20);
            this.lb_TenTour.TabIndex = 1;
            this.lb_TenTour.Text = "Tên Tour : ";
            this.lb_TenTour.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lb_KhachSan
            // 
            this.lb_KhachSan.AutoSize = true;
            this.lb_KhachSan.Location = new System.Drawing.Point(499, 49);
            this.lb_KhachSan.Name = "lb_KhachSan";
            this.lb_KhachSan.Size = new System.Drawing.Size(88, 20);
            this.lb_KhachSan.TabIndex = 2;
            this.lb_KhachSan.Text = "Khách Sạn : ";
            // 
            // lb_DacDiem
            // 
            this.lb_DacDiem.AutoSize = true;
            this.lb_DacDiem.Location = new System.Drawing.Point(501, 96);
            this.lb_DacDiem.Name = "lb_DacDiem";
            this.lb_DacDiem.Size = new System.Drawing.Size(86, 20);
            this.lb_DacDiem.TabIndex = 3;
            this.lb_DacDiem.Text = "Đặc Điểm : ";
            // 
            // lb_NoiDung
            // 
            this.lb_NoiDung.AutoSize = true;
            this.lb_NoiDung.Location = new System.Drawing.Point(38, 151);
            this.lb_NoiDung.Name = "lb_NoiDung";
            this.lb_NoiDung.Size = new System.Drawing.Size(84, 20);
            this.lb_NoiDung.TabIndex = 4;
            this.lb_NoiDung.Text = "Nội Dung : ";
            // 
            // lb_LoaiHinh
            // 
            this.lb_LoaiHinh.AutoSize = true;
            this.lb_LoaiHinh.Location = new System.Drawing.Point(38, 96);
            this.lb_LoaiHinh.Name = "lb_LoaiHinh";
            this.lb_LoaiHinh.Size = new System.Drawing.Size(133, 20);
            this.lb_LoaiHinh.TabIndex = 5;
            this.lb_LoaiHinh.Text = "Loại hình du dịch : ";
            this.lb_LoaiHinh.Click += new System.EventHandler(this.lb_LoaiHinh_Click);
            // 
            // lb_GiaThanh
            // 
            this.lb_GiaThanh.AutoSize = true;
            this.lb_GiaThanh.Location = new System.Drawing.Point(39, 202);
            this.lb_GiaThanh.Name = "lb_GiaThanh";
            this.lb_GiaThanh.Size = new System.Drawing.Size(42, 20);
            this.lb_GiaThanh.TabIndex = 6;
            this.lb_GiaThanh.Text = "Giá : ";
            // 
            // data_GiaTour
            // 
            this.data_GiaTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_GiaTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_GiaTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_GiaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GiaTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NgayKhoiHanh,
            this.lb_NgayKetThuc,
            this.lb_GiaTien});
            this.data_GiaTour.Location = new System.Drawing.Point(38, 245);
            this.data_GiaTour.Name = "data_GiaTour";
            this.data_GiaTour.ReadOnly = true;
            this.data_GiaTour.RowHeadersWidth = 51;
            this.data_GiaTour.RowTemplate.Height = 29;
            this.data_GiaTour.Size = new System.Drawing.Size(891, 153);
            this.data_GiaTour.TabIndex = 8;
            this.data_GiaTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GiaTour_CellContentClick);
            // 
            // col_NgayKhoiHanh
            // 
            this.col_NgayKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.col_NgayKhoiHanh.MinimumWidth = 6;
            this.col_NgayKhoiHanh.Name = "col_NgayKhoiHanh";
            this.col_NgayKhoiHanh.ReadOnly = true;
            // 
            // lb_NgayKetThuc
            // 
            this.lb_NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.lb_NgayKetThuc.MinimumWidth = 6;
            this.lb_NgayKetThuc.Name = "lb_NgayKetThuc";
            this.lb_NgayKetThuc.ReadOnly = true;
            // 
            // lb_GiaTien
            // 
            this.lb_GiaTien.HeaderText = "GIá Tiền";
            this.lb_GiaTien.MinimumWidth = 6;
            this.lb_GiaTien.Name = "lb_GiaTien";
            this.lb_GiaTien.ReadOnly = true;
            // 
            // lb_DiaDiem
            // 
            this.lb_DiaDiem.AutoSize = true;
            this.lb_DiaDiem.Location = new System.Drawing.Point(38, 411);
            this.lb_DiaDiem.Name = "lb_DiaDiem";
            this.lb_DiaDiem.Size = new System.Drawing.Size(159, 20);
            this.lb_DiaDiem.TabIndex = 9;
            this.lb_DiaDiem.Text = "Địa Điểm Tham Quan :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DiaDiem,
            this.col_ThuTu});
            this.dataGridView1.Location = new System.Drawing.Point(38, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(891, 188);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ThemGia
            // 
            this.btn_ThemGia.Location = new System.Drawing.Point(899, 209);
            this.btn_ThemGia.Name = "btn_ThemGia";
            this.btn_ThemGia.Size = new System.Drawing.Size(30, 30);
            this.btn_ThemGia.TabIndex = 11;
            this.btn_ThemGia.Text = "+";
            this.btn_ThemGia.UseVisualStyleBackColor = true;
            this.btn_ThemGia.Click += new System.EventHandler(this.btn_ThemGia_Click);
            // 
            // lb_ThemDiaDiem
            // 
            this.lb_ThemDiaDiem.Location = new System.Drawing.Point(899, 411);
            this.lb_ThemDiaDiem.Name = "lb_ThemDiaDiem";
            this.lb_ThemDiaDiem.Size = new System.Drawing.Size(30, 30);
            this.lb_ThemDiaDiem.TabIndex = 12;
            this.lb_ThemDiaDiem.Text = "+";
            this.lb_ThemDiaDiem.UseVisualStyleBackColor = true;
            this.lb_ThemDiaDiem.Click += new System.EventHandler(this.lb_ThemDiaDiem_Click);
            // 
            // col_DiaDiem
            // 
            this.col_DiaDiem.HeaderText = "Tên Địa Điểm";
            this.col_DiaDiem.MinimumWidth = 6;
            this.col_DiaDiem.Name = "col_DiaDiem";
            this.col_DiaDiem.Width = 615;
            // 
            // col_ThuTu
            // 
            this.col_ThuTu.HeaderText = "Thứ Tự Tham Quan";
            this.col_ThuTu.MinimumWidth = 6;
            this.col_ThuTu.Name = "col_ThuTu";
            this.col_ThuTu.Width = 223;
            // 
            // Form_ChiTietTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 744);
            this.Controls.Add(this.lb_ThemDiaDiem);
            this.Controls.Add(this.btn_ThemGia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_DiaDiem);
            this.Controls.Add(this.data_GiaTour);
            this.Controls.Add(this.lb_GiaThanh);
            this.Controls.Add(this.lb_LoaiHinh);
            this.Controls.Add(this.lb_NoiDung);
            this.Controls.Add(this.lb_DacDiem);
            this.Controls.Add(this.lb_KhachSan);
            this.Controls.Add(this.lb_TenTour);
            this.Controls.Add(this.lb_MaTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_ChiTietTour";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Tour";
            this.Load += new System.EventHandler(this.Form_ChiTietTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GiaTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MaTour;
        private System.Windows.Forms.Label lb_TenTour;
        private System.Windows.Forms.Label lb_KhachSan;
        private System.Windows.Forms.Label lb_DacDiem;
        private System.Windows.Forms.Label lb_NoiDung;
        private System.Windows.Forms.Label lb_LoaiHinh;
        private System.Windows.Forms.Label lb_GiaThanh;
        private System.Windows.Forms.DataGridView data_GiaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lb_NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lb_GiaTien;
        private System.Windows.Forms.Label lb_DiaDiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ThemGia;
        private System.Windows.Forms.Button lb_ThemDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThuTu;
    }
}