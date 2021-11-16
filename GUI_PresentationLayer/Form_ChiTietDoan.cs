using DAL_DataAccessLayer.Entities;
using System;
using BUS_BussinessLayer.BUSServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL_DataAccessLayer.DALServices.DAOChiTietDoan;

namespace GUI_PresentationLayer
{
    public partial class Form_ChiTietDoan : Form
    {
        Doan doan;
        ChiTietDoan ctDoan;
        List<newDiaDiem> dsDiaDiem;
        List<newChiPhi> dsChiPhi;
        List<newNhanVien> dsNhanVien;
        List<Khach> dsKhach;
        List<LoaiChiPhi> loaiCP;
        List<NhanVien> nhanVien;
        public Form_ChiTietDoan()
        {
            InitializeComponent();
        }

        public Form_ChiTietDoan(Doan doan)
        {
            this.doan = doan;
            ctDoan = BUSChiTietDoan.GetChiTietDoan(doan);
            dsChiPhi = BUSChiTietDoan.GetDsChiPhi(doan).ToList();
            dsNhanVien = BUSChiTietDoan.GetDsNhanVien(doan).ToList();
            loaiCP = BUSChiTietDoan.GetLoaiChiPhi().ToList();
            InitializeComponent();
        }

        private void Form_ChiTietDoan_Load(object sender, EventArgs e)
        {
            lbtMadoan.Text = ctDoan.maDoan.ToString();
            lbtNgkhoihanh.Text = ctDoan.ngKhoiHanh.ToString();
            lbtNgketthuc.Text = ctDoan.ngKetThuc.ToString();
            lbtTenTour.Text = ctDoan.tenTour;
            lbtSoluongkhach.Text = ctDoan.sLKhach.ToString();
            lbtDoanhthu.Text = ctDoan.dThu.ToString();
            lbtNoidung.Text = ctDoan.noiDung;
            tabDiaDiam_Show();
        }

        private void tabThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabThongTin.SelectedTab == tabDiaDiem)
            {
                tabDiaDiam_Show();
            } else if (tabThongTin.SelectedTab == tabKhach)
            {
                tabKhach_Show();
            } else if (tabThongTin.SelectedTab == tabChiPhi)
            {
                tabChiPhi_Show();
            } else
            {
                tabNhanVien_Show();
            }
        }

        private void tabDiaDiam_Show()
        {
            dgvDiaDiem.DataSource = null;
            dsDiaDiem = BUSChiTietDoan.GetDiaDiem(doan).ToList();
            dgvDiaDiem.AutoGenerateColumns = false;
            dgvDiaDiem.ColumnCount = 2;

            List<String> lName = new List<string> { "diaDiem", "TTdiaDiem"};
            for (int index = 0; index < dgvDiaDiem.ColumnCount; index++)
            {
                dgvDiaDiem.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }

            dgvDiaDiem.DataSource = dsDiaDiem;
        }

        private void tabKhach_Show()
        {
            dgvKhach.DataSource = null;
            dsKhach = BUSChiTietDoan.GetDsKhach(doan).ToList();
            dgvKhach.AutoGenerateColumns = false;
            dgvKhach.ColumnCount = 5;

            List<String> lName = new List<string> { "tenKh", "diaChi", "cnmd", "gioiTinh", "sdt" };
            for (int index = 0; index < dgvKhach.ColumnCount; index++)
            {
                dgvKhach.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }
            dgvKhach.DataSource = dsKhach;

            dsKhach = BUSKhachHang.getListKhachHang().ToList();
            List<String> ttKhach = new List<String>();
            foreach (Khach kh in dsKhach)
            {
                String s = kh.maKh + " - " + kh.tenKh;
                ttKhach.Add(s);
            }
            cbxKhach.DataSource = ttKhach;
        }

        private void tabChiPhi_Show()
        {
            dgvChiPhi.DataSource = null;
            dsChiPhi = BUSChiTietDoan.GetDsChiPhi(doan).ToList();
            dgvChiPhi.AutoGenerateColumns = false;
            dgvChiPhi.ColumnCount = 3;

            List<String> lName = new List<string> { "chiPhi", "soTien", "tenLoaiCP" };
            for (int index = 0; index < dgvChiPhi.ColumnCount; index++)
            {
                dgvChiPhi.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }

            dgvChiPhi.DataSource = dsChiPhi;
            List<String> lcp = new List<String>();
            foreach (LoaiChiPhi cp in loaiCP)
            {
                lcp.Add(cp.tenLoaiCP);
            }
            cbxLoaiChiphi.DataSource = lcp;
        }

        private void tabNhanVien_Show()
        {
            dgvNhanVien.DataSource = null;
            dsNhanVien = BUSChiTietDoan.GetDsNhanVien(doan).ToList();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.ColumnCount = 2;

            List<String> lName = new List<string> { "tenNV", "nhiemVu"};
            for (int index = 0; index < dgvNhanVien.ColumnCount; index++)
            {
                dgvNhanVien.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }

            dgvNhanVien.DataSource = dsNhanVien;
            nhanVien = BUSChiTietDoan.GetNhanVien().ToList();
            List<String> ttNV = new List<String>();
            foreach (NhanVien nv in nhanVien)
            {
                String s = nv.maNv + " - " + nv.tenNv;
                ttNV.Add(s);
            }
            cbxNhanvien.DataSource = ttNV;
        }

        private void btnNewkhach_Click(object sender, EventArgs e)
        {
            Form_DSKhachHang dsKhachHang = new Form_DSKhachHang();
            dsKhachHang.Show();
        }

        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            int index = cbxKhach.SelectedIndex;
            ChiTiet ct = new ChiTiet();
            Khach kh = dsKhach[index];
            ct.maDoan = doan.maDoan;
            ct.maKh = kh.maKh;
            BUSChiTietDoan.addKhach(ct);
            tabKhach_Show();
        }

        private void btnThemchiphi_Click(object sender, EventArgs e)
        {
            try
            {
                decimal soTien = Decimal.Parse(txtSoTien.Text);
                int index = (int)cbxLoaiChiphi.SelectedIndex;
                ChiPhi cp = new ChiPhi();
                LoaiChiPhi lcp = loaiCP[index];
                cp.soTien = soTien;
                cp.maDoan = doan.maDoan;
                cp.maLoaiCP = lcp.maLoaiCP;
                BUSChiTietDoan.addChiPhi(cp);
                tabChiPhi_Show();
            }
            catch
            {
                MessageBox.Show("Số tiền phải là kiểu decimal.", "Cảnh báo");
            }
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            int index = cbxNhanvien.SelectedIndex;
            NhanVien nv = nhanVien[index];
            PhanBo pb = new PhanBo();
            pb.maDoan = doan.maDoan;
            pb.maNv = nv.maNv;
            pb.nhiemVu = txtNhiemVu.Text;
            BUSChiTietDoan.addNhanVienDoan(pb);
            tabNhanVien_Show();
        }

        private void btnNewnhanvien_Click(object sender, EventArgs e)
        {
            Form_AddNhanVien addNV = new Form_AddNhanVien();
            addNV.Show();
        }
    }
}
