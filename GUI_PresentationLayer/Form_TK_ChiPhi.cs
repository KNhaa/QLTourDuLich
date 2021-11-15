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
using static DAL_DataAccessLayer.DALServices.DAOThongKeChiPhi;

namespace GUI_PresentationLayer
{
    public partial class Form_TK_ChiPhi : Form
    {
        //List<KetQuaTKCP> listThongKe;
        List<Tour> listTour;
        BUSThongKeChiPhi bus = new BUSThongKeChiPhi();
        public Form_TK_ChiPhi()
        {
            InitializeComponent();
            listTour = BUSTour.GetTours().ToList();
        }

        private void dataViewTKCP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_TK_ChiPhi_Load(object sender, EventArgs e)
        {
            cbTour.DataSource = listTour.Select(x => x.maTour).ToList();
            dataViewTKCP.DataSource = bus.loadChiPhiTatCa();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateStart = datePickerStart.Value.Date;
            DateTime dateEnd = datePickerEnd.Value.Date;

            if (dateEnd >= dateStart)
            {
                if (cbTour.SelectedValue != null)
                {
                    int idTourSelected = int.Parse(cbTour.SelectedItem.ToString());
                    dataViewTKCP.DataSource = bus.loadChiPhiTheoNgayMaTour(dateStart, dateEnd, idTourSelected);
                    tinhTongTien();
                }
                else
                    //int selected = cbTour.SelectedItem.
                    dataViewTKCP.DataSource = bus.loadChiPhiTheoNgay(dateStart, dateEnd);
            }    
            else
                MessageBox.Show("Nhập sai. Ngày kết thúc phải lớn hơn Ngày khởi hành !!!", "Lưu ý");
        }

        private void tinhTongTien()
        {
            decimal sum = 0;
            for (int i = 0; i < dataViewTKCP.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataViewTKCP.Rows[i].Cells[3].Value);
            }

            lbTongTien.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
