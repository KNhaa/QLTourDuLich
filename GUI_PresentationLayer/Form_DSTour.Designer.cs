
namespace GUI_PresentationLayer
{
    partial class Form_DSTour
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TiemKiem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_TenTour = new System.Windows.Forms.Label();
            this.tb__TenTour = new System.Windows.Forms.TextBox();
            this.lb_TenKhachSan = new System.Windows.Forms.Label();
            this.tb_TenKhachSan = new System.Windows.Forms.TextBox();
            this.tb_DacDiem = new System.Windows.Forms.TextBox();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.lb_DacDiem = new System.Windows.Forms.Label();
            this.lb_LoaiHinh = new System.Windows.Forms.Label();
            this.lb_NoiDung = new System.Windows.Forms.Label();
            this.cb_LoaiHinh = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_2,
            this.col_3,
            this.col_4,
            this.col_5});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(32, 235);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(766, 279);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_2
            // 
            this.col_2.HeaderText = "Tên Tour";
            this.col_2.MinimumWidth = 6;
            this.col_2.Name = "col_2";
            this.col_2.ReadOnly = true;
            // 
            // col_3
            // 
            this.col_3.HeaderText = "Khách Sạn";
            this.col_3.MinimumWidth = 6;
            this.col_3.Name = "col_3";
            this.col_3.ReadOnly = true;
            // 
            // col_4
            // 
            this.col_4.HeaderText = "Nội Dung";
            this.col_4.MinimumWidth = 6;
            this.col_4.Name = "col_4";
            this.col_4.ReadOnly = true;
            // 
            // col_5
            // 
            this.col_5.HeaderText = "Đặc Điểm";
            this.col_5.MinimumWidth = 6;
            this.col_5.Name = "col_5";
            this.col_5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH TOUR";
            // 
            // tb_TiemKiem
            // 
            this.tb_TiemKiem.Location = new System.Drawing.Point(563, 193);
            this.tb_TiemKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TiemKiem.Multiline = true;
            this.tb_TiemKiem.Name = "tb_TiemKiem";
            this.tb_TiemKiem.Size = new System.Drawing.Size(236, 26);
            this.tb_TiemKiem.TabIndex = 18;
            this.tb_TiemKiem.TextChanged += new System.EventHandler(this.tb_TiemKiem_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(32, 193);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(91, 25);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // lb_TenTour
            // 
            this.lb_TenTour.AutoSize = true;
            this.lb_TenTour.Location = new System.Drawing.Point(32, 68);
            this.lb_TenTour.Name = "lb_TenTour";
            this.lb_TenTour.Size = new System.Drawing.Size(57, 15);
            this.lb_TenTour.TabIndex = 21;
            this.lb_TenTour.Text = "Tên Tour :";
            // 
            // tb__TenTour
            // 
            this.tb__TenTour.Location = new System.Drawing.Point(32, 96);
            this.tb__TenTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb__TenTour.Name = "tb__TenTour";
            this.tb__TenTour.Size = new System.Drawing.Size(210, 23);
            this.tb__TenTour.TabIndex = 22;
            // 
            // lb_TenKhachSan
            // 
            this.lb_TenKhachSan.AutoSize = true;
            this.lb_TenKhachSan.Location = new System.Drawing.Point(32, 121);
            this.lb_TenKhachSan.Name = "lb_TenKhachSan";
            this.lb_TenKhachSan.Size = new System.Drawing.Size(89, 15);
            this.lb_TenKhachSan.TabIndex = 23;
            this.lb_TenKhachSan.Text = "Tên Khách Sạn :";
            // 
            // tb_TenKhachSan
            // 
            this.tb_TenKhachSan.Location = new System.Drawing.Point(32, 144);
            this.tb_TenKhachSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenKhachSan.Name = "tb_TenKhachSan";
            this.tb_TenKhachSan.Size = new System.Drawing.Size(210, 23);
            this.tb_TenKhachSan.TabIndex = 24;
            // 
            // tb_DacDiem
            // 
            this.tb_DacDiem.Location = new System.Drawing.Point(302, 96);
            this.tb_DacDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_DacDiem.Name = "tb_DacDiem";
            this.tb_DacDiem.Size = new System.Drawing.Size(204, 23);
            this.tb_DacDiem.TabIndex = 25;
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(563, 96);
            this.tb_NoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.Size = new System.Drawing.Size(236, 69);
            this.tb_NoiDung.TabIndex = 26;
            // 
            // lb_DacDiem
            // 
            this.lb_DacDiem.AutoSize = true;
            this.lb_DacDiem.Location = new System.Drawing.Point(302, 71);
            this.lb_DacDiem.Name = "lb_DacDiem";
            this.lb_DacDiem.Size = new System.Drawing.Size(64, 15);
            this.lb_DacDiem.TabIndex = 27;
            this.lb_DacDiem.Text = "Đặc Điểm :";
            // 
            // lb_LoaiHinh
            // 
            this.lb_LoaiHinh.AutoSize = true;
            this.lb_LoaiHinh.Location = new System.Drawing.Point(304, 121);
            this.lb_LoaiHinh.Name = "lb_LoaiHinh";
            this.lb_LoaiHinh.Size = new System.Drawing.Size(64, 15);
            this.lb_LoaiHinh.TabIndex = 28;
            this.lb_LoaiHinh.Text = "Loại Hình :";
            // 
            // lb_NoiDung
            // 
            this.lb_NoiDung.AutoSize = true;
            this.lb_NoiDung.Location = new System.Drawing.Point(563, 71);
            this.lb_NoiDung.Name = "lb_NoiDung";
            this.lb_NoiDung.Size = new System.Drawing.Size(64, 15);
            this.lb_NoiDung.TabIndex = 29;
            this.lb_NoiDung.Text = "Nội Dung :";
            // 
            // cb_LoaiHinh
            // 
            this.cb_LoaiHinh.FormattingEnabled = true;
            this.cb_LoaiHinh.Location = new System.Drawing.Point(304, 143);
            this.cb_LoaiHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_LoaiHinh.Name = "cb_LoaiHinh";
            this.cb_LoaiHinh.Size = new System.Drawing.Size(204, 23);
            this.cb_LoaiHinh.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 32;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_DSTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 523);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_LoaiHinh);
            this.Controls.Add(this.lb_NoiDung);
            this.Controls.Add(this.lb_LoaiHinh);
            this.Controls.Add(this.lb_DacDiem);
            this.Controls.Add(this.tb_NoiDung);
            this.Controls.Add(this.tb_DacDiem);
            this.Controls.Add(this.tb_TenKhachSan);
            this.Controls.Add(this.lb_TenKhachSan);
            this.Controls.Add(this.tb__TenTour);
            this.Controls.Add(this.lb_TenTour);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_TiemKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_DSTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tour";
            this.Load += new System.EventHandler(this.Form_DSTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TiemKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_TenTour;
        private System.Windows.Forms.TextBox tb__TenTour;
        private System.Windows.Forms.Label lb_TenKhachSan;
        private System.Windows.Forms.TextBox tb_TenKhachSan;
        private System.Windows.Forms.TextBox tb_DacDiem;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Label lb_DacDiem;
        private System.Windows.Forms.Label lb_LoaiHinh;
        private System.Windows.Forms.Label lb_NoiDung;
        private System.Windows.Forms.ComboBox cb_LoaiHinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}