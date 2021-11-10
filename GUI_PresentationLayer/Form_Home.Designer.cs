
namespace GUI_PresentationLayer
{
    partial class Form_Home
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDoan = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnKhachHang);
            this.panelMenu.Controls.Add(this.btnDoan);
            this.panelMenu.Controls.Add(this.btnTour);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(171, 748);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThongKe.Image = global::GUI_PresentationLayer.Properties.Resources.thongke2;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 333);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(171, 80);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKhachHang.Image = global::GUI_PresentationLayer.Properties.Resources.khach;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 253);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(171, 80);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnDoan
            // 
            this.btnDoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoan.FlatAppearance.BorderSize = 0;
            this.btnDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoan.Image = global::GUI_PresentationLayer.Properties.Resources.doan;
            this.btnDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoan.Location = new System.Drawing.Point(0, 173);
            this.btnDoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoan.Name = "btnDoan";
            this.btnDoan.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDoan.Size = new System.Drawing.Size(171, 80);
            this.btnDoan.TabIndex = 2;
            this.btnDoan.Text = "Đoàn";
            this.btnDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoan.UseVisualStyleBackColor = true;
            this.btnDoan.Click += new System.EventHandler(this.btnDoan_Click);
            // 
            // btnTour
            // 
            this.btnTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTour.FlatAppearance.BorderSize = 0;
            this.btnTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTour.Image = global::GUI_PresentationLayer.Properties.Resources.icon1;
            this.btnTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.Location = new System.Drawing.Point(0, 93);
            this.btnTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTour.Name = "btnTour";
            this.btnTour.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnTour.Size = new System.Drawing.Size(171, 80);
            this.btnTour.TabIndex = 1;
            this.btnTour.Text = "Tour";
            this.btnTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(42)))), ((int)(((byte)(85)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(171, 93);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Du lịch ABC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(954, 748);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1125, 748);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Du lich ABC";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDoan;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
    }
}