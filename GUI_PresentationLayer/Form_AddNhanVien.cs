using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer.Entities;
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
    public partial class Form_AddNhanVien : Form
    {
        public Form_AddNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.tenNv = txtTenNV.Text;
            BUSChiTietDoan.addNhanVien(nv);
            MessageBox.Show("Thêm thành công", "Thông báo");
        }
    }
}
