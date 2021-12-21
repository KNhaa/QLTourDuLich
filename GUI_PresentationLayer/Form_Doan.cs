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
using static DAL_DataAccessLayer.DALServices.DAODoan;

namespace GUI_PresentationLayer
{
    public partial class Form_Doan : Form
    {
        int indexDgv = 0;
        List<Doan>  doans;
        List<nDoan> ndoans;
        List<Tour> tours;
        BUSDoan _busDoan;
        BUSGiaTour _busGiaTour;
        BUSChiTietDoan _busChiTietDoan;

        public Form_Doan()
        {
            InitializeComponent();
            _busDoan = new BUSDoan();
            _busGiaTour = new BUSGiaTour();
            _busChiTietDoan = new BUSChiTietDoan();
            doans = _busDoan.GetDoan().ToList();
            ndoans = _busDoan.GetNDoans().ToList();
            tours = _busDoan.GetTour().ToList();
        }

        private void DSDoan_Load(object sender, EventArgs e)
        {
            dgvDsdoan.AutoGenerateColumns = false;
            dgvDsdoan.ColumnCount = 5;

            List<String> lName = new List<string> { "maDoan", "ngayKhoiHanh", "ngayKetThuc", "doanhThu", "tenTour" };
            for (int index = 0; index < dgvDsdoan.ColumnCount; index++)
            {
                dgvDsdoan.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }


            dgvDsdoan.DataSource = ndoans;
            cbMatour.DataSource = tours.Select(tour => tour.tenTour).ToList();
        }

        private void dgvDsdoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDsdoan.CurrentRow.Selected = true;
            indexDgv = dgvDsdoan.CurrentRow.Index;
            var doan = ndoans[indexDgv];
            dtpNgkhoihanh.Value = doan.ngayKhoiHanh;
            dtpNgketthuc.Value = doan.ngayKetThuc;
            cbMatour.SelectedItem = doan.tenTour;
        }

        private void dgvDsdoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            doans = _busDoan.GetDoan().ToList();
            dgvDsdoan.CurrentRow.Selected = true;
            indexDgv = dgvDsdoan.CurrentRow.Index;
            var doan = doans[indexDgv];
            Form_ChiTietDoan chiTietDoan = new Form_ChiTietDoan(doan);
            chiTietDoan.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvDsdoan.DataSource = doans;
                dgvDsdoan.Refresh();
            }
            else
            {
                try
                {
                    var search = int.Parse(txtSearch.Text);
                    var doan = doans.Where(doans => doans.maDoan == search).Select(doans => doans).ToList();
                    if(doan.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin đoàn cần tìm", "Thông báo");
                    } else
                    {
                        dgvDsdoan.DataSource = doan;
                        dgvDsdoan.Refresh();
                    }
                }
                catch
                {
                    MessageBox.Show("Không có thông tin đoàn cần tìm", "Thông báo");
                }
            }
            
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
                Tour t = tours[cbMatour.SelectedIndex];
                doan.maTour = t.maTour;
                doan.ngayKhoiHanh = newKhHanh;
                doan.ngayKetThuc = newKThuc;
                doan.doanhThu = newDThu;
                _busDoan.Create(doan);
                ndoans = _busDoan.GetNDoans().ToList();
                dgvDsdoan.DataSource = ndoans;
                dgvDsdoan.Update();
                dgvDsdoan.Refresh();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var newDThu = 0;
            DateTime newKhHanh = dtpNgkhoihanh.Value.Date;
            DateTime newKThuc = dtpNgketthuc.Value.Date;
            if ((newKThuc < newKhHanh))
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
                Tour t = tours[cbMatour.SelectedIndex];
                doan.maTour = t.maTour;
                var gias = _busGiaTour.GetByTourId(t.maTour);
                var gia = gias.SingleOrDefault(g => doan.ngayKhoiHanh >= g.ngayKhoiHanh && doan.ngayKhoiHanh < g.ngayKetThuc);
                if (gia == null)
                {
                    doan.doanhThu = 0;
                }
                else
                {
                    var khachDoan = _busChiTietDoan.GetDsKhach(doan).ToList();
                    doan.doanhThu = (float)(khachDoan.Count * gia.thanhTien);
                }
                _busDoan.Update(doan);
                ndoans = _busDoan.GetNDoans().ToList();
                dgvDsdoan.DataSource = ndoans;
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
