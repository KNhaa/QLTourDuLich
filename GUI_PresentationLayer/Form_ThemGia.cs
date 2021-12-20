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
    public partial class Form_ThemGia : Form
    {
        public Form_ChiTietTour _form;
        int currentIndex = -1;
        Tour _tour;
        BUSTour _busTour;
        BUSGiaTour _busGiaTour;
        BUSDoan _busDoan;
        BUSChiTietDoan _busChiTietDoan;
        public Form_ThemGia(Form_ChiTietTour form)
        {
            InitializeComponent();
            _form = form;
            _busTour = new BUSTour();
            _busGiaTour = new BUSGiaTour();
            _busDoan = new BUSDoan();
            _busChiTietDoan = new BUSChiTietDoan();
            _tour = _busTour.GetTour(_form._tour.maTour);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_NgayKhoiHanh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
          
            var ngayKhoiHanh = dateTimePicker1.Value;
            var ngayKetThuc = dateTimePicker2.Value;
            
            try
            {
                var thanhTien = decimal.Parse(tb_Gia.Text);
                var giaTour = new GiaTour
                {
                    ngayKhoiHanh = ngayKhoiHanh,
                    ngayKetThuc = ngayKetThuc,
                    thanhTien = thanhTien,
                    maTour = _tour.maTour
                };
                ValidationContext context = new ValidationContext(giaTour, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                StringBuilder stringBuilder = new StringBuilder();
                if (!Validator.TryValidateObject(giaTour, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                        stringBuilder.Append(result + "\n");
                  
                    MessageBox.Show(stringBuilder.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateTime.Compare(giaTour.ngayKhoiHanh, giaTour.ngayKetThuc) > 0)
                {
                    stringBuilder.Append("Ngày khởi hành không được lớn hơn ngày kết thúc");
                    MessageBox.Show(stringBuilder.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _tour.GiaTours.Add(giaTour);
                    _busGiaTour.Create(giaTour);
                    var doans = _busDoan.GetDoan().ToList();
                    var doan = doans.Where(d => d.maTour == giaTour.maTour && (d.ngayKhoiHanh >= giaTour.ngayKhoiHanh && d.ngayKhoiHanh < giaTour.ngayKetThuc)).ToList();
                    if(doan.Count != 0)
                    {
                        foreach(Doan d in doan)
                        {
                            var slKhach = _busChiTietDoan.GetDsKhach(d).Count;
                            d.doanhThu = (float)(slKhach * giaTour.thanhTien);
                            _busDoan.Update(d);
                        }
                    }
                    MessageBox.Show("Thêm giá tour thành công");
                    DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
                    dataGridView.DataSource = _busGiaTour.GetByTourId(_tour.maTour);
                    _form.Refresh();
                    data_GiaTour.DataSource = dataGridView.DataSource;
                    data_GiaTour.Refresh();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy nhập vào số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void Form_ThemGia_Load(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
            data_GiaTour.AutoGenerateColumns = false;
            data_GiaTour.ColumnCount = 3;
            List<String> propertyName = new List<String>() { "ngayKhoiHanh", "ngayKetThuc", "thanhTien" };
            for (int index = 0; index < data_GiaTour.ColumnCount; index++)
            {
                data_GiaTour.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            
            data_GiaTour.DataSource = dataGridView.DataSource;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (data_GiaTour.RowCount==0)
            {

            }
            if (currentIndex == -1)
            {
                MessageBox.Show("Hãy chọn giá tour cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(currentIndex!=-1)
            {
                if (data_GiaTour.CurrentRow != null)
                {
                    data_GiaTour.CurrentRow.Selected = true;
                    currentIndex = data_GiaTour.CurrentRow.Index;
                    var giaTour = _tour.GiaTours.ToArray()[currentIndex];
                    if (MessageBox.Show("Bạn có chắc chắn xóa giá tour này ?", "Xóa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (giaTour != null)
                        {
                            _busGiaTour.Delete(giaTour.maGiaTour);
                            _tour.GiaTours.Remove(giaTour);
                            DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
                            dataGridView.DataSource = _busGiaTour.GetByTourId(_tour.maTour);
                            _form.Refresh();
                            data_GiaTour.DataSource = dataGridView.DataSource;
                            data_GiaTour.Refresh();
                        }
                    }
                }
            }
        }

        private void data_GiaTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = data_GiaTour.CurrentRow.Index;
            var giaTour = _tour.GiaTours.ToArray()[currentIndex];
            dateTimePicker1.Value = giaTour.ngayKhoiHanh;
            dateTimePicker2.Value = giaTour.ngayKetThuc;
            tb_Gia.Text = giaTour.thanhTien.ToString();
            btn_Xoa.Enabled = currentIndex != -1;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1)
            {
                MessageBox.Show("Hãy chọn giá tour cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                data_GiaTour.CurrentRow.Selected = true;
                currentIndex = data_GiaTour.CurrentRow.Index;
                var giaTour = _tour.GiaTours.ToArray()[currentIndex];
                giaTour.ngayKhoiHanh = dateTimePicker1.Value;
                giaTour.ngayKetThuc = dateTimePicker2.Value;
                try
                {
                    var thanhTien = decimal.Parse(tb_Gia.Text);
                    giaTour.thanhTien = thanhTien;
                }catch(Exception ex)
                {

                }
                if (MessageBox.Show("Bạn có chắc chắn cập giá tour này ?", "Cập nhật ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _busGiaTour.Update(giaTour);
                    DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
                    dataGridView.DataSource = _busGiaTour.GetByTourId(_tour.maTour);
                    _form.Refresh();
                    data_GiaTour.DataSource = dataGridView.DataSource;
                }
                
            }
        }
    }
}
