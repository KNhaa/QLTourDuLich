
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
            ((System.ComponentModel.ISupportInitialize)(this.data_GiaTour)).BeginInit();
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
            this.lb_TenTour.Location = new System.Drawing.Point(379, 49);
            this.lb_TenTour.Name = "lb_TenTour";
            this.lb_TenTour.Size = new System.Drawing.Size(76, 20);
            this.lb_TenTour.TabIndex = 1;
            this.lb_TenTour.Text = "Tên Tour : ";
            this.lb_TenTour.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lb_KhachSan
            // 
            this.lb_KhachSan.AutoSize = true;
            this.lb_KhachSan.Location = new System.Drawing.Point(38, 100);
            this.lb_KhachSan.Name = "lb_KhachSan";
            this.lb_KhachSan.Size = new System.Drawing.Size(88, 20);
            this.lb_KhachSan.TabIndex = 2;
            this.lb_KhachSan.Text = "Khách Sạn : ";
            // 
            // lb_DacDiem
            // 
            this.lb_DacDiem.AutoSize = true;
            this.lb_DacDiem.Location = new System.Drawing.Point(379, 100);
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
            this.lb_LoaiHinh.Location = new System.Drawing.Point(38, 206);
            this.lb_LoaiHinh.Name = "lb_LoaiHinh";
            this.lb_LoaiHinh.Size = new System.Drawing.Size(133, 20);
            this.lb_LoaiHinh.TabIndex = 5;
            this.lb_LoaiHinh.Text = "Loại hình du dịch : ";
            this.lb_LoaiHinh.Click += new System.EventHandler(this.lb_LoaiHinh_Click);
            // 
            // lb_GiaThanh
            // 
            this.lb_GiaThanh.AutoSize = true;
            this.lb_GiaThanh.Location = new System.Drawing.Point(39, 258);
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
            this.data_GiaTour.Location = new System.Drawing.Point(39, 290);
            this.data_GiaTour.Name = "data_GiaTour";
            this.data_GiaTour.ReadOnly = true;
            this.data_GiaTour.RowHeadersWidth = 51;
            this.data_GiaTour.RowTemplate.Height = 29;
            this.data_GiaTour.Size = new System.Drawing.Size(730, 153);
            this.data_GiaTour.TabIndex = 8;
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
            // Form_ChiTietTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
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
    }
}