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
    public  partial class Form_DSKhachHang : Form
    {
        public static int IdKH = 0;  // lưu lại id khách hàng khi click vào dòng
        BUSKhachHang _busKhachHang = null;
        public  Form_DSKhachHang()
        {
           
            InitializeComponent();
            _busKhachHang = new BUSKhachHang();
            getListKhachHang();          
            resetAllTextBoxs();
          
           
        }
        // load data lên cho dataGridView
        public void getListKhachHang()
        {
            dataGVKhachHang.DataSource = _busKhachHang.getListKhachHang();

        }
        // khi nhấn vào từng dòng nó sẽ hiện lên trên textbox
        public void addBinding()
        {
            // khi gapj looix binding
            txtHoTen.DataBindings.Clear();
            txtQuocTich.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            cbGioiTinh.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            IdKH = Convert.ToInt32(dataGVKhachHang.CurrentRow.Cells["maKh"].Value);
            txtHoTen.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "tenKh"));
            txtDiaChi.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "diaChi"));
            txtCMND.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "cnmd"));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "gioiTinh"));
            txtSDT.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "sdt"));
            txtQuocTich.DataBindings.Add(new Binding("Text", dataGVKhachHang.DataSource, "quocTich"));
        }
        public void resetAllTextBoxs()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            cbGioiTinh.SelectedItem = null;
            txtSDT.Text = "";
            txtQuocTich.Text = "";
           /* IdKH = 0;*/
        }
        public void themKhachHang()
        {
            _busKhachHang.themKhachHang(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, cbGioiTinh.SelectedItem.ToString(), txtSDT.Text, txtQuocTich.Text);
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
            _busKhachHang.updateKhachHang(IdKH, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, cbGioiTinh.SelectedItem.ToString(), txtSDT.Text, txtQuocTich.Text);
            getListKhachHang();
            resetAllTextBoxs();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void dataGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBinding();
            Form_KhachHangDoan fKhachDoan = new Form_KhachHangDoan();
            fKhachDoan.Show();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _busKhachHang.deleteKhachHang(IdKH, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, cbGioiTinh.Text, txtSDT.Text, txtQuocTich.Text);
                getListKhachHang();
                resetAllTextBoxs();
                MessageBox.Show("Xóa thành công!");
            }
        }
       
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String keyWord = txtTimKiem.Text.Trim();
          dataGVKhachHang.DataSource = _busKhachHang.searchKhachHang(keyWord);

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            getListKhachHang();
        }
    }
}
