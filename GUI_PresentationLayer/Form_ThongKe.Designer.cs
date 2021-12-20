
using System.Windows.Forms;

namespace GUI_PresentationLayer
{
    partial class Form_ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChiPhi = new System.Windows.Forms.TabPage();
            this.dgvTKChiPhi = new System.Windows.Forms.DataGridView();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTKChiPhi = new System.Windows.Forms.Button();
            this.lbTienChiPhi = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbTour = new System.Windows.Forms.ComboBox();
            this.datePickerEndChiPhi = new System.Windows.Forms.DateTimePicker();
            this.datePickerStartChiPhi = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTKDoanhThu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tk_maDoan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTour = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgvTK_Tour = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvTKNV = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.datePickerEndTKNV = new System.Windows.Forms.DateTimePicker();
            this.datePickerStartTKNV = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabChiPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKChiPhi)).BeginInit();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).BeginInit();
            this.tabTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK_Tour)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChiPhi);
            this.tabControl1.Controls.Add(this.tabDoanhThu);
            this.tabControl1.Controls.Add(this.tabTour);
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 554);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabChiPhi
            // 
            this.tabChiPhi.Controls.Add(this.dgvTKChiPhi);
            this.tabChiPhi.Controls.Add(this.btnTKChiPhi);
            this.tabChiPhi.Controls.Add(this.lbTienChiPhi);
            this.tabChiPhi.Controls.Add(this.label18);
            this.tabChiPhi.Controls.Add(this.cbTour);
            this.tabChiPhi.Controls.Add(this.datePickerEndChiPhi);
            this.tabChiPhi.Controls.Add(this.datePickerStartChiPhi);
            this.tabChiPhi.Controls.Add(this.label17);
            this.tabChiPhi.Controls.Add(this.label16);
            this.tabChiPhi.Controls.Add(this.label15);
            this.tabChiPhi.Location = new System.Drawing.Point(4, 41);
            this.tabChiPhi.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabChiPhi.Name = "tabChiPhi";
            this.tabChiPhi.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabChiPhi.Size = new System.Drawing.Size(808, 509);
            this.tabChiPhi.TabIndex = 0;
            this.tabChiPhi.Text = "Chi Phí";
            this.tabChiPhi.UseVisualStyleBackColor = true;
            // 
            // dgvTKChiPhi
            // 
            this.dgvTKChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKChiPhi.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTKChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKChiPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTour,
            this.tenLoaiChiPhi,
            this.tongChiPhi});
            this.dgvTKChiPhi.Location = new System.Drawing.Point(92, 187);
            this.dgvTKChiPhi.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dgvTKChiPhi.Name = "dgvTKChiPhi";
            this.dgvTKChiPhi.RowHeadersWidth = 62;
            this.dgvTKChiPhi.RowTemplate.Height = 25;
            this.dgvTKChiPhi.Size = new System.Drawing.Size(492, 189);
            this.dgvTKChiPhi.TabIndex = 10;
            // 
            // maTour
            // 
            this.maTour.HeaderText = "Mã tour";
            this.maTour.MinimumWidth = 8;
            this.maTour.Name = "maTour";
            // 
            // tenTour
            // 
            this.tenTour.HeaderText = "Tên tour";
            this.tenTour.MinimumWidth = 8;
            this.tenTour.Name = "tenTour";
            // 
            // tenLoaiChiPhi
            // 
            this.tenLoaiChiPhi.HeaderText = "Tên loại chi phí";
            this.tenLoaiChiPhi.MinimumWidth = 8;
            this.tenLoaiChiPhi.Name = "tenLoaiChiPhi";
            // 
            // tongChiPhi
            // 
            this.tongChiPhi.HeaderText = "Chi phí";
            this.tongChiPhi.MinimumWidth = 8;
            this.tongChiPhi.Name = "tongChiPhi";
            // 
            // btnTKChiPhi
            // 
            this.btnTKChiPhi.BackColor = System.Drawing.Color.Transparent;
            this.btnTKChiPhi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTKChiPhi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTKChiPhi.Location = new System.Drawing.Point(488, 100);
            this.btnTKChiPhi.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnTKChiPhi.Name = "btnTKChiPhi";
            this.btnTKChiPhi.Size = new System.Drawing.Size(98, 32);
            this.btnTKChiPhi.TabIndex = 9;
            this.btnTKChiPhi.Text = "Thống kê";
            this.btnTKChiPhi.UseVisualStyleBackColor = false;
            this.btnTKChiPhi.Click += new System.EventHandler(this.btnTKChiPhi_Click);
            // 
            // lbTienChiPhi
            // 
            this.lbTienChiPhi.AutoSize = true;
            this.lbTienChiPhi.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTienChiPhi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTienChiPhi.Location = new System.Drawing.Point(316, 147);
            this.lbTienChiPhi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTienChiPhi.Name = "lbTienChiPhi";
            this.lbTienChiPhi.Size = new System.Drawing.Size(101, 45);
            this.lbTienChiPhi.TabIndex = 8;
            this.lbTienChiPhi.Text = "0 vnd";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(92, 147);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 45);
            this.label18.TabIndex = 7;
            this.label18.Text = "Tổng chi phí";
            // 
            // cbTour
            // 
            this.cbTour.FormattingEnabled = true;
            this.cbTour.Location = new System.Drawing.Point(316, 100);
            this.cbTour.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.cbTour.Name = "cbTour";
            this.cbTour.Size = new System.Drawing.Size(102, 40);
            this.cbTour.TabIndex = 6;
            // 
            // datePickerEndChiPhi
            // 
            this.datePickerEndChiPhi.Location = new System.Drawing.Point(316, 58);
            this.datePickerEndChiPhi.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.datePickerEndChiPhi.Name = "datePickerEndChiPhi";
            this.datePickerEndChiPhi.Size = new System.Drawing.Size(269, 39);
            this.datePickerEndChiPhi.TabIndex = 5;
            // 
            // datePickerStartChiPhi
            // 
            this.datePickerStartChiPhi.Location = new System.Drawing.Point(316, 10);
            this.datePickerStartChiPhi.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.datePickerStartChiPhi.Name = "datePickerStartChiPhi";
            this.datePickerStartChiPhi.Size = new System.Drawing.Size(269, 39);
            this.datePickerStartChiPhi.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(92, 100);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 45);
            this.label17.TabIndex = 3;
            this.label17.Text = "Mã tour";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(92, 60);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 45);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ngày kết thúc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(92, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 45);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ngày bắt đầu";
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.button1);
            this.tabDoanhThu.Controls.Add(this.btnTKDoanhThu);
            this.tabDoanhThu.Controls.Add(this.label8);
            this.tabDoanhThu.Controls.Add(this.label1);
            this.tabDoanhThu.Controls.Add(this.dataGridViewTK);
            this.tabDoanhThu.Controls.Add(this.dateTimePicker2);
            this.tabDoanhThu.Controls.Add(this.label7);
            this.tabDoanhThu.Controls.Add(this.dateTimePicker1);
            this.tabDoanhThu.Controls.Add(this.label6);
            this.tabDoanhThu.Controls.Add(this.cb_tk_maDoan);
            this.tabDoanhThu.Controls.Add(this.label3);
            this.tabDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 41);
            this.tabDoanhThu.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabDoanhThu.Size = new System.Drawing.Size(808, 509);
            this.tabDoanhThu.TabIndex = 1;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(562, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTKDoanhThu
            // 
            this.btnTKDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTKDoanhThu.Location = new System.Drawing.Point(562, 166);
            this.btnTKDoanhThu.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnTKDoanhThu.Name = "btnTKDoanhThu";
            this.btnTKDoanhThu.Size = new System.Drawing.Size(92, 38);
            this.btnTKDoanhThu.TabIndex = 9;
            this.btnTKDoanhThu.Text = "Tìm kiếm";
            this.btnTKDoanhThu.UseVisualStyleBackColor = true;
            this.btnTKDoanhThu.Click += new System.EventHandler(this.btnTKDoanhThu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(223, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng doanh thu: ";
            // 
            // dataGridViewTK
            // 
            this.dataGridViewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewTK.Location = new System.Drawing.Point(22, 222);
            this.dataGridViewTK.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dataGridViewTK.Name = "dataGridViewTK";
            this.dataGridViewTK.RowHeadersWidth = 100;
            this.dataGridViewTK.RowTemplate.Height = 33;
            this.dataGridViewTK.Size = new System.Drawing.Size(765, 200);
            this.dataGridViewTK.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã đoàn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày khởi hành";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày kết thúc";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Doanh thu";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(195, 160);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 31);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đến ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 97);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Từ ngày";
            // 
            // cb_tk_maDoan
            // 
            this.cb_tk_maDoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_tk_maDoan.FormattingEnabled = true;
            this.cb_tk_maDoan.Location = new System.Drawing.Point(195, 37);
            this.cb_tk_maDoan.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.cb_tk_maDoan.Name = "cb_tk_maDoan";
            this.cb_tk_maDoan.Size = new System.Drawing.Size(294, 33);
            this.cb_tk_maDoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Đoàn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabTour
            // 
            this.tabTour.Controls.Add(this.button3);
            this.tabTour.Controls.Add(this.dtgvTK_Tour);
            this.tabTour.Controls.Add(this.button2);
            this.tabTour.Controls.Add(this.label14);
            this.tabTour.Controls.Add(this.label13);
            this.tabTour.Controls.Add(this.label12);
            this.tabTour.Controls.Add(this.label11);
            this.tabTour.Controls.Add(this.dateTimePicker4);
            this.tabTour.Controls.Add(this.dateTimePicker3);
            this.tabTour.Controls.Add(this.comboBox1);
            this.tabTour.Controls.Add(this.label10);
            this.tabTour.Controls.Add(this.label4);
            this.tabTour.Controls.Add(this.label9);
            this.tabTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabTour.Location = new System.Drawing.Point(4, 41);
            this.tabTour.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabTour.Name = "tabTour";
            this.tabTour.Size = new System.Drawing.Size(808, 509);
            this.tabTour.TabIndex = 2;
            this.tabTour.Text = "Tour";
            this.tabTour.UseVisualStyleBackColor = true;
            this.tabTour.Click += new System.EventHandler(this.tabTour_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(601, 83);
            this.button3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgvTK_Tour
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTK_Tour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTK_Tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTK_Tour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTK_Tour.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTK_Tour.Location = new System.Drawing.Point(16, 223);
            this.dtgvTK_Tour.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dtgvTK_Tour.Name = "dtgvTK_Tour";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTK_Tour.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTK_Tour.RowHeadersWidth = 60;
            this.dtgvTK_Tour.RowTemplate.Height = 33;
            this.dtgvTK_Tour.Size = new System.Drawing.Size(779, 165);
            this.dtgvTK_Tour.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(601, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(624, 432);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 32);
            this.label14.TabIndex = 11;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(192, 432);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 32);
            this.label13.TabIndex = 10;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(440, 423);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 45);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tổng doanh số";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(26, 425);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 45);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tổng số đoàn";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(225, 160);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(299, 31);
            this.dateTimePicker4.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(225, 100);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(299, 31);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá tour từ ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã tour";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.dgvTKNV);
            this.tabNhanVien.Controls.Add(this.btnTKNV);
            this.tabNhanVien.Controls.Add(this.datePickerEndTKNV);
            this.tabNhanVien.Controls.Add(this.datePickerStartTKNV);
            this.tabNhanVien.Controls.Add(this.label20);
            this.tabNhanVien.Controls.Add(this.label19);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 41);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(808, 509);
            this.tabNhanVien.TabIndex = 3;
            this.tabNhanVien.Text = "Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvTKNV
            // 
            this.dgvTKNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hotenNV,
            this.soluong});
            this.dgvTKNV.Location = new System.Drawing.Point(108, 160);
            this.dgvTKNV.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dgvTKNV.Name = "dgvTKNV";
            this.dgvTKNV.RowHeadersWidth = 62;
            this.dgvTKNV.RowTemplate.Height = 25;
            this.dgvTKNV.Size = new System.Drawing.Size(468, 170);
            this.dgvTKNV.TabIndex = 6;
            // 
            // maNV
            // 
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.MinimumWidth = 8;
            this.maNV.Name = "maNV";
            // 
            // hotenNV
            // 
            this.hotenNV.HeaderText = "Họ tên";
            this.hotenNV.MinimumWidth = 8;
            this.hotenNV.Name = "hotenNV";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lần đi tour";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            // 
            // btnTKNV
            // 
            this.btnTKNV.Location = new System.Drawing.Point(470, 98);
            this.btnTKNV.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(105, 39);
            this.btnTKNV.TabIndex = 5;
            this.btnTKNV.Text = "Thống kê";
            this.btnTKNV.UseVisualStyleBackColor = true;
            this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click);
            // 
            // datePickerEndTKNV
            // 
            this.datePickerEndTKNV.Location = new System.Drawing.Point(308, 52);
            this.datePickerEndTKNV.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.datePickerEndTKNV.Name = "datePickerEndTKNV";
            this.datePickerEndTKNV.Size = new System.Drawing.Size(268, 39);
            this.datePickerEndTKNV.TabIndex = 4;
            // 
            // datePickerStartTKNV
            // 
            this.datePickerStartTKNV.Location = new System.Drawing.Point(308, 14);
            this.datePickerStartTKNV.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.datePickerStartTKNV.Name = "datePickerStartTKNV";
            this.datePickerStartTKNV.Size = new System.Drawing.Size(268, 39);
            this.datePickerStartTKNV.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(108, 52);
            this.label20.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(229, 45);
            this.label20.TabIndex = 2;
            this.label20.Text = "Ngày kết thúc";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(108, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(257, 45);
            this.label19.TabIndex = 1;
            this.label19.Text = "Ngày khởi hành";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã tour";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên tour";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã đoàn";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngày bắt đầu";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ngày kết thúc";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Giá tour";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 175;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "SL khách";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Doanh số";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Form_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 581);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_ThongKe";
            this.Text = "Form_ThongKe";
            this.Load += new System.EventHandler(this.Form_ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabChiPhi.ResumeLayout(false);
            this.tabChiPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKChiPhi)).EndInit();
            this.tabDoanhThu.ResumeLayout(false);
            this.tabDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).EndInit();
            this.tabTour.ResumeLayout(false);
            this.tabTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK_Tour)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChiPhi;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabTour;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tk_maDoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Button btnTKDoanhThu;
        private Button button1;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
        private Label label10;
        private Label label4;
        private Button button3;
        private Button button2;
        private Label label16;
        private Label label15;
        private Label label17;
        private DataGridView dgvTKChiPhi;
        private Button btnTKChiPhi;
        private Label lbTienChiPhi;
        private Label label18;
        private ComboBox cbTour;
        private DateTimePicker datePickerEndChiPhi;
        private DateTimePicker datePickerStartChiPhi;
        private DataGridViewTextBoxColumn maTour;
        private DataGridViewTextBoxColumn tenTour;
        private DataGridViewTextBoxColumn tenLoaiChiPhi;
        private DataGridViewTextBoxColumn tongChiPhi;
        private Label label19;
        private Label label20;
        private DateTimePicker datePickerEndTKNV;
        private DateTimePicker datePickerStartTKNV;
        private Button btnTKNV;
        private DataGridView dgvTKNV;
        private DataGridViewTextBoxColumn maNV;
        private DataGridViewTextBoxColumn hotenNV;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dtgvTK_Tour;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}