using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PresentationLayer
{
    public partial class Form_Home : Form
    {
        private Form activeForm = null;

        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }

        // Load form ứng với nút
        private void openChildForm(Form childForm)
        {
            if(activeForm !=  null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //xử lý sự kiện nút TOUR
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_DSTour());
        }

        //xử lý sự kiện nút ĐOÀN
        private void btnDoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Doan());
            
        }

        //xử lý sự kiện nút KHÁCH HÀNG
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_KhachHang());
        }

        //xử lý sự kiện nút THỐNG KÊ
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ThongKe());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
