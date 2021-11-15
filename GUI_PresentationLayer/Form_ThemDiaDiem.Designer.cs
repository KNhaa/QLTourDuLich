
namespace GUI_PresentationLayer
{
    partial class Form_ThemDiaDiem
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
            this.lb_DiaDiem = new System.Windows.Forms.Label();
            this.cb_DiaChi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_TenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(168, 23);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(209, 37);
            this.lb_Header.TabIndex = 7;
            this.lb_Header.Text = "THÊM ĐỊA ĐIỂM";
            // 
            // lb_DiaDiem
            // 
            this.lb_DiaDiem.AutoSize = true;
            this.lb_DiaDiem.Location = new System.Drawing.Point(36, 252);
            this.lb_DiaDiem.Name = "lb_DiaDiem";
            this.lb_DiaDiem.Size = new System.Drawing.Size(75, 20);
            this.lb_DiaDiem.TabIndex = 8;
            this.lb_DiaDiem.Text = "Địa Điểm:";
            // 
            // cb_DiaChi
            // 
            this.cb_DiaChi.FormattingEnabled = true;
            this.cb_DiaChi.Location = new System.Drawing.Point(36, 275);
            this.cb_DiaChi.Name = "cb_DiaChi";
            this.cb_DiaChi.Size = new System.Drawing.Size(264, 28);
            this.cb_DiaChi.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TenDiaDiem,
            this.col_ThuTu});
            this.dataGridView1.Location = new System.Drawing.Point(36, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(364, 143);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // col_TenDiaDiem
            // 
            this.col_TenDiaDiem.Frozen = true;
            this.col_TenDiaDiem.HeaderText = "Tên Địa Điểm";
            this.col_TenDiaDiem.MinimumWidth = 6;
            this.col_TenDiaDiem.Name = "col_TenDiaDiem";
            this.col_TenDiaDiem.Width = 180;
            // 
            // col_ThuTu
            // 
            this.col_ThuTu.HeaderText = "Thứ Tự";
            this.col_ThuTu.MinimumWidth = 6;
            this.col_ThuTu.Name = "col_ThuTu";
            this.col_ThuTu.Width = 125;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(306, 274);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(406, 178);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(101, 29);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Enabled = false;
            this.btn_Up.Location = new System.Drawing.Point(406, 106);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(101, 30);
            this.btn_Up.TabIndex = 14;
            this.btn_Up.Text = "Up";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Enabled = false;
            this.btn_Down.Location = new System.Drawing.Point(406, 142);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(101, 30);
            this.btn_Down.TabIndex = 15;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // Form_ThemDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_DiaChi);
            this.Controls.Add(this.lb_DiaDiem);
            this.Controls.Add(this.lb_Header);
            this.Name = "Form_ThemDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThemDiaDiem";
            this.Load += new System.EventHandler(this.Form_ThemDiaDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.Label lb_DiaDiem;
        private System.Windows.Forms.ComboBox cb_DiaChi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThuTu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
    }
}