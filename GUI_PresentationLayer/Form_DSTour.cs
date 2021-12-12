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
    public partial class Form_DSTour : Form
    {
        int currentIndex = 0;
        List<Tour> Tours;
        List<LoaiHinhDuLich> DSLoaiHinh;
        BUSTour _busTour;
        BUSLoaiHinhDuLich _busLoaiHinhDuLich;
        public Form_DSTour()
        {
            
            InitializeComponent();
            _busTour = new BUSTour();
            _busLoaiHinhDuLich = new BUSLoaiHinhDuLich();
            Tours = _busTour.GetTours().ToList();
            DSLoaiHinh = _busLoaiHinhDuLich.GetAll().ToList();
        }

        private void Form_DSTour_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(BUSTour.GetTour().Count);
            //không cho nó tự generate
            dataGridView1.AutoGenerateColumns = false;
            //gắn cứng cho số cột của table là 4
            dataGridView1.ColumnCount = 4;
            //danh sách các thuộc tính cần hiển thị trên table
            List<String> propertyName = new List<string> {"tenTour", "khachSan", "noiDungTour", "dacDiem" };
            //thay đổi header
            for(int index = 0; index < dataGridView1.ColumnCount; index++)
            {
                dataGridView1.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            dataGridView1.DataSource = Tours;

            cb_LoaiHinh.DataSource = DSLoaiHinh.Select(tour => tour.tenLoaiHinh).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            currentIndex = dataGridView1.CurrentRow.Index;
            var tour = Tours[currentIndex];
            tb__TenTour.Text=tour.tenTour;
            tb_TenKhachSan.Text=tour.khachSan;
            tb_DacDiem.Text = tour.dacDiem;
            cb_LoaiHinh.SelectedItem=tour.LoaiHinhDuLich.tenLoaiHinh;
            tb_NoiDung.Text = tour.noiDungTour;
        }   


        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tb_TiemKiem_TextChanged(object sender, EventArgs e)
        {
            var searchString = tb_TiemKiem.Text;
            var tours = Tours.Where(tour => tour.tenTour.Contains(searchString)).Select(tour => tour).ToList();
            if (tours != null)
            {
                dataGridView1.DataSource = tours;
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = Tours;
                dataGridView1.Refresh();
               
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            var tenTour = tb__TenTour.Text;
            var tenKhachSan = tb_TenKhachSan.Text;
            var dacDiem = tb_DacDiem.Text;
            var loaiHinh = DSLoaiHinh[cb_LoaiHinh.SelectedIndex].maLoaiHinh;
            var noiDung = tb_NoiDung.Text;
           

            var tour = new Tour
            {
                tenTour = tenTour,
                khachSan = tenKhachSan,
                dacDiem = dacDiem,
                maLoaiHinh = loaiHinh,
                noiDungTour = noiDung,
                trangThai = true
            };
            ValidationContext context = new ValidationContext(tour, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            StringBuilder stringBuilder = new StringBuilder();
            if (!Validator.TryValidateObject(tour, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                    stringBuilder.Append(result + "\n");
                MessageBox.Show(stringBuilder.ToString(),"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                _busTour.Create(tour);
                Tours = _busTour.GetTours().ToList();
                dataGridView1.DataSource = Tours;
                dataGridView1.Update();
                dataGridView1.Refresh();
              
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            currentIndex = dataGridView1.CurrentRow.Index;
            // gọi xuống bus để lấy thông tin tour
            var tour = Tours[currentIndex];
            // khởi tạo form chi tiết và truyền vào tuor vừa tìm được
            Form_ChiTietTour formChiTietTour = new Form_ChiTietTour(tour);
            formChiTietTour.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenTour = tb__TenTour.Text;
            var tenKhachSan = tb_TenKhachSan.Text;
            var dacDiem = tb_DacDiem.Text;
            var loaiHinh = DSLoaiHinh[cb_LoaiHinh.SelectedIndex].maLoaiHinh;
            var noiDung = tb_NoiDung.Text;
            dataGridView1.CurrentRow.Selected = true;
            currentIndex = dataGridView1.CurrentRow.Index;
            var tour = Tours[currentIndex];
            tour.tenTour = tenTour;
            tour.khachSan = tenKhachSan;
            tour.dacDiem = dacDiem;
            tour.maLoaiHinh = loaiHinh;
            tour.noiDungTour = noiDung;
            tour.LoaiHinhDuLich.maLoaiHinh = DSLoaiHinh[cb_LoaiHinh.SelectedIndex].maLoaiHinh;
            MessageBox.Show(tour.LoaiHinhDuLich.maLoaiHinh.ToString());
            tour.trangThai = true;
            ValidationContext context = new ValidationContext(tour, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            StringBuilder stringBuilder = new StringBuilder();
            if (!Validator.TryValidateObject(tour, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                    stringBuilder.Append(result + "\n");
                MessageBox.Show(stringBuilder.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn cập nhật tour này ?", "Cập nhật ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _busTour.Update(tour);
                    Tours = _busTour.GetTours().ToList();
                    dataGridView1.DataSource = Tours;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            currentIndex = dataGridView1.CurrentRow.Index;
            var tour = Tours[currentIndex];
            tour.trangThai = false;
            if (MessageBox.Show("Bạn có chắc chắn xóa tour này ?", "Cập nhật ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _busTour.Update(tour);
                Tours = _busTour.GetTours().ToList();
                dataGridView1.DataSource = Tours;
                dataGridView1.Update();
                dataGridView1.Refresh();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
