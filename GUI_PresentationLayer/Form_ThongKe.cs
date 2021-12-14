using BUS_BussinessLayer.BUSServices;
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
using static DAL_DataAccessLayer.DALServices.DAO_TK_Tour;
using static DAL_DataAccessLayer.DALServices.DAOThongKeNhanVien;

namespace GUI_PresentationLayer
{
    public partial class Form_ThongKe : Form
    {
        List<Doan> Doans;
        List<T> Tours;
        BUSTour _busTour;

        List<Tour> listTour;
        BUSThongKeChiPhi busTKCPhi = new BUSThongKeChiPhi(); // dùng để thống kê chi phí
        BUSThongKeNhanVien busTKNV = new BUSThongKeNhanVien(); // dùng để thống kê nhân viên
        BUS_TK_DoanhThu busTKDT = new BUS_TK_DoanhThu();
        BUS_TK_Tour busTKT = new BUS_TK_Tour();
        public Form_ThongKe()
        {
            InitializeComponent();
            _busTour = new BUSTour();
            listTour = _busTour.GetTours().ToList(); //dùng để thống kê chi phí
            Doans = busTKDT.GetDoans().ToList();
            Tours = busTKT.GetTours().ToList();
            
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            tabChiPhi_Click();
        }      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabTour)
            {
                tabTour_Click();
            }
           if(tabControl1.SelectedTab==tabDoanhThu)
            {
                tabDoanhThu_Click();
            }
           
           if(tabControl1.SelectedTab == tabChiPhi)
            {
                tabChiPhi_Click();
            }


            if (tabControl1.SelectedTab == tabNhanVien)
            {
                tabNhanVien_Click();
            }



        }
        private void tabDoanhThu_Click()
        {
            
            //Clear the binding.
            dataGridViewTK.DataSource = null;

            //không cho nó tự generate
            dataGridViewTK.AutoGenerateColumns = false;
            //gắn cứng cho số cột của table là 4
            dataGridViewTK.ColumnCount = 4;
            //danh sách các thuộc tính cần hiển thị trên table
            List<String> propertyName = new List<string> { "maDoan", "ngayKhoiHanh", "ngayKetThuc", "doanhThu" };

            //thay đổi header
            for (int index = 0; index < dataGridViewTK.ColumnCount; index++)
            {
                dataGridViewTK.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            dataGridViewTK.DataSource = Doans;
            label8.ResetText();

            //tinh tong doanh thu
            var sum = Doans.Select(c => c.doanhThu).Sum();
            label8.Text = doitien(sum);

            //tao combo-box ma doan
            var ketqua = from doan in Doans
                         select doan.maDoan;

            List<string> myList = new List<string>();
            myList.Add(" ");
            foreach (var x in ketqua)
                myList.Add(x.ToString());

            cb_tk_maDoan.DataSource = myList;
        }

        //nut tim kiem
        private void btnTKDoanhThu_Click(object sender, EventArgs e)
        {
            if(cb_tk_maDoan.Text==" ")
            {   
            
                var tungay = dateTimePicker1.Value.Date;
                var denngay = dateTimePicker2.Value.Date;

                var ketqua = busTKDT.GetDoansFrom(tungay, denngay).ToList();
                dataGridViewTK.DataSource = ketqua;
                dataGridViewTK.Refresh();

                //tinh tong doanh thu
                var sum = ketqua.Select(c => c.doanhThu).Sum();
                label8.Text = doitien(sum);
            }
            else
            {
                
                var tungay = dateTimePicker1.Value.Date;
                var denngay = dateTimePicker2.Value.Date;
                var madoan = cb_tk_maDoan.Text;

                // MessageBox.Show(tungay + " -> " + denngay,"Thông báo");

                var ketqua = busTKDT.tkMaDoan(tungay, denngay, madoan).ToList();

                dataGridViewTK.DataSource = ketqua;
                dataGridViewTK.Refresh();

                //tinh tong doanh thu
                var sum = ketqua.Select(c => c.doanhThu).Sum();
                label8.Text = doitien(sum);
            }

        }

        //nut reset
        private void button1_Click(object sender, EventArgs e)
        {
            cb_tk_maDoan.Text = " ";
            dataGridViewTK.DataSource = Doans;
            label8.ResetText();

            //tinh tong doanh thu
            var sum = Doans.Select(c => c.doanhThu).Sum();
            label8.Text = doitien(sum);
        }

        public String doitien(float sum)
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            var chuyendoi = String.Format(info, "{0:c}", sum);
            return chuyendoi;
        }
      
        private void tabTour_Click()
        {
            
            //Clear the binding.
            dtgvTK_Tour.DataSource = null;

            //không cho nó tự generate
            dtgvTK_Tour.AutoGenerateColumns = false;

            //gắn cứng cho số cột của table là 6
            dtgvTK_Tour.ColumnCount = 6;

            //danh sách các thuộc tính cần hiển thị trên table
            List<String> propertyName = new List<string> { "maTourTK", "tenTourTK", "maDoanTK", "ngayKhoiHanhTK", "ngayKetThucTK", "giaTourTK" };

            //thay đổi header
            for (int index = 0; index < dtgvTK_Tour.ColumnCount; index++)
            {
                dtgvTK_Tour.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }

            dtgvTK_Tour.DataSource = Tours;

            //tao combo-box ma tour
            var ketqua = (from doan in Tours
                         select doan.maTourTK).Distinct().ToList();

            List<string> myList = new List<string>();
            myList.Add(" ");
            foreach (var x in ketqua)
                myList.Add(x.ToString());

            comboBox1.DataSource = myList;

            label13.ResetText();
            label14.ResetText();

            //tinh tong doanh so
            var sum = Tours.Select(c => c.giaTourTK).Sum();
            label14.Text = doitien((float)sum);

            //tinh tong so doan
            var sumDoan = Tours.Select(c => c.maDoanTK).Distinct().Count();
            label13.Text = sumDoan.ToString();

           


        }

        //nut tim kiem trong tab tour
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == " ")
            {
                var tungay = dateTimePicker3.Value.Date;
                var denngay = dateTimePicker4.Value.Date;
                var ketqua = busTKT.GetToursFrom(tungay, denngay).ToList();

                dtgvTK_Tour.DataSource = ketqua;
                dtgvTK_Tour.Refresh();

                //tinh tong doanh so
                var sum = ketqua.Select(c => c.giaTourTK).Sum();
                label14.Text = doitien((float)sum);

                //tinh tong so doan
                var sumDoan = ketqua.Select(c => c.maDoanTK).Distinct().Count();
                label13.Text = sumDoan.ToString();

            }
            else
            {
                var tungay = dateTimePicker3.Value.Date;
                var denngay = dateTimePicker4.Value.Date;
                string matour = comboBox1.Text;

                var ketqua = busTKT.tkMaTour(tungay, denngay,matour).ToList();
                dtgvTK_Tour.DataSource = ketqua;
                dtgvTK_Tour.Refresh();

                //tinh tong doanh so
                var sum = ketqua.Select(c => c.giaTourTK).Sum();
                label14.Text = doitien((float)sum);

                //tinh tong so doan
                var sumDoan = ketqua.Select(c => c.maDoanTK).Distinct().Count();
                label13.Text = sumDoan.ToString();

            }
        }

        //nut reset trong tab Tour
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            dtgvTK_Tour.DataSource = Tours;
            label13.ResetText();
            label14.ResetText();

            //tinh tong doanh so
            var sum = Tours.Select(c => c.giaTourTK).Sum();
            label14.Text = doitien((float)sum);

            //tinh tong so doan
            var sumDoan = Tours.Select(c => c.maDoanTK).Distinct().Count();
            label13.Text = sumDoan.ToString();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

       
        //===================================THỐNG KÊ CHI PHÍ - NHÂN VIÊN===========================================
        private void tabChiPhi_Click()
        {

            cbTour.DataSource = listTour.Select(x => x.maTour).ToList();
            //dgv.DataSource = bus.loadChiPhiTatCa();
            dgvTKChiPhi.DataSource = busTKCPhi.loadChiPhiTatCa();

            //Clear the binding.
            dgvTKChiPhi.DataSource = null;

            //không cho nó tự generate
            dgvTKChiPhi.AutoGenerateColumns = false;

            //gắn cứng cho số cột của table là 4
            dgvTKChiPhi.ColumnCount = 4;
            //danh sách các thuộc tính cần hiển thị trên table
            List<String> propertyName = new List<string> { "maTour", "tenTour", "tenLoaiChiPhi", "tongChiPhi" };

            //thay đổi header
            for (int index = 0; index < dgvTKChiPhi.ColumnCount; index++)
            {
                dgvTKChiPhi.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }

            dgvTKChiPhi.DataSource = busTKCPhi.loadChiPhiTatCa();
            tinhTongTienChiPhi();
            customizeDataView(dgvTKChiPhi);


        }

        private void btnTKChiPhi_Click(object sender, EventArgs e)
        {
            DateTime dateStart = datePickerStartChiPhi.Value.Date;
            DateTime dateEnd = datePickerEndChiPhi.Value.Date;

            if (dateEnd >= dateStart)
            {
                if (cbTour.SelectedValue != null)
                {
                    int idTourSelected = int.Parse(cbTour.SelectedItem.ToString());
                    dgvTKChiPhi.DataSource = busTKCPhi.loadChiPhiTheoNgayMaTour(dateStart, dateEnd, idTourSelected);
                    tinhTongTienChiPhi();
                }
                else
                {
                    //int selected = cbTour.SelectedItem.
                    dgvTKChiPhi.DataSource = busTKCPhi.loadChiPhiTheoNgay(dateStart, dateEnd);
                    tinhTongTienChiPhi();
                }
            }    
                   
            else
                MessageBox.Show("Nhập sai. Ngày kết thúc phải lớn hơn Ngày khởi hành !!!", "Lưu ý");
        }

        private void tinhTongTienChiPhi()
        {
            decimal sum = 0;
            for (int i = 0; i < dgvTKChiPhi.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvTKChiPhi.Rows[i].Cells[3].Value);
            }

            lbTienChiPhi.Text = sum.ToString()+" VNĐ";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabNhanVien_Click()
        {
            //Clear the binding.
            dgvTKNV.DataSource = null;
            //không cho nó tự generate
            dgvTKNV.AutoGenerateColumns = false;
            //gắn cứng cho số cột của table là 3
            dgvTKNV.ColumnCount = 3;
            //danh sách các thuộc tính cần hiển thị trên table
            List<String> propertyName = new List<string> { "MaNV", "TenNV", "SoLuong" };

            //thay đổi header
            for (int index = 0; index < dgvTKNV.ColumnCount; index++)
            {
                dgvTKNV.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }

            dgvTKNV.DataSource = busTKNV.thongkeTatCaNgay();
            customizeDataView(dgvTKNV);

        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            DateTime dateStart = datePickerStartTKNV.Value.Date;
            DateTime dateEnd = datePickerEndTKNV.Value.Date;

            if (dateEnd >= dateStart)
                dgvTKNV.DataSource = busTKNV.thongkeTheoNgay(dateStart, dateEnd);
            else
                MessageBox.Show("Nhập sai. Ngày kết thúc phải lớn hơn Ngày khởi hành !!!", "Lưu ý");
        }

        // hàm chỉnh giao diện data gridview
        private void customizeDataView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;           
            dgv.BackgroundColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(14, 42, 85);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dtgvTK_Tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabTour_Click(object sender, EventArgs e)
        {

        }
    }
    
}
