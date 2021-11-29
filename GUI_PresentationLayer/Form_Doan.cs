using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PresentationLayer
{
    public partial class Form_Doan : Form
    {
        int indexDgv = 0;
        List<Doan>  doans;
        List<Tour> tours;
        BUSDoan _busDoan;
        public Form_Doan()
        {
            InitializeComponent();
            _busDoan = new BUSDoan();
            doans = _busDoan.GetDoan().ToList();
            tours = _busDoan.GetTour().ToList();

        }

        private void DSDoan_Load(object sender, EventArgs e)
        {
            dgvDsdoan.AutoGenerateColumns = false;
            dgvDsdoan.ColumnCount = 5;

            List<String> lName = new List<string> { "maDoan", "ngayKhoiHanh", "ngayKetThuc", "doanhThu", "maTour" };
            for (int index = 0; index < dgvDsdoan.ColumnCount; index++)
            {
                dgvDsdoan.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }

            dgvDsdoan.DataSource = doans;
            cbMatour.DataSource = tours.Select(tour => tour.maTour).ToList();
            cbxDoansearch.DataSource = doans.Select(doan => doan.maDoan).ToList();
        }

        private void dgvDsdoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDsdoan.CurrentRow.Selected = true;
            indexDgv = dgvDsdoan.CurrentRow.Index;
            var doan = doans[indexDgv];
            dtpNgkhoihanh.Value = doan.ngayKhoiHanh;
            dtpNgketthuc.Value = doan.ngayKetThuc;
            cbMatour.SelectedItem = doan.maTour;
        }

        private void dgvDsdoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDsdoan.CurrentRow.Selected = true;
            indexDgv = dgvDsdoan.CurrentRow.Index;
            var doan = doans[indexDgv];
            Form_ChiTietDoan chiTietDoan = new Form_ChiTietDoan(doan);
            chiTietDoan.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var  searchID = (int)cbxDoansearch.SelectedValue;
            var doan = doans.Where(doans => doans.maDoan == searchID).Select(doans => doans).ToList();
            dgvDsdoan.DataSource = doan;
            dgvDsdoan.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var newDThu = 0;
            DateTime newKhHanh = dtpNgkhoihanh.Value.Date;
            DateTime newKThuc = dtpNgketthuc.Value.Date;
            if ((newKhHanh < DateTime.Now) || (newKThuc < newKhHanh))
            {
                MessageBox.Show("Ngày tháng không hợp lệ!!\n- Ngày khởi hành phải lớn hơn ngày hiện tại.\n- Ngày kết thúc phải lớn hơn ngày khởi hành.", "Cảnh báo");
            }
            else
            {
                Doan doan = new Doan();
                doan.maTour = (int)cbMatour.SelectedValue;
                doan.ngayKhoiHanh = newKhHanh;
                doan.ngayKetThuc = newKThuc;
                doan.doanhThu = newDThu;
                _busDoan.Create(doan);
                doans = _busDoan.GetDoan().ToList();
                dgvDsdoan.DataSource = doans;
                dgvDsdoan.Update();
                dgvDsdoan.Refresh();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var newDThu = 0;
            DateTime newKhHanh = dtpNgkhoihanh.Value.Date;
            DateTime newKThuc = dtpNgketthuc.Value.Date;
            if ((newKhHanh < DateTime.Now) || (newKThuc < newKhHanh))
            {
                MessageBox.Show("ngày tháng không hợp lệ!!\n- ngày khởi hành phải lớn hơn ngày hiện tại\n- ngày kết thúc phải lớn hơn ngày khởi hành");
            }
            else
            {

                indexDgv = dgvDsdoan.CurrentRow.Index;
                var doan = doans[indexDgv];
                doan.ngayKhoiHanh = dtpNgkhoihanh.Value;
                doan.ngayKetThuc = dtpNgketthuc.Value;
                doan.doanhThu = newDThu;
                doan.maTour = (int)cbMatour.SelectedItem;
                _busDoan.Update(doan);
                doans = _busDoan.GetDoan().ToList();
                dgvDsdoan.DataSource = doans;
                cbxDoansearch.DataSource = doans.Select(doan => doan.maDoan).ToList();
                cbxDoansearch.Update();
                cbxDoansearch.Refresh();
                dgvDsdoan.Update();
                dgvDsdoan.Refresh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            indexDgv = dgvDsdoan.CurrentRow.Index;
            var doan = doans[indexDgv];
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không.", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _busDoan.Delete(doan);
                doans = _busDoan.GetDoan().ToList();
                dgvDsdoan.DataSource = doans;
                dgvDsdoan.Update();
                dgvDsdoan.Refresh();
            }
        }
    }
}
