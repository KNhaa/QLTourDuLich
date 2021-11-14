using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.DALServices;
using BUS_BussinessLayer.BUSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_DataAccessLayer.Entities;
using static DAL_DataAccessLayer.DALServices.DAOThongKeNhanVien;

namespace GUI_PresentationLayer
{
    public partial class Form_TK_NhanVien : Form
    {
        public static QuanLiTourDbContext context = new QuanLiTourDbContext();
        List<KetQuaTKNV> listThongKe;
        BUSThongKeNhanVien bus = new BUSThongKeNhanVien();

        public Form_TK_NhanVien()
        {
            InitializeComponent();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class NhanVienTK
        {
            public int maNv { get; set; }
            public string tenNv { get; set; }
            public int maDoan { get; set; }

            public DateTime ngayBatDau { get; set; }
            public DateTime ngayKetThuc { get; set; }
            //public int soluong { get; set; }          
        }

        public class KetQua
        {
            public int MaNV { get; set; }
            public string TenNV { get; set; }
            public int SoLuong { get; set; }
        }

         private void Form_TK_NhanVien_Load(object sender, EventArgs e)
         {
            listThongKe = bus.thongkeTatCaNgay();
            dataViewTKNV.DataSource = listThongKe;
            

          }

        private void customizeDataView()
        {
            dataViewTKNV.BorderStyle = BorderStyle.None;
            dataViewTKNV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataViewTKNV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataViewTKNV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataViewTKNV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataViewTKNV.BackgroundColor = Color.White;

            dataViewTKNV.EnableHeadersVisualStyles = false;
            dataViewTKNV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataViewTKNV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataViewTKNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }         

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //nut ThongKe
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateStart = datePickerStart.Value.Date;
            DateTime dateEnd = datePickerEnd.Value.Date;

            if (dateEnd >= dateStart)
                dataViewTKNV.DataSource = bus.thongkeTheoNgay(dateStart, dateEnd);
            else
                MessageBox.Show("Nhập sai. Ngày kết thúc phải lớn hơn Ngày khởi hành !!!", "Lưu ý");



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}