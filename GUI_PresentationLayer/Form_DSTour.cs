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

namespace GUI_PresentationLayer
{
    public partial class Form_DSTour : Form
    {
        BUSTour tourBUS;
        public Form_DSTour()
        {
            tourBUS = new BUSTour();
            InitializeComponent();
        }

        private void Form_DSTour_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(BUSTour.GetTour().Count);
            //không cho nó tự generate
            dataGridView1.AutoGenerateColumns = false;
            //gắn cứng cho số cột của table là 5
            dataGridView1.ColumnCount = 5;
            //danh sách các thuộc tính cần hiển thị trên table
            List<String> propertyName = new List<string> { "maTour", "tenTour", "khachSan", "noiDungTour", "dacDiem" };
            //thay đổi header
            for(int index = 0; index < dataGridView1.ColumnCount; index++)
            {
                dataGridView1.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            dataGridView1.DataSource = tourBUS.GetTours();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            // lấy ra ID
            // col_1 là tên của cột Mã Tour
            int tourID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["col_1"].Value.ToString());
            // gọi xuống bus để lấy thông tin tour
            var tour = tourBUS.GetTour(tourID);
            // khởi tạo form chi tiết và truyền vào tuor vừa tìm được
            Form_ChiTietTour formChiTietTour = new Form_ChiTietTour(tour);
            formChiTietTour.Show();
        }   

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
