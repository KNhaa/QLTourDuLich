
namespace GUI_PresentationLayer
{
    partial class Form_KhachHangDoan
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
            this.dataGVKhachDoan = new System.Windows.Forms.DataGridView();
            this.MaDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKhachDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVKhachDoan
            // 
            this.dataGVKhachDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKhachDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoan,
            this.NgayKH,
            this.NgayKT,
            this.DoanhThu,
            this.maTour,
            this.Tour,
            this.ChiPhis,
            this.ChiTiet,
            this.PhanBo});
            this.dataGVKhachDoan.Location = new System.Drawing.Point(409, 341);
            this.dataGVKhachDoan.Name = "dataGVKhachDoan";
            this.dataGVKhachDoan.RowHeadersWidth = 62;
            this.dataGVKhachDoan.RowTemplate.Height = 33;
            this.dataGVKhachDoan.Size = new System.Drawing.Size(667, 375);
            this.dataGVKhachDoan.TabIndex = 0;
            this.dataGVKhachDoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVKhachDoan_CellClick);
            this.dataGVKhachDoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaDoan
            // 
            this.MaDoan.DataPropertyName = "maDoan";
            this.MaDoan.HeaderText = "Mã Đoàn";
            this.MaDoan.MinimumWidth = 8;
            this.MaDoan.Name = "MaDoan";
            this.MaDoan.ReadOnly = true;
            this.MaDoan.Width = 150;
            // 
            // NgayKH
            // 
            this.NgayKH.DataPropertyName = "ngayKhoiHanh";
            this.NgayKH.HeaderText = "Ngày khởi hành";
            this.NgayKH.MinimumWidth = 8;
            this.NgayKH.Name = "NgayKH";
            this.NgayKH.ReadOnly = true;
            this.NgayKH.Width = 150;
            // 
            // NgayKT
            // 
            this.NgayKT.DataPropertyName = "ngayKetThuc";
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.MinimumWidth = 8;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.ReadOnly = true;
            this.NgayKT.Width = 150;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "doanhThu";
            this.DoanhThu.HeaderText = "Doanh thu";
            this.DoanhThu.MinimumWidth = 8;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            this.DoanhThu.Width = 150;
            // 
            // maTour
            // 
            this.maTour.DataPropertyName = "maTour";
            this.maTour.HeaderText = "Mã tour";
            this.maTour.MinimumWidth = 8;
            this.maTour.Name = "maTour";
            this.maTour.Visible = false;
            this.maTour.Width = 150;
            // 
            // Tour
            // 
            this.Tour.DataPropertyName = "Tour";
            this.Tour.HeaderText = "Tour";
            this.Tour.MinimumWidth = 8;
            this.Tour.Name = "Tour";
            this.Tour.Visible = false;
            this.Tour.Width = 150;
            // 
            // ChiPhis
            // 
            this.ChiPhis.DataPropertyName = "ChiPhis";
            this.ChiPhis.HeaderText = "Chi Phí";
            this.ChiPhis.MinimumWidth = 8;
            this.ChiPhis.Name = "ChiPhis";
            this.ChiPhis.Visible = false;
            this.ChiPhis.Width = 150;
            // 
            // ChiTiet
            // 
            this.ChiTiet.DataPropertyName = "ChiTiets";
            this.ChiTiet.HeaderText = "CHi tiết";
            this.ChiTiet.MinimumWidth = 8;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Visible = false;
            this.ChiTiet.Width = 150;
            // 
            // PhanBo
            // 
            this.PhanBo.DataPropertyName = "PhanBos";
            this.PhanBo.HeaderText = "PhanBos";
            this.PhanBo.MinimumWidth = 8;
            this.PhanBo.Name = "PhanBo";
            this.PhanBo.Visible = false;
            this.PhanBo.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(648, 749);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(208, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày Khởi hành";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(208, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày kết thúc";
            // 
            // dtNgayKhoiHanh
            // 
            this.dtNgayKhoiHanh.Location = new System.Drawing.Point(513, 80);
            this.dtNgayKhoiHanh.Name = "dtNgayKhoiHanh";
            this.dtNgayKhoiHanh.Size = new System.Drawing.Size(334, 31);
            this.dtNgayKhoiHanh.TabIndex = 5;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Location = new System.Drawing.Point(513, 159);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(334, 31);
            this.dtNgayKetThuc.TabIndex = 6;
            // 
            // Form_KhachHangDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 871);
            this.Controls.Add(this.dtNgayKetThuc);
            this.Controls.Add(this.dtNgayKhoiHanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGVKhachDoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_KhachHangDoan";
            this.Text = "Form_KhachHangDoan";
            this.Load += new System.EventHandler(this.Form_KhachHangDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKhachDoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVKhachDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanBo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayKhoiHanh;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
    }
}