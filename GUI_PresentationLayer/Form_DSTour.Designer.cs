
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(180, 348);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(327, 348);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(467, 348);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_1,
            this.col_2,
            this.col_3,
            this.col_4,
            this.col_5});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 269);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_1
            // 
            this.col_1.HeaderText = "Mã Tour";
            this.col_1.MinimumWidth = 6;
            this.col_1.Name = "col_1";
            this.col_1.Width = 100;
            // 
            // col_2
            // 
            this.col_2.HeaderText = "Tên Tour";
            this.col_2.MinimumWidth = 6;
            this.col_2.Name = "col_2";
            this.col_2.Width = 170;
            // 
            // col_3
            // 
            this.col_3.HeaderText = "Khách Sạn";
            this.col_3.MinimumWidth = 6;
            this.col_3.Name = "col_3";
            this.col_3.Width = 125;
            // 
            // col_4
            // 
            this.col_4.HeaderText = "Nội Dung";
            this.col_4.MinimumWidth = 6;
            this.col_4.Name = "col_4";
            this.col_4.Width = 200;
            // 
            // col_5
            // 
            this.col_5.HeaderText = "Đặc Điểm";
            this.col_5.MinimumWidth = 6;
            this.col_5.Name = "col_5";
            this.col_5.Width = 125;
            // 
            // Form_DSTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Name = "Form_DSTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tour";
            this.Load += new System.EventHandler(this.Form_DSTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_5;
    }
}