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
        BUSChiTietDoan _busChiTietDoan;
        public Form_AddNhanVien()
        {
            InitializeComponent();
            _busChiTietDoan = new BUSChiTietDoan();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(txtTenNV.Text != "")
            {
                NhanVien nv = new NhanVien();
                nv.tenNv = txtTenNV.Text;
                _busChiTietDoan.addNhanVien(nv);
                MessageBox.Show("Thêm thành công", "Thông báo");
            } else
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Cảnh báo");
            }
            
        }
    }
}
