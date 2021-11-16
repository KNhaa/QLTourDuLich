
namespace GUI_PresentationLayer
{
    partial class Form_AddNhanVien
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
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbTenVN = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(200, 39);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(229, 27);
            this.txtTenNV.TabIndex = 0;
            // 
            // lbTenVN
            // 
            this.lbTenVN.AutoSize = true;
            this.lbTenVN.Location = new System.Drawing.Point(62, 42);
            this.lbTenVN.Name = "lbTenVN";
            this.lbTenVN.Size = new System.Drawing.Size(106, 20);
            this.lbTenVN.TabIndex = 1;
            this.lbTenVN.Text = "Tên nhân viên :";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(360, 92);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(94, 29);
            this.btnThemNV.TabIndex = 2;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // Form_AddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 163);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.lbTenVN);
            this.Controls.Add(this.txtTenNV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 210);
            this.Name = "Form_AddNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbTenVN;
        private System.Windows.Forms.Button btnThemNV;
    }
}