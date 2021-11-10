
namespace GUI_PresentationLayer
{
    partial class Form_ThemGia
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
            this.lb_Header = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_NgayKhoiHanh = new System.Windows.Forms.Label();
            this.lb_NgayKetThuc = new System.Windows.Forms.Label();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.data_GiaTour = new System.Windows.Forms.DataGridView();
            this.col_NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_GiaTour)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(364, 29);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(138, 37);
            this.lb_Header.TabIndex = 6;
            this.lb_Header.Text = "THÊM GIÁ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(594, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(594, 185);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(594, 233);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(250, 27);
            this.tb_Gia.TabIndex = 9;
            this.tb_Gia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(264, 287);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_NgayKhoiHanh
            // 
            this.lb_NgayKhoiHanh.AutoSize = true;
            this.lb_NgayKhoiHanh.Location = new System.Drawing.Point(468, 130);
            this.lb_NgayKhoiHanh.Name = "lb_NgayKhoiHanh";
            this.lb_NgayKhoiHanh.Size = new System.Drawing.Size(120, 20);
            this.lb_NgayKhoiHanh.TabIndex = 11;
            this.lb_NgayKhoiHanh.Text = "Ngày Khởi Hành:";
            this.lb_NgayKhoiHanh.Click += new System.EventHandler(this.lb_NgayKhoiHanh_Click);
            // 
            // lb_NgayKetThuc
            // 
            this.lb_NgayKetThuc.AutoSize = true;
            this.lb_NgayKetThuc.Location = new System.Drawing.Point(468, 185);
            this.lb_NgayKetThuc.Name = "lb_NgayKetThuc";
            this.lb_NgayKetThuc.Size = new System.Drawing.Size(108, 20);
            this.lb_NgayKetThuc.TabIndex = 12;
            this.lb_NgayKetThuc.Text = "Ngày Kết Thúc:";
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Location = new System.Drawing.Point(468, 236);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(34, 20);
            this.lb_Gia.TabIndex = 13;
            this.lb_Gia.Text = "Giá:";
            // 
            // data_GiaTour
            // 
            this.data_GiaTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_GiaTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_GiaTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_GiaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GiaTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NgayKhoiHanh,
            this.dataGridViewTextBoxColumn1,
            this.lb_GiaTien});
            this.data_GiaTour.Location = new System.Drawing.Point(30, 112);
            this.data_GiaTour.Name = "data_GiaTour";
            this.data_GiaTour.ReadOnly = true;
            this.data_GiaTour.RowHeadersWidth = 51;
            this.data_GiaTour.RowTemplate.Height = 29;
            this.data_GiaTour.Size = new System.Drawing.Size(413, 144);
            this.data_GiaTour.TabIndex = 14;
            this.data_GiaTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GiaTour_CellClick);
            // 
            // col_NgayKhoiHanh
            // 
            this.col_NgayKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.col_NgayKhoiHanh.MinimumWidth = 6;
            this.col_NgayKhoiHanh.Name = "col_NgayKhoiHanh";
            this.col_NgayKhoiHanh.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ngày Kết Thúc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lb_GiaTien
            // 
            this.lb_GiaTien.HeaderText = "GIá Tiền";
            this.lb_GiaTien.MinimumWidth = 6;
            this.lb_GiaTien.Name = "lb_GiaTien";
            this.lb_GiaTien.ReadOnly = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(395, 287);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(523, 287);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(94, 29);
            this.btn_CapNhat.TabIndex = 16;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // Form_ThemGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 344);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.data_GiaTour);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_NgayKetThuc);
            this.Controls.Add(this.lb_NgayKhoiHanh);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_Header);
            this.Name = "Form_ThemGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThemGia";
            this.Load += new System.EventHandler(this.Form_ThemGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GiaTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_NgayKhoiHanh;
        private System.Windows.Forms.Label lb_NgayKetThuc;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.DataGridView data_GiaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lb_GiaTien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
    }
}