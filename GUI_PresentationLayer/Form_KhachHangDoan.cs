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
using GUI_PresentationLayer;

namespace GUI_PresentationLayer
{
    public partial class Form_KhachHangDoan : Form
    {
        public static int maDoan = 0;
       public  int maKH = Form_DSKhachHang.IdKH; // lấy mã bên kh
        public BUSKhachHangDoan _busKhachHangDoan = null;
        public Form_KhachHangDoan()
        {
            
            InitializeComponent();
            getListDoans(maKH);
            _busKhachHangDoan = new BUSKhachHangDoan();

        }
        public  void getListDoans (int maKH) // lấy ds đoàn theo mã khách hàng
        {
           
            if( _busKhachHangDoan!= null)
            {
                dataGVKhachDoan.DataSource = _busKhachHangDoan.getAllDoans(maKH);
            }
           
        }
        public void addBinding()
        {
            // khi gapj looix binding
            dtNgayKhoiHanh.DataBindings.Clear();
            dtNgayKetThuc.DataBindings.Clear();
            maDoan = Convert.ToInt32(dataGVKhachDoan.CurrentRow.Cells["maDoan"].Value);
            dtNgayKhoiHanh.DataBindings.Add(new Binding("Value", dataGVKhachDoan.DataSource, "ngayKhoiHanh"));
            dtNgayKetThuc.DataBindings.Add(new Binding("Value", dataGVKhachDoan.DataSource, "ngayKetThuc"));
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form_KhachHangDoan_Load(object sender, EventArgs e)
        {

        }
        public void resetAllDataPicker()
        {
            dtNgayKhoiHanh.CustomFormat = "";
            dtNgayKetThuc.CustomFormat = "";
            /* IdKH = 0;*/
        }
        // xóa đoàn theo id đoàn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _busKhachHangDoan.deleteDoanVaChiTiet(maDoan);
                // load lại thông tin đoàn theo id khách hàng khi click vào khách hàng
                getListDoans(maKH);
                resetAllDataPicker();
                MessageBox.Show("Xóa thành công!");
            }
        }
        private void dataGVKhachDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBinding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            _busKhachHangDoan.themDoan( dtNgayKhoiHanh.Value, dtNgayKetThuc.Value, maDoan, maKH);
            MessageBox.Show("Thêm thành công!");

        }

        private void dtNgayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
