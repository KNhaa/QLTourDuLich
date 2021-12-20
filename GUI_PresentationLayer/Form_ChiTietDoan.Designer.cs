
namespace GUI_PresentationLayer
{
    partial class Form_ChiTietDoan
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbMadoan = new System.Windows.Forms.Label();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.lbNgkhoihanh = new System.Windows.Forms.Label();
            this.lnNgketthuc = new System.Windows.Forms.Label();
            this.lbDoanhthu = new System.Windows.Forms.Label();
            this.lbSlkhach = new System.Windows.Forms.Label();
            this.tabThongTin = new System.Windows.Forms.TabControl();
            this.tabDiaDiem = new System.Windows.Forms.TabPage();
            this.dgvDiaDiem = new System.Windows.Forms.DataGridView();
            this.col_Tendiadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Thutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKhach = new System.Windows.Forms.TabPage();
            this.btnXoaK = new System.Windows.Forms.Button();
            this.btnThemkhach = new System.Windows.Forms.Button();
            this.btnNewkhach = new System.Windows.Forms.Button();
            this.cbxKhach = new System.Windows.Forms.ComboBox();
            this.lbThemkhach = new System.Windows.Forms.Label();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.col_Tenkhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChiPhi = new System.Windows.Forms.TabPage();
            this.btnXoaCP = new System.Windows.Forms.Button();
            this.lbLoaiCP = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnThemchiphi = new System.Windows.Forms.Button();
            this.cbxLoaiChiphi = new System.Windows.Forms.ComboBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.dgvChiPhi = new System.Windows.Forms.DataGridView();
            this.col_Chiphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Loaichiphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.lbNhiemVu = new System.Windows.Forms.Label();
            this.txtNhiemVu = new System.Windows.Forms.TextBox();
            this.btnThemnhanvien = new System.Windows.Forms.Button();
            this.btnNewnhanvien = new System.Windows.Forms.Button();
            this.cbxNhanvien = new System.Windows.Forms.ComboBox();
            this.lbThemnhanvien = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.col_maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nhiemvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtMadoan = new System.Windows.Forms.Label();
            this.lbtNgketthuc = new System.Windows.Forms.Label();
            this.lbtNgkhoihanh = new System.Windows.Forms.Label();
            this.lbtDoanhthu = new System.Windows.Forms.Label();
            this.lbtSoluongkhach = new System.Windows.Forms.Label();
            this.lbtTenTour = new System.Windows.Forms.Label();
            this.lbtGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabThongTin.SuspendLayout();
            this.tabDiaDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).BeginInit();
            this.tabKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tabChiPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(414, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(207, 38);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "CHI TIẾT ĐOÀN";
            // 
            // lbMadoan
            // 
            this.lbMadoan.AutoSize = true;
            this.lbMadoan.Location = new System.Drawing.Point(87, 113);
            this.lbMadoan.Name = "lbMadoan";
            this.lbMadoan.Size = new System.Drawing.Size(75, 20);
            this.lbMadoan.TabIndex = 1;
            this.lbMadoan.Text = "Mã đoàn :";
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Location = new System.Drawing.Point(87, 173);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(70, 20);
            this.lbTenTour.TabIndex = 2;
            this.lbTenTour.Text = "Tên tour :";
            // 
            // lbNgkhoihanh
            // 
            this.lbNgkhoihanh.AutoSize = true;
            this.lbNgkhoihanh.Location = new System.Drawing.Point(333, 111);
            this.lbNgkhoihanh.Name = "lbNgkhoihanh";
            this.lbNgkhoihanh.Size = new System.Drawing.Size(119, 20);
            this.lbNgkhoihanh.TabIndex = 3;
            this.lbNgkhoihanh.Text = "Ngày khởi hành :";
            // 
            // lnNgketthuc
            // 
            this.lnNgketthuc.AutoSize = true;
            this.lnNgketthuc.Location = new System.Drawing.Point(643, 113);
            this.lnNgketthuc.Name = "lnNgketthuc";
            this.lnNgketthuc.Size = new System.Drawing.Size(107, 20);
            this.lnNgketthuc.TabIndex = 4;
            this.lnNgketthuc.Text = "Ngày kết thúc :";
            // 
            // lbDoanhthu
            // 
            this.lbDoanhthu.AutoSize = true;
            this.lbDoanhthu.Location = new System.Drawing.Point(333, 244);
            this.lbDoanhthu.Name = "lbDoanhthu";
            this.lbDoanhthu.Size = new System.Drawing.Size(85, 20);
            this.lbDoanhthu.TabIndex = 5;
            this.lbDoanhthu.Text = "Doanh thu :";
            // 
            // lbSlkhach
            // 
            this.lbSlkhach.AutoSize = true;
            this.lbSlkhach.Location = new System.Drawing.Point(87, 243);
            this.lbSlkhach.Name = "lbSlkhach";
            this.lbSlkhach.Size = new System.Drawing.Size(118, 20);
            this.lbSlkhach.TabIndex = 6;
            this.lbSlkhach.Text = "Số lượng khách :";
            // 
            // tabThongTin
            // 
            this.tabThongTin.Controls.Add(this.tabDiaDiem);
            this.tabThongTin.Controls.Add(this.tabKhach);
            this.tabThongTin.Controls.Add(this.tabChiPhi);
            this.tabThongTin.Controls.Add(this.tabNhanVien);
            this.tabThongTin.Location = new System.Drawing.Point(39, 290);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.SelectedIndex = 0;
            this.tabThongTin.Size = new System.Drawing.Size(1004, 375);
            this.tabThongTin.TabIndex = 17;
            this.tabThongTin.SelectedIndexChanged += new System.EventHandler(this.tabThongTin_SelectedIndexChanged);
            // 
            // tabDiaDiem
            // 
            this.tabDiaDiem.Controls.Add(this.dgvDiaDiem);
            this.tabDiaDiem.Location = new System.Drawing.Point(4, 29);
            this.tabDiaDiem.Name = "tabDiaDiem";
            this.tabDiaDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiaDiem.Size = new System.Drawing.Size(996, 342);
            this.tabDiaDiem.TabIndex = 0;
            this.tabDiaDiem.Text = "Địa điểm";
            this.tabDiaDiem.UseVisualStyleBackColor = true;
            // 
            // dgvDiaDiem
            // 
            this.dgvDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Tendiadiem,
            this.col_Thutu});
            this.dgvDiaDiem.Location = new System.Drawing.Point(3, 3);
            this.dgvDiaDiem.Name = "dgvDiaDiem";
            this.dgvDiaDiem.RowHeadersWidth = 51;
            this.dgvDiaDiem.RowTemplate.Height = 29;
            this.dgvDiaDiem.Size = new System.Drawing.Size(990, 328);
            this.dgvDiaDiem.TabIndex = 0;
            // 
            // col_Tendiadiem
            // 
            this.col_Tendiadiem.HeaderText = "Địa điểm";
            this.col_Tendiadiem.MinimumWidth = 6;
            this.col_Tendiadiem.Name = "col_Tendiadiem";
            this.col_Tendiadiem.ReadOnly = true;
            // 
            // col_Thutu
            // 
            this.col_Thutu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Thutu.HeaderText = "Thứ tự";
            this.col_Thutu.MinimumWidth = 6;
            this.col_Thutu.Name = "col_Thutu";
            this.col_Thutu.ReadOnly = true;
            this.col_Thutu.Width = 300;
            // 
            // tabKhach
            // 
            this.tabKhach.Controls.Add(this.btnXoaK);
            this.tabKhach.Controls.Add(this.btnThemkhach);
            this.tabKhach.Controls.Add(this.btnNewkhach);
            this.tabKhach.Controls.Add(this.cbxKhach);
            this.tabKhach.Controls.Add(this.lbThemkhach);
            this.tabKhach.Controls.Add(this.dgvKhach);
            this.tabKhach.Location = new System.Drawing.Point(4, 29);
            this.tabKhach.Name = "tabKhach";
            this.tabKhach.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhach.Size = new System.Drawing.Size(996, 342);
            this.tabKhach.TabIndex = 1;
            this.tabKhach.Text = "Khách";
            this.tabKhach.UseVisualStyleBackColor = true;
            // 
            // btnXoaK
            // 
            this.btnXoaK.Location = new System.Drawing.Point(639, 296);
            this.btnXoaK.Name = "btnXoaK";
            this.btnXoaK.Size = new System.Drawing.Size(82, 29);
            this.btnXoaK.TabIndex = 9;
            this.btnXoaK.Text = "Xóa";
            this.btnXoaK.UseVisualStyleBackColor = true;
            this.btnXoaK.Click += new System.EventHandler(this.btnXoaK_Click);
            // 
            // btnThemkhach
            // 
            this.btnThemkhach.Location = new System.Drawing.Point(517, 295);
            this.btnThemkhach.Name = "btnThemkhach";
            this.btnThemkhach.Size = new System.Drawing.Size(94, 29);
            this.btnThemkhach.TabIndex = 4;
            this.btnThemkhach.Text = "Thêm";
            this.btnThemkhach.UseVisualStyleBackColor = true;
            this.btnThemkhach.Click += new System.EventHandler(this.btnThemkhach_Click);
            // 
            // btnNewkhach
            // 
            this.btnNewkhach.AutoSize = true;
            this.btnNewkhach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewkhach.Location = new System.Drawing.Point(440, 293);
            this.btnNewkhach.Name = "btnNewkhach";
            this.btnNewkhach.Size = new System.Drawing.Size(42, 33);
            this.btnNewkhach.TabIndex = 3;
            this.btnNewkhach.Text = "+";
            this.btnNewkhach.UseVisualStyleBackColor = true;
            this.btnNewkhach.Click += new System.EventHandler(this.btnNewkhach_Click);
            // 
            // cbxKhach
            // 
            this.cbxKhach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxKhach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhach.FormattingEnabled = true;
            this.cbxKhach.Location = new System.Drawing.Point(168, 296);
            this.cbxKhach.Name = "cbxKhach";
            this.cbxKhach.Size = new System.Drawing.Size(254, 28);
            this.cbxKhach.TabIndex = 2;
            // 
            // lbThemkhach
            // 
            this.lbThemkhach.AutoSize = true;
            this.lbThemkhach.Location = new System.Drawing.Point(44, 299);
            this.lbThemkhach.Name = "lbThemkhach";
            this.lbThemkhach.Size = new System.Drawing.Size(95, 20);
            this.lbThemkhach.TabIndex = 1;
            this.lbThemkhach.Text = "Thêm khách :";
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Tenkhach,
            this.col_Diachi,
            this.col_Cmnd,
            this.col_Gioitinh,
            this.col_Sodienthoai});
            this.dgvKhach.Location = new System.Drawing.Point(3, 3);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.RowTemplate.Height = 29;
            this.dgvKhach.Size = new System.Drawing.Size(990, 273);
            this.dgvKhach.TabIndex = 0;
            // 
            // col_Tenkhach
            // 
            this.col_Tenkhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Tenkhach.HeaderText = "Tên khách";
            this.col_Tenkhach.MinimumWidth = 6;
            this.col_Tenkhach.Name = "col_Tenkhach";
            this.col_Tenkhach.ReadOnly = true;
            this.col_Tenkhach.Width = 210;
            // 
            // col_Diachi
            // 
            this.col_Diachi.HeaderText = "Địa chỉ";
            this.col_Diachi.MinimumWidth = 6;
            this.col_Diachi.Name = "col_Diachi";
            this.col_Diachi.ReadOnly = true;
            // 
            // col_Cmnd
            // 
            this.col_Cmnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Cmnd.HeaderText = "CMND";
            this.col_Cmnd.MinimumWidth = 6;
            this.col_Cmnd.Name = "col_Cmnd";
            this.col_Cmnd.ReadOnly = true;
            this.col_Cmnd.Width = 140;
            // 
            // col_Gioitinh
            // 
            this.col_Gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Gioitinh.HeaderText = "Giới tính";
            this.col_Gioitinh.MinimumWidth = 6;
            this.col_Gioitinh.Name = "col_Gioitinh";
            this.col_Gioitinh.ReadOnly = true;
            this.col_Gioitinh.Width = 125;
            // 
            // col_Sodienthoai
            // 
            this.col_Sodienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Sodienthoai.HeaderText = "Số điện thoại";
            this.col_Sodienthoai.MinimumWidth = 6;
            this.col_Sodienthoai.Name = "col_Sodienthoai";
            this.col_Sodienthoai.ReadOnly = true;
            this.col_Sodienthoai.Width = 140;
            // 
            // tabChiPhi
            // 
            this.tabChiPhi.Controls.Add(this.btnXoaCP);
            this.tabChiPhi.Controls.Add(this.lbLoaiCP);
            this.tabChiPhi.Controls.Add(this.txtSoTien);
            this.tabChiPhi.Controls.Add(this.btnThemchiphi);
            this.tabChiPhi.Controls.Add(this.cbxLoaiChiphi);
            this.tabChiPhi.Controls.Add(this.lbSoTien);
            this.tabChiPhi.Controls.Add(this.dgvChiPhi);
            this.tabChiPhi.Location = new System.Drawing.Point(4, 29);
            this.tabChiPhi.Name = "tabChiPhi";
            this.tabChiPhi.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiPhi.Size = new System.Drawing.Size(996, 342);
            this.tabChiPhi.TabIndex = 2;
            this.tabChiPhi.Text = "Chi phí";
            this.tabChiPhi.UseVisualStyleBackColor = true;
            // 
            // btnXoaCP
            // 
            this.btnXoaCP.Location = new System.Drawing.Point(866, 293);
            this.btnXoaCP.Name = "btnXoaCP";
            this.btnXoaCP.Size = new System.Drawing.Size(94, 29);
            this.btnXoaCP.TabIndex = 11;
            this.btnXoaCP.Text = "Xóa";
            this.btnXoaCP.UseVisualStyleBackColor = true;
            this.btnXoaCP.Click += new System.EventHandler(this.btnXoaCP_Click);
            // 
            // lbLoaiCP
            // 
            this.lbLoaiCP.AutoSize = true;
            this.lbLoaiCP.Location = new System.Drawing.Point(373, 298);
            this.lbLoaiCP.Name = "lbLoaiCP";
            this.lbLoaiCP.Size = new System.Drawing.Size(92, 20);
            this.lbLoaiCP.TabIndex = 10;
            this.lbLoaiCP.Text = "Loại chi phí :";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(168, 295);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(176, 27);
            this.txtSoTien.TabIndex = 9;
            // 
            // btnThemchiphi
            // 
            this.btnThemchiphi.Location = new System.Drawing.Point(753, 294);
            this.btnThemchiphi.Name = "btnThemchiphi";
            this.btnThemchiphi.Size = new System.Drawing.Size(94, 29);
            this.btnThemchiphi.TabIndex = 8;
            this.btnThemchiphi.Text = "Thêm";
            this.btnThemchiphi.UseVisualStyleBackColor = true;
            this.btnThemchiphi.Click += new System.EventHandler(this.btnThemchiphi_Click);
            // 
            // cbxLoaiChiphi
            // 
            this.cbxLoaiChiphi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLoaiChiphi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLoaiChiphi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiChiphi.FormattingEnabled = true;
            this.cbxLoaiChiphi.Location = new System.Drawing.Point(485, 295);
            this.cbxLoaiChiphi.Name = "cbxLoaiChiphi";
            this.cbxLoaiChiphi.Size = new System.Drawing.Size(233, 28);
            this.cbxLoaiChiphi.TabIndex = 6;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(89, 298);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(62, 20);
            this.lbSoTien.TabIndex = 5;
            this.lbSoTien.Text = "Số tiền :";
            // 
            // dgvChiPhi
            // 
            this.dgvChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Chiphi,
            this.col_Sotien,
            this.col_Loaichiphi});
            this.dgvChiPhi.Location = new System.Drawing.Point(3, 3);
            this.dgvChiPhi.Name = "dgvChiPhi";
            this.dgvChiPhi.RowHeadersWidth = 51;
            this.dgvChiPhi.RowTemplate.Height = 29;
            this.dgvChiPhi.Size = new System.Drawing.Size(990, 273);
            this.dgvChiPhi.TabIndex = 0;
            // 
            // col_Chiphi
            // 
            this.col_Chiphi.HeaderText = "Chi phí";
            this.col_Chiphi.MinimumWidth = 6;
            this.col_Chiphi.Name = "col_Chiphi";
            this.col_Chiphi.ReadOnly = true;
            // 
            // col_Sotien
            // 
            this.col_Sotien.HeaderText = "Số  tiền";
            this.col_Sotien.MinimumWidth = 6;
            this.col_Sotien.Name = "col_Sotien";
            this.col_Sotien.ReadOnly = true;
            // 
            // col_Loaichiphi
            // 
            this.col_Loaichiphi.HeaderText = "Loại chi phí";
            this.col_Loaichiphi.MinimumWidth = 6;
            this.col_Loaichiphi.Name = "col_Loaichiphi";
            this.col_Loaichiphi.ReadOnly = true;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.btnXoaNV);
            this.tabNhanVien.Controls.Add(this.lbNhiemVu);
            this.tabNhanVien.Controls.Add(this.txtNhiemVu);
            this.tabNhanVien.Controls.Add(this.btnThemnhanvien);
            this.tabNhanVien.Controls.Add(this.btnNewnhanvien);
            this.tabNhanVien.Controls.Add(this.cbxNhanvien);
            this.tabNhanVien.Controls.Add(this.lbThemnhanvien);
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 29);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(996, 342);
            this.tabNhanVien.TabIndex = 3;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(884, 292);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(94, 29);
            this.btnXoaNV.TabIndex = 26;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // lbNhiemVu
            // 
            this.lbNhiemVu.AutoSize = true;
            this.lbNhiemVu.Location = new System.Drawing.Point(457, 297);
            this.lbNhiemVu.Name = "lbNhiemVu";
            this.lbNhiemVu.Size = new System.Drawing.Size(79, 20);
            this.lbNhiemVu.TabIndex = 25;
            this.lbNhiemVu.Text = "Nhiệm vụ :";
            // 
            // txtNhiemVu
            // 
            this.txtNhiemVu.Location = new System.Drawing.Point(542, 293);
            this.txtNhiemVu.Name = "txtNhiemVu";
            this.txtNhiemVu.Size = new System.Drawing.Size(210, 27);
            this.txtNhiemVu.TabIndex = 9;
            // 
            // btnThemnhanvien
            // 
            this.btnThemnhanvien.Location = new System.Drawing.Point(784, 293);
            this.btnThemnhanvien.Name = "btnThemnhanvien";
            this.btnThemnhanvien.Size = new System.Drawing.Size(94, 29);
            this.btnThemnhanvien.TabIndex = 8;
            this.btnThemnhanvien.Text = "Thêm";
            this.btnThemnhanvien.UseVisualStyleBackColor = true;
            this.btnThemnhanvien.Click += new System.EventHandler(this.btnThemnhanvien_Click);
            // 
            // btnNewnhanvien
            // 
            this.btnNewnhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewnhanvien.Location = new System.Drawing.Point(400, 292);
            this.btnNewnhanvien.Name = "btnNewnhanvien";
            this.btnNewnhanvien.Size = new System.Drawing.Size(42, 30);
            this.btnNewnhanvien.TabIndex = 7;
            this.btnNewnhanvien.Text = "+";
            this.btnNewnhanvien.UseVisualStyleBackColor = true;
            this.btnNewnhanvien.Click += new System.EventHandler(this.btnNewnhanvien_Click);
            // 
            // cbxNhanvien
            // 
            this.cbxNhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanvien.FormattingEnabled = true;
            this.cbxNhanvien.Location = new System.Drawing.Point(156, 293);
            this.cbxNhanvien.Name = "cbxNhanvien";
            this.cbxNhanvien.Size = new System.Drawing.Size(238, 28);
            this.cbxNhanvien.TabIndex = 6;
            // 
            // lbThemnhanvien
            // 
            this.lbThemnhanvien.AutoSize = true;
            this.lbThemnhanvien.Location = new System.Drawing.Point(44, 296);
            this.lbThemnhanvien.Name = "lbThemnhanvien";
            this.lbThemnhanvien.Size = new System.Drawing.Size(106, 20);
            this.lbThemnhanvien.TabIndex = 5;
            this.lbThemnhanvien.Text = "Tên nhân viên :";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maNhanVien,
            this.col_Tennhanvien,
            this.col_Nhiemvu});
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 3);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 29;
            this.dgvNhanVien.Size = new System.Drawing.Size(990, 273);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // col_maNhanVien
            // 
            this.col_maNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_maNhanVien.HeaderText = "Mã nhân viên";
            this.col_maNhanVien.MinimumWidth = 6;
            this.col_maNhanVien.Name = "col_maNhanVien";
            this.col_maNhanVien.Width = 150;
            // 
            // col_Tennhanvien
            // 
            this.col_Tennhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Tennhanvien.HeaderText = "Tên nhân viên";
            this.col_Tennhanvien.MinimumWidth = 6;
            this.col_Tennhanvien.Name = "col_Tennhanvien";
            this.col_Tennhanvien.ReadOnly = true;
            this.col_Tennhanvien.Width = 300;
            // 
            // col_Nhiemvu
            // 
            this.col_Nhiemvu.HeaderText = "Nhiệm vụ";
            this.col_Nhiemvu.MinimumWidth = 6;
            this.col_Nhiemvu.Name = "col_Nhiemvu";
            this.col_Nhiemvu.ReadOnly = true;
            // 
            // lbtMadoan
            // 
            this.lbtMadoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtMadoan.Location = new System.Drawing.Point(211, 113);
            this.lbtMadoan.Name = "lbtMadoan";
            this.lbtMadoan.Size = new System.Drawing.Size(100, 25);
            this.lbtMadoan.TabIndex = 18;
            // 
            // lbtNgketthuc
            // 
            this.lbtNgketthuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtNgketthuc.Location = new System.Drawing.Point(767, 113);
            this.lbtNgketthuc.Name = "lbtNgketthuc";
            this.lbtNgketthuc.Size = new System.Drawing.Size(140, 20);
            this.lbtNgketthuc.TabIndex = 19;
            // 
            // lbtNgkhoihanh
            // 
            this.lbtNgkhoihanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtNgkhoihanh.Location = new System.Drawing.Point(471, 113);
            this.lbtNgkhoihanh.Name = "lbtNgkhoihanh";
            this.lbtNgkhoihanh.Size = new System.Drawing.Size(140, 20);
            this.lbtNgkhoihanh.TabIndex = 20;
            // 
            // lbtDoanhthu
            // 
            this.lbtDoanhthu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtDoanhthu.Location = new System.Drawing.Point(471, 244);
            this.lbtDoanhthu.Name = "lbtDoanhthu";
            this.lbtDoanhthu.Size = new System.Drawing.Size(140, 20);
            this.lbtDoanhthu.TabIndex = 22;
            // 
            // lbtSoluongkhach
            // 
            this.lbtSoluongkhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtSoluongkhach.Location = new System.Drawing.Point(211, 244);
            this.lbtSoluongkhach.Name = "lbtSoluongkhach";
            this.lbtSoluongkhach.Size = new System.Drawing.Size(100, 20);
            this.lbtSoluongkhach.TabIndex = 23;
            // 
            // lbtTenTour
            // 
            this.lbtTenTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtTenTour.Location = new System.Drawing.Point(211, 173);
            this.lbtTenTour.Name = "lbtTenTour";
            this.lbtTenTour.Size = new System.Drawing.Size(400, 20);
            this.lbtTenTour.TabIndex = 24;
            // 
            // lbtGia
            // 
            this.lbtGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtGia.Location = new System.Drawing.Point(767, 172);
            this.lbtGia.Name = "lbtGia";
            this.lbtGia.Size = new System.Drawing.Size(140, 20);
            this.lbtGia.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giá :";
            // 
            // Form_ChiTietDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.lbtGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtTenTour);
            this.Controls.Add(this.lbtSoluongkhach);
            this.Controls.Add(this.lbtDoanhthu);
            this.Controls.Add(this.lbtNgkhoihanh);
            this.Controls.Add(this.lbtNgketthuc);
            this.Controls.Add(this.lbtMadoan);
            this.Controls.Add(this.tabThongTin);
            this.Controls.Add(this.lbSlkhach);
            this.Controls.Add(this.lbDoanhthu);
            this.Controls.Add(this.lnNgketthuc);
            this.Controls.Add(this.lbNgkhoihanh);
            this.Controls.Add(this.lbTenTour);
            this.Controls.Add(this.lbMadoan);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "Form_ChiTietDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết doàn";
            this.Load += new System.EventHandler(this.Form_ChiTietDoan_Load);
            this.tabThongTin.ResumeLayout(false);
            this.tabDiaDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).EndInit();
            this.tabKhach.ResumeLayout(false);
            this.tabKhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tabChiPhi.ResumeLayout(false);
            this.tabChiPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMadoan;
        private System.Windows.Forms.Label lbTenTour;
        private System.Windows.Forms.Label lbNgkhoihanh;
        private System.Windows.Forms.Label lnNgketthuc;
        private System.Windows.Forms.Label lbDoanhthu;
        private System.Windows.Forms.Label lbSlkhach;
        private System.Windows.Forms.TabControl tabThongTin;
        private System.Windows.Forms.TabPage tabDiaDiem;
        private System.Windows.Forms.DataGridView dgvDiaDiem;
        private System.Windows.Forms.TabPage tabKhach;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.TabPage tabChiPhi;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tenkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tendiadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Thutu;
        private System.Windows.Forms.DataGridView dgvChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Chiphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Loaichiphi;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lbtMadoan;
        private System.Windows.Forms.Label lbtNgketthuc;
        private System.Windows.Forms.Label lbtNgkhoihanh;
        private System.Windows.Forms.Label lbtDoanhthu;
        private System.Windows.Forms.Label lbtSoluongkhach;
        private System.Windows.Forms.Label lbtTenTour;
        private System.Windows.Forms.Button btnNewkhach;
        private System.Windows.Forms.ComboBox cbxKhach;
        private System.Windows.Forms.Label lbThemkhach;
        private System.Windows.Forms.Button btnThemkhach;
        private System.Windows.Forms.Button btnThemnhanvien;
        private System.Windows.Forms.Button btnNewnhanvien;
        private System.Windows.Forms.ComboBox cbxNhanvien;
        private System.Windows.Forms.Label lbThemnhanvien;
        private System.Windows.Forms.Label lbLoaiCP;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnThemchiphi;
        private System.Windows.Forms.ComboBox cbxLoaiChiphi;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbNhiemVu;
        private System.Windows.Forms.TextBox txtNhiemVu;
        private System.Windows.Forms.Button btnXoaK;
        private System.Windows.Forms.Button btnXoaCP;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nhiemvu;
        private System.Windows.Forms.Label lbtGia;
        private System.Windows.Forms.Label label2;
    }
}