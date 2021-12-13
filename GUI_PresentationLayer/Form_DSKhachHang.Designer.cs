
namespace GUI_PresentationLayer
{
    partial class Form_DSKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGVKhachHang = new System.Windows.Forms.DataGridView();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVKhachHang
            // 
            this.dataGVKhachHang.AllowUserToAddRows = false;
            this.dataGVKhachHang.AllowUserToDeleteRows = false;
            this.dataGVKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGVKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGVKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGVKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.DiaChi,
            this.CMND,
            this.GioiTinh,
            this.SDT,
            this.QuocTich,
            this.chitiets});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVKhachHang.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGVKhachHang.Location = new System.Drawing.Point(8, 224);
            this.dataGVKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVKhachHang.Name = "dataGVKhachHang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVKhachHang.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGVKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGVKhachHang.RowTemplate.Height = 33;
            this.dataGVKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGVKhachHang.Size = new System.Drawing.Size(822, 257);
            this.dataGVKhachHang.TabIndex = 0;
            this.dataGVKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVKhachHang_CellClick);
            this.dataGVKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVKhachHang_CellContentClick);
            // 
            // lbHoTen
            // 
            this.lbHoTen.Location = new System.Drawing.Point(8, 61);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 28);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên";
            this.lbHoTen.Click += new System.EventHandler(this.lbHoTen_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(396, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "CMND";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(396, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "SĐT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(396, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quốc tịch";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(106, 58);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(215, 29);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(500, 58);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(215, 29);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(106, 116);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(215, 29);
            this.txtCMND.TabIndex = 9;
            this.txtCMND.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(106, 163);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(215, 29);
            this.txtSDT.TabIndex = 11;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(500, 163);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuocTich.Multiline = true;
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(215, 29);
            this.txtQuocTich.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 491);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(290, 491);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 29);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Cập nhập";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(552, 491);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 29);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(424, 491);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(409, 2);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 28);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Location = new System.Drawing.Point(613, 2);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 28);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.ItemHeight = 15;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(500, 113);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(215, 23);
            this.cbGioiTinh.TabIndex = 19;
            this.cbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbGioiTinh_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(720, 2);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(78, 28);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKH.DataPropertyName = "maKh";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            this.MaKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaKH.FillWeight = 150F;
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 107;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoTen.DataPropertyName = "tenKh";
            this.HoTen.HeaderText = "Họ và tên ";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 79;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiaChi.DataPropertyName = "diaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 49;
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CMND.DataPropertyName = "cnmd";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 8;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 68;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioiTinh.DataPropertyName = "gioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 71;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDT.DataPropertyName = "sdt";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 52;
            // 
            // QuocTich
            // 
            this.QuocTich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuocTich.DataPropertyName = "quocTich";
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.MinimumWidth = 8;
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.ReadOnly = true;
            this.QuocTich.Width = 78;
            // 
            // chitiets
            // 
            this.chitiets.DataPropertyName = "ChiTiets";
            this.chitiets.HeaderText = "Chi tiết ";
            this.chitiets.MinimumWidth = 8;
            this.chitiets.Name = "chitiets";
            this.chitiets.Visible = false;
            this.chitiets.Width = 8;
            // 
            // Form_DSKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 523);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuocTich);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.dataGVKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_DSKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.Form_DSKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVKhachHang;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn chitiets;
    }
}