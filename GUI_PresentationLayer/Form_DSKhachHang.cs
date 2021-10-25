using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.Entities;
namespace GUI_PresentationLayer
{
    public partial class Form_DSKhachHang : Form
    {
        public Form_DSKhachHang()
        {
            InitializeComponent();
            getListKhachHang();          
            resetAllTextBoxs();

        }
        // load data lên cho dataGridView
        public void getListKhachHang()
        {
            dataGVKhachHang.DataSource = BUSKhachHang.getListKhachHang();
        }
        // khi nhấn vào từng dòng nó sẽ hiện lên trên textbox
        public void addBinding()
        {
            txtHoTen.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "tenKh"));
            txtDiaChi.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "diaChi"));
            txtCMND.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "cnmd"));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "gioiTinh"));
            txtSDT.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "sdt"));
            txtQuocTich.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "quocTich"));
        }
        public void resetAllTextBoxs()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtGioiTinh.Text = "";
            txtSDT.Text = "";
            txtQuocTich.Text = "";
        }
        public void themKhachHang()
        {
            BUSKhachHang.themKhachHang(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, txtGioiTinh.Text, txtSDT.Text, txtQuocTich.Text);
            // hiển thị lại ds sau khi thêm lên dataGridview
            getListKhachHang();
            // reset lại tất cả textbox về null sau khi thêm xong
            resetAllTextBoxs();
        }
        private void Form_DSKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGVKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            themKhachHang();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetAllTextBoxs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addBinding();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
