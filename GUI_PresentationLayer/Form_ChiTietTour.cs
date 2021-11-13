using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;
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
    public partial class Form_ChiTietTour : Form
    {
        public Tour _tour;
        
        public Form_ChiTietTour()
        {
            InitializeComponent();
           
        }

        public Form_ChiTietTour(Tour tour)
        {
            _tour = BUSTour.GetTour(tour.maTour);
            InitializeComponent();
        }

        private void Form_ChiTietTour_Load(object sender, EventArgs e)
        {
            lb_MaTour.Text += _tour.maTour.ToString();
            lb_TenTour.Text += _tour.tenTour;
            lb_DacDiem.Text += _tour.dacDiem;
            lb_KhachSan.Text += _tour.khachSan;
            lb_LoaiHinh.Text += _tour.LoaiHinhDuLich.tenLoaiHinh;
            lb_NoiDung.Text += _tour.noiDungTour;
            data_GiaTour.AutoGenerateColumns = false;
            data_GiaTour.ColumnCount = 3;
            List<String> propertyName = new List<String>() { "ngayKhoiHanh", "ngayKetThuc", "thanhTien" };
            for(int index = 0; index < data_GiaTour.ColumnCount; index++)
            {
                data_GiaTour.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            data_GiaTour.DataSource = _tour.GiaTours.ToList();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ColumnCount = 2;
            List<String> propertyName1 = new List<String>() { "Key","Value" };
           
            for(int index = 0; index < dataGridView1.ColumnCount; index++)
            {
                dataGridView1.Columns[index].DataPropertyName = propertyName1.ToArray().GetValue(index).ToString();
            }

            Dictionary<string,int> dic = new Dictionary<string,int>();
            foreach(ThamQuan thamQuan in _tour.ThamQuans)
            {
                dic.Add(thamQuan.DiaDiem.tenDiaDiem, thamQuan.thuTuThamQuan);
            }
            dataGridView1.DataSource = dic.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_LoaiHinh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_GiaTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ThemGia_Click(object sender, EventArgs e)
        {
            Form_ThemGia form = new Form_ThemGia(this);
            form.ShowDialog();
        }

        private void lb_ThemDiaDiem_Click(object sender, EventArgs e)
        {
            Form_ThemDiaDiem form = new Form_ThemDiaDiem(this);
            form.ShowDialog();
        }
    }
}
