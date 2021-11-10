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
    public partial class Form_ThemGia : Form
    {
        public Form_ChiTietTour _form;
        int currentIndex = -1;
        public Form_ThemGia(Form_ChiTietTour form)
        {
            InitializeComponent();
            _form = form;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_NgayKhoiHanh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var giaTour = new GiaTour { 
                ngayKhoiHanh = dateTimePicker1.Value, 
                ngayKetThuc = dateTimePicker2.Value, 
                thanhTien = int.Parse(tb_Gia.Text),
                maTour=_form._tour.maTour};
            _form._tour.GiaTours.Add(giaTour);
            BUSGiaTour.Create(giaTour);
            DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
            dataGridView.DataSource = BUSGiaTour.GetByTourId(_form._tour.maTour);
            _form.Refresh();
            data_GiaTour.DataSource = dataGridView.DataSource;
            data_GiaTour.Refresh();
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
                    var giaTour = _form._tour.GiaTours.ToArray()[currentIndex];
                    if (giaTour != null)
                    {
                        BUSGiaTour.Delete(giaTour.maGiaTour);

                        _form._tour.GiaTours.Remove(giaTour);
                        DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
                        dataGridView.DataSource = BUSGiaTour.GetByTourId(_form._tour.maTour);
                        _form.Refresh();
                        data_GiaTour.DataSource = dataGridView.DataSource;
                        data_GiaTour.Refresh();
                       
                    }
                }
            }
        }

        private void data_GiaTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = data_GiaTour.CurrentRow.Index;
            var giaTour = _form._tour.GiaTours.ToArray()[currentIndex];
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
                var giaTour = _form._tour.GiaTours.ToArray()[currentIndex];
                BUSGiaTour.Update(giaTour);
                DataGridView dataGridView = (DataGridView)_form.Controls["data_GiaTour"];
                dataGridView.DataSource = BUSGiaTour.GetByTourId(_form._tour.maTour);
                _form.Refresh();
                data_GiaTour.DataSource = dataGridView.DataSource;
            }
        }
    }
}
