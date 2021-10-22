using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer;
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
        public BUSLoaiHinhDuLich _busLoaiHinh;
        public BUSGiaTour _busGiaTour;
        public Form_ChiTietTour()
        {
            InitializeComponent();
            _busLoaiHinh = new BUSLoaiHinhDuLich();
            _busGiaTour = new BUSGiaTour();
        }

        public Form_ChiTietTour(Tour tour)
        {
            _tour = tour;
            _busLoaiHinh = new BUSLoaiHinhDuLich();
            _busGiaTour = new BUSGiaTour();
            InitializeComponent();
        }

        private void Form_ChiTietTour_Load(object sender, EventArgs e)
        {
            lb_MaTour.Text += _tour.maTour.ToString();
            lb_TenTour.Text += _tour.tenTour;
            lb_DacDiem.Text += _tour.dacDiem;
            lb_KhachSan.Text += _tour.khachSan;
            lb_LoaiHinh.Text += _busLoaiHinh.GetItemById(_tour.maLoaiHinh).tenLoaiHinh;
            lb_NoiDung.Text += _tour.noiDungTour;
            data_GiaTour.AutoGenerateColumns = false;
            data_GiaTour.ColumnCount = 3;
            List<String> propertyName = new List<String>() { "ngayKhoiHanh", "ngayKetThuc", "thanhTien" };
            for(int index = 0; index < data_GiaTour.ColumnCount; index++)
            {
                data_GiaTour.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            data_GiaTour.DataSource = _busGiaTour.GetListItemByTourId(_tour.maTour);
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
    }
}
