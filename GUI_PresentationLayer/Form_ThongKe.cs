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

namespace GUI_PresentationLayer
{
    public partial class Form_ThongKe : Form
    {
        List<Doan> Doans;
        List<T> Tours;
        public Form_ThongKe()
        {
            InitializeComponent();
            Doans = BUS_TK_DoanhThu.GetDoans().ToList();
            Tours = BUS_TK_Tour.GetTours().ToList();
            
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void tabChiPhi_Click(object sender, EventArgs e)
        {
            

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

                var ketqua = BUS_TK_DoanhThu.GetDoansFrom(tungay, denngay).ToList();
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

                var ketqua = BUS_TK_DoanhThu.tkMaDoan(tungay, denngay, madoan).ToList();

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

            //tao combo-box ma doan
            var ketqua = from doan in Tours
                         select doan.maDoanTK;

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
            var sumDoan = Tours.Select(c => c.maDoanTK).Count();
            label13.Text = sumDoan.ToString();


        }

        //nut tim kiem trong tab tour
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == " ")
            {
                var tungay = dateTimePicker3.Value.Date;
                var denngay = dateTimePicker4.Value.Date;
                var ketqua = BUS_TK_Tour.GetToursFrom(tungay, denngay).ToList();

                dtgvTK_Tour.DataSource = ketqua;
                dtgvTK_Tour.Refresh();

                //tinh tong doanh so
                var sum = ketqua.Select(c => c.giaTourTK).Sum();
                label14.Text = doitien((float)sum);

                //tinh tong so doan
                var sumDoan = ketqua.Select(c => c.maDoanTK).Count();
                label13.Text = sumDoan.ToString();

            }
            else
            {
                var tungay = dateTimePicker3.Value.Date;
                var denngay = dateTimePicker4.Value.Date;
                string matour = comboBox1.Text;

                var ketqua = BUS_TK_Tour.tkMaTour(tungay, denngay,matour).ToList();
                dtgvTK_Tour.DataSource = ketqua;
                dtgvTK_Tour.Refresh();

                //tinh tong doanh so
                var sum = ketqua.Select(c => c.giaTourTK).Sum();
                label14.Text = doitien((float)sum);

                //tinh tong so doan
                var sumDoan = ketqua.Select(c => c.maDoanTK).Count();
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
            var sumDoan = Tours.Select(c => c.maDoanTK).Count();
            label13.Text = sumDoan.ToString();

        }

      
    }
    
}
