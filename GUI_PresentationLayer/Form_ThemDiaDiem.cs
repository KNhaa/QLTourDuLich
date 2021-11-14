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
    public partial class Form_ThemDiaDiem : Form
    {
        public int currentIndex = -1;
        List<DiaDiem> DSDiaDiem;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Form_ChiTietTour _form;
        
        public Form_ThemDiaDiem(Form_ChiTietTour form)
        {
            InitializeComponent();
            DSDiaDiem = BUSDiaDiem.GetAll().ToList();
            _form = form;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //DSDiaDiem = BUSDiaDiem.GetAll().ToList();
            var diaDiem = DSDiaDiem[cb_DiaChi.SelectedIndex];
            var nextItem = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Value;
            if (!dictionary.ContainsKey(diaDiem.tenDiaDiem))
            {
                dictionary.Add(diaDiem.tenDiaDiem, nextItem + 1);
                if (_form._tour.ThamQuans.Count == 0)
                {
                    _form._tour.ThamQuans = new List<ThamQuan>();
                }
                var thamQuan = new ThamQuan { maDiaDiem = diaDiem.maDiaDiem, thuTuThamQuan = nextItem + 1 };
                //thamQuan.DiaDiem = diaDiem;
                _form._tour.ThamQuans.Add(thamQuan);
                BUSTour.Update(_form._tour);
            //    this.Refresh();
                LoadData();
            }
            else
            {
                MessageBox.Show("Địa Điểm Này Đã Có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form_ThemDiaDiem_Load(object sender, EventArgs e)
        {
            //DSDiaDiem = BUSDiaDiem.GetAll().ToList();

            cb_DiaChi.DataSource = DSDiaDiem.Select(diadiem => diadiem.tenDiaDiem).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 2;
            List<String> propertyName = new List<String>() { "Key", "Value" };
            for (int index = 0; index < dataGridView1.ColumnCount; index++)
            {
                dataGridView1.Columns[index].DataPropertyName = propertyName.ToArray().GetValue(index).ToString();
            }
            LoadData();
            
        }

        private void lb_ThemMoiDiaDiem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dataGridView1.CurrentCell.RowIndex;
            btn_Up.Enabled = currentIndex!=-1;
            btn_Down.Enabled = currentIndex != -1;
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            var firstIndex = 1;
            var lastIndex = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Value;
            var obj = dataGridView1.Rows[currentIndex].Cells["col_TenDiaDiem"].Value.ToString();
            var objIndex = dictionary[obj];
            if (objIndex == firstIndex)
            {
                MessageBox.Show("Địa điểm đang ở vị trí đầu tiên");
            }
            else
            {   
                var beforeObj = dictionary.FirstOrDefault(x => x.Value ==objIndex-1).Key;
                dictionary[obj] = objIndex - 1;
                dictionary[beforeObj] = dictionary[beforeObj] + 1;
                dataGridView1.DataSource = dictionary;
                UpdateData();
                LoadData();
            }
        }
        private void btn_Down_Click(object sender, EventArgs e)
        {
            var lastIndex = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Value;
            var obj = dataGridView1.Rows[currentIndex].Cells["col_TenDiaDiem"].Value.ToString();
            var objIndex = dictionary[obj];
            if (objIndex == lastIndex)
            {
                MessageBox.Show("Địa điểm đang ở vị trí cuối cùng");
            }
            else
            {
                var afterObj = dictionary.FirstOrDefault(x => x.Value == objIndex+1).Key;
                dictionary[obj] = objIndex + 1;
                dictionary[afterObj] = dictionary[afterObj] - 1;
                dataGridView1.DataSource = dictionary;
                UpdateData();
                LoadData();
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1)
            {
                MessageBox.Show("Hãy chọn địa điểm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var col = dataGridView1.Rows[currentIndex].Cells["col_TenDiaDiem"].Value.ToString();
                dictionary.OrderByDescending(x => x.Value).ToList();
                dictionary.Remove(col);
                var i = 1;
                foreach (KeyValuePair<string, int> item in dictionary)
                {
                    var value = item.Value; 
                        value = i;
                    
                    MessageBox.Show(value.ToString());
                    i++;
                }

                UpdateData();
                LoadData();
            }
        }

        public void LoadData()
        {
            this.Refresh();
            DSDiaDiem = BUSDiaDiem.GetAll().ToList();

            DataGridView dataGridView = (DataGridView)_form.Controls["dataGridView1"];
            dataGridView.Update();
            dataGridView.Refresh();
            _form.Refresh();
            //dictionary.Clear();
            foreach (ThamQuan thamQuan in _form._tour.ThamQuans)
            {
                
               
                if (thamQuan.DiaDiem != null)
                {
                    if (!dictionary.ContainsKey(thamQuan.DiaDiem.tenDiaDiem)) 
                    {
                        dictionary.Add(thamQuan.DiaDiem.tenDiaDiem, thamQuan.thuTuThamQuan);
                    }
                    
                }
                
            }
            dataGridView.DataSource = dictionary.OrderBy(x => x.Value).ToList();
            dataGridView1.DataSource = dataGridView.DataSource;
            dataGridView1.Refresh();
        }

        public void UpdateData()   
        {
            foreach(var item in _form._tour.ThamQuans)
            {
                if (dictionary.ContainsKey(item.DiaDiem.tenDiaDiem))
                {
                    item.thuTuThamQuan = dictionary[item.DiaDiem.tenDiaDiem];
                }
                else
                {
                    _form._tour.ThamQuans.Remove(item);
                }
            }
            BUSTour.UpdateData(_form._tour);
     
        }
    }
}
