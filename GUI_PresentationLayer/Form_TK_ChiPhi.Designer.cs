
namespace GUI_PresentationLayer
{
    partial class Form_TK_ChiPhi
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
            this.dataViewTKCP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTKCP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewTKCP
            // 
            this.dataViewTKCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewTKCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewTKCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTour,
            this.tenLoaiChiPhi,
            this.tongChiPhi});
            this.dataViewTKCP.Location = new System.Drawing.Point(144, 203);
            this.dataViewTKCP.Name = "dataViewTKCP";
            this.dataViewTKCP.RowTemplate.Height = 25;
            this.dataViewTKCP.Size = new System.Drawing.Size(503, 209);
            this.dataViewTKCP.TabIndex = 0;
            this.dataViewTKCP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewTKCP_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày kết thúc";
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(447, 34);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(200, 23);
            this.datePickerStart.TabIndex = 3;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(447, 74);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(200, 23);
            this.datePickerEnd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(547, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "THỐNG KÊ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTour
            // 
            this.cbTour.FormattingEnabled = true;
            this.cbTour.Location = new System.Drawing.Point(447, 110);
            this.cbTour.Name = "cbTour";
            this.cbTour.Size = new System.Drawing.Size(200, 23);
            this.cbTour.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(245, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Tour";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(245, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng chi phí:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTongTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTongTien.Location = new System.Drawing.Point(396, 150);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(0, 21);
            this.lbTongTien.TabIndex = 9;
            // 
            // maTour
            // 
            this.maTour.DataPropertyName = "maTour";
            this.maTour.HeaderText = "Mã Tour";
            this.maTour.Name = "maTour";
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "tenTour";
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.Name = "tenTour";
            // 
            // tenLoaiChiPhi
            // 
            this.tenLoaiChiPhi.DataPropertyName = "tenLoaiChiPhi";
            this.tenLoaiChiPhi.HeaderText = "Tên loại chi phí";
            this.tenLoaiChiPhi.Name = "tenLoaiChiPhi";
            // 
            // tongChiPhi
            // 
            this.tongChiPhi.DataPropertyName = "tongChiPhi";
            this.tongChiPhi.HeaderText = "Chi phí";
            this.tongChiPhi.Name = "tongChiPhi";
            // 
            // Form_TK_ChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataViewTKCP);
            this.Name = "Form_TK_ChiPhi";
            this.Text = "Form_TK_ChiPhi";
            this.Load += new System.EventHandler(this.Form_TK_ChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewTKCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewTKCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongChiPhi;
    }
}