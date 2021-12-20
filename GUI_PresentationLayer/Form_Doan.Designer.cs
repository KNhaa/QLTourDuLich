
namespace GUI_PresentationLayer
{
    partial class Form_Doan
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMatour = new System.Windows.Forms.Label();
            this.lbNgkhoihanh = new System.Windows.Forms.Label();
            this.lbNgketthuc = new System.Windows.Forms.Label();
            this.dtpNgkhoihanh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgketthuc = new System.Windows.Forms.DateTimePicker();
            this.cbMatour = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDsdoan = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.col_Madoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ngkhoihanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ngketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Doanhthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Matour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsdoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐOÀN";
            // 
            // lbMatour
            // 
            this.lbMatour.AutoSize = true;
            this.lbMatour.Location = new System.Drawing.Point(45, 183);
            this.lbMatour.Name = "lbMatour";
            this.lbMatour.Size = new System.Drawing.Size(68, 20);
            this.lbMatour.TabIndex = 6;
            this.lbMatour.Text = "Mã tour :";
            // 
            // lbNgkhoihanh
            // 
            this.lbNgkhoihanh.AutoSize = true;
            this.lbNgkhoihanh.Location = new System.Drawing.Point(45, 113);
            this.lbNgkhoihanh.Name = "lbNgkhoihanh";
            this.lbNgkhoihanh.Size = new System.Drawing.Size(119, 20);
            this.lbNgkhoihanh.TabIndex = 7;
            this.lbNgkhoihanh.Text = "Ngày khởi hành :";
            // 
            // lbNgketthuc
            // 
            this.lbNgketthuc.AutoSize = true;
            this.lbNgketthuc.Location = new System.Drawing.Point(489, 113);
            this.lbNgketthuc.Name = "lbNgketthuc";
            this.lbNgketthuc.Size = new System.Drawing.Size(107, 20);
            this.lbNgketthuc.TabIndex = 8;
            this.lbNgketthuc.Text = "Ngày kết thúc :";
            // 
            // dtpNgkhoihanh
            // 
            this.dtpNgkhoihanh.Location = new System.Drawing.Point(194, 105);
            this.dtpNgkhoihanh.Name = "dtpNgkhoihanh";
            this.dtpNgkhoihanh.Size = new System.Drawing.Size(241, 27);
            this.dtpNgkhoihanh.TabIndex = 2;
            // 
            // dtpNgketthuc
            // 
            this.dtpNgketthuc.Location = new System.Drawing.Point(618, 105);
            this.dtpNgketthuc.Name = "dtpNgketthuc";
            this.dtpNgketthuc.Size = new System.Drawing.Size(239, 27);
            this.dtpNgketthuc.TabIndex = 3;
            // 
            // cbMatour
            // 
            this.cbMatour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMatour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMatour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatour.FormattingEnabled = true;
            this.cbMatour.Location = new System.Drawing.Point(194, 179);
            this.cbMatour.Name = "cbMatour";
            this.cbMatour.Size = new System.Drawing.Size(241, 28);
            this.cbMatour.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(45, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(194, 285);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(831, 284);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 37);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDsdoan
            // 
            this.dgvDsdoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsdoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDsdoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsdoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Madoan,
            this.col_Ngkhoihanh,
            this.col_Ngketthuc,
            this.col_Doanhthu,
            this.col_Matour});
            this.dgvDsdoan.Location = new System.Drawing.Point(33, 347);
            this.dgvDsdoan.Name = "dgvDsdoan";
            this.dgvDsdoan.RowHeadersWidth = 51;
            this.dgvDsdoan.RowTemplate.Height = 29;
            this.dgvDsdoan.Size = new System.Drawing.Size(891, 323);
            this.dgvDsdoan.TabIndex = 1;
            this.dgvDsdoan.TabStop = false;
            this.dgvDsdoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsdoan_CellClick);
            this.dgvDsdoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsdoan_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(572, 289);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(253, 27);
            this.txtSearch.TabIndex = 17;
            // 
            // col_Madoan
            // 
            this.col_Madoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Madoan.FillWeight = 57.94505F;
            this.col_Madoan.HeaderText = "Mã đoàn";
            this.col_Madoan.MinimumWidth = 6;
            this.col_Madoan.Name = "col_Madoan";
            this.col_Madoan.ReadOnly = true;
            this.col_Madoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Madoan.Width = 120;
            // 
            // col_Ngkhoihanh
            // 
            this.col_Ngkhoihanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.col_Ngkhoihanh.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_Ngkhoihanh.FillWeight = 100.7838F;
            this.col_Ngkhoihanh.HeaderText = "Ngày khởi hành";
            this.col_Ngkhoihanh.MinimumWidth = 6;
            this.col_Ngkhoihanh.Name = "col_Ngkhoihanh";
            this.col_Ngkhoihanh.ReadOnly = true;
            this.col_Ngkhoihanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Ngkhoihanh.Width = 200;
            // 
            // col_Ngketthuc
            // 
            this.col_Ngketthuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.col_Ngketthuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Ngketthuc.FillWeight = 110.5589F;
            this.col_Ngketthuc.HeaderText = "Ngày kết thúc";
            this.col_Ngketthuc.MinimumWidth = 6;
            this.col_Ngketthuc.Name = "col_Ngketthuc";
            this.col_Ngketthuc.ReadOnly = true;
            this.col_Ngketthuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Ngketthuc.Width = 200;
            // 
            // col_Doanhthu
            // 
            this.col_Doanhthu.FillWeight = 112.8703F;
            this.col_Doanhthu.HeaderText = "Doanh thu";
            this.col_Doanhthu.MinimumWidth = 6;
            this.col_Doanhthu.Name = "col_Doanhthu";
            this.col_Doanhthu.ReadOnly = true;
            this.col_Doanhthu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Matour
            // 
            this.col_Matour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Matour.FillWeight = 117.8421F;
            this.col_Matour.HeaderText = "Mã tour";
            this.col_Matour.MinimumWidth = 6;
            this.col_Matour.Name = "col_Matour";
            this.col_Matour.ReadOnly = true;
            this.col_Matour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Matour.Width = 130;
            // 
            // Form_Doan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 701);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbMatour);
            this.Controls.Add(this.dtpNgketthuc);
            this.Controls.Add(this.dtpNgkhoihanh);
            this.Controls.Add(this.lbNgketthuc);
            this.Controls.Add(this.lbNgkhoihanh);
            this.Controls.Add(this.lbMatour);
            this.Controls.Add(this.dgvDsdoan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Doan";
            this.Load += new System.EventHandler(this.DSDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsdoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMatour;
        private System.Windows.Forms.Label lbNgkhoihanh;
        private System.Windows.Forms.Label lbNgketthuc;
        private System.Windows.Forms.DateTimePicker dtpNgkhoihanh;
        private System.Windows.Forms.DateTimePicker dtpNgketthuc;
        private System.Windows.Forms.ComboBox cbMatour;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDsdoan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Madoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ngkhoihanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ngketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Doanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Matour;
    }
}