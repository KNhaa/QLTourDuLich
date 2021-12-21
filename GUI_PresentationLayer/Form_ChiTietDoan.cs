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
using System.Globalization;

namespace GUI_PresentationLayer
{
    public partial class Form_ChiTietDoan : Form
    {
        Doan doan;
        ChiTietDoan ctDoan;
        List<newDiaDiem> dsDiaDiem;
        List<newChiPhi> dsChiPhi;
        List<newNhanVien> nvOfDoan;
        List<Khach> dsKhach, khachOfDoan;
        List<LoaiChiPhi> loaiCP;
        List<NhanVien> dsNhanVien;
        BUSChiTietDoan _busChiTietDoan;
        BUSKhachHang _busKhachHang;
        BUSDoan _busDoan;
        public Form_ChiTietDoan()
        {
            InitializeComponent();
        }

        public Form_ChiTietDoan(Doan doan)
        {
            this.doan = doan;
            _busChiTietDoan = new BUSChiTietDoan();
            _busKhachHang = new BUSKhachHang();
            _busDoan = new BUSDoan();
            ctDoan = _busChiTietDoan.GetChiTietDoan(doan);
            loaiCP = _busChiTietDoan.GetLoaiChiPhi().ToList();
           
            InitializeComponent();
        }

        private void Form_ChiTietDoan_Load(object sender, EventArgs e)
        {
            lbtMadoan.Text = ctDoan.maDoan.ToString();
            lbtNgkhoihanh.Text = ctDoan.ngKhoiHanh.ToString();
            lbtNgketthuc.Text = ctDoan.ngKetThuc.ToString();
            lbtTenTour.Text = ctDoan.tenTour;
            lbtSoluongkhach.Text = ctDoan.sLKhach.ToString();
            lbtDoanhthu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", ctDoan.doanhThu);
            lbtGia.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", ctDoan.giaTour);
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
            dsDiaDiem = _busChiTietDoan.GetDiaDiem(doan).ToList();
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
            khachOfDoan = _busChiTietDoan.GetDsKhach(doan).ToList();
            dgvKhach.AutoGenerateColumns = false;
            dgvKhach.ColumnCount = 5;
            List<String> lName = new List<string> { "tenKh", "diaChi", "cnmd", "gioiTinh", "sdt" };
            for (int index = 0; index < dgvKhach.ColumnCount; index++)
            {
                dgvKhach.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }
            dgvKhach.DataSource = khachOfDoan;

            dsKhach = _busKhachHang.getListKhachHang().ToList();
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
            dsChiPhi = _busChiTietDoan.GetDsChiPhi(doan).ToList();
            dgvChiPhi.AutoGenerateColumns = false;
            dgvChiPhi.ColumnCount = 3;

            List<String> lName = new List<string> { "chiPhi", "soTienFormat", "tenLoaiCP" };
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
            var tongTien = dsChiPhi.Select(cp => cp.soTien).Sum();
            lbtTongCP.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien);
        }

        private void tabNhanVien_Show()
        {
            dgvNhanVien.DataSource = null;
            nvOfDoan = _busChiTietDoan.GetDsNhanVien(doan).ToList();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.ColumnCount = 3;

            List<String> lName = new List<string> {"maNV", "tenNV", "nhiemVu"};
            for (int index = 0; index < dgvNhanVien.ColumnCount; index++)
            {
                dgvNhanVien.Columns[index].DataPropertyName = lName.ToArray().GetValue(index).ToString();
            }



            dgvNhanVien.DataSource = nvOfDoan;
            dsNhanVien = _busChiTietDoan.GetNhanVien().ToList();
            List<String> ttNV = new List<String>();
            foreach (NhanVien nv in dsNhanVien)
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
            if(dsKhach.Count == 0)
            {
                MessageBox.Show("Danh sách khách trống.", "Cảnh báo");
            } else
            {
                int index = cbxKhach.SelectedIndex;
                Khach kh = dsKhach[index];
                ChiTiet ct = new ChiTiet();
                var khach = khachOfDoan.Where(khachs => khachs.maKh == kh.maKh).Select(khachs => khachs).ToList();
                if (khach.Count == 0)
                {
                    ct.maDoan = doan.maDoan;
                    ct.maKh = kh.maKh;
                    _busChiTietDoan.addKhach(ct);
                    khachOfDoan = _busChiTietDoan.GetDsKhach(doan).ToList();
                    doan.doanhThu = (float)(khachOfDoan.Count * ctDoan.giaTour);
                    _busDoan.Update(doan);
                    lbtDoanhthu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", doan.doanhThu);
                    tabKhach_Show();
                }
                else
                {
                    MessageBox.Show("Đã có thông tin khách trong đoàn.", "Cảnh báo");
                }
            }
        }

        private void btnThemchiphi_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaiCP.Count == 0)
                {
                    MessageBox.Show("Loại chi phí trống.", "Cảnh báo");
                }
                else 
                {
                    decimal soTien = Decimal.Parse(txtSoTien.Text);
                    if(soTien < 1000)
                    {
                        MessageBox.Show("Số tiền không hợp lệ", "Cảnh báo");
                    }
                    else
                    {
                        int index = (int)cbxLoaiChiphi.SelectedIndex;
                        ChiPhi cp = new ChiPhi();
                        LoaiChiPhi lcp = loaiCP[index];
                        cp.soTien = soTien;
                        cp.maDoan = doan.maDoan;
                        cp.maLoaiCP = lcp.maLoaiCP;
                        _busChiTietDoan.addChiPhi(cp);
                        tabChiPhi_Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Số tiền không hợp lệ", "Cảnh báo");
            }
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            if (dsNhanVien.Count == 0)
            {
                MessageBox.Show("Danh sách nhân viên trống.", "Cảnh báo");
            }
            else
            {
                if (txtNhiemVu.Text != "")
                {
                    int index = cbxNhanvien.SelectedIndex;
                    NhanVien nv = dsNhanVien[index];
                    var nhanvien = nvOfDoan.Where(nhvien => nhvien.tenNV == nv.tenNv).Select(nhvien => nhvien).ToList();
                    if(nhanvien.Count == 0)
                    {
                        PhanBo pb = new PhanBo();
                        pb.maDoan = doan.maDoan;
                        pb.maNv = nv.maNv;
                        pb.nhiemVu = txtNhiemVu.Text;
                        _busChiTietDoan.addNhanVienDoan(pb);
                        tabNhanVien_Show();
                    } else
                    {
                        MessageBox.Show("Nhân viên đã có nhiệm vụ.", "Cảnh báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nhiệm vụ không được để trống.", "Cảnh báo");
                }
            }
        }

        private void btnXoaK_Click(object sender, EventArgs e)
        {
            var indexKh = dgvKhach.CurrentRow.Index;
            var khach = khachOfDoan[indexKh];
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không.", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ChiTiet ct = new ChiTiet();
                ct.maDoan = doan.maDoan;
                ct.maKh = khach.maKh;
                _busChiTietDoan.delKhach(ct);
                khachOfDoan = _busChiTietDoan.GetDsKhach(doan).ToList();
                doan.doanhThu = (float)(khachOfDoan.Count * ctDoan.giaTour);
                _busDoan.Update(doan);
                lbtDoanhthu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", doan.doanhThu);
                tabKhach_Show();
            }
        }

        private void btnXoaCP_Click(object sender, EventArgs e)
        {
            var indexCP = dgvChiPhi.CurrentRow.Index;
            var chiphi = dsChiPhi[indexCP];
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không.", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ChiPhi cp = new ChiPhi();
                cp.maDoan = doan.maDoan;
                cp.maChiPhi = chiphi.chiPhi;
                _busChiTietDoan.delChiPhi(cp);
                dsChiPhi = _busChiTietDoan.GetDsChiPhi(doan).ToList();
                tabChiPhi_Show();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            var indexNV = dgvNhanVien.CurrentRow.Index;
            var nhanvien = nvOfDoan[indexNV];
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không.", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                PhanBo pb = new PhanBo();
                pb.maNv = nhanvien.maNV;
                pb.maDoan = doan.maDoan;
                _busChiTietDoan.delNhanVien(pb);
                nvOfDoan = _busChiTietDoan.GetDsNhanVien(doan).ToList();
                tabNhanVien_Show();
            }
        }

        private void btnNewnhanvien_Click(object sender, EventArgs e)
        {
            Form_AddNhanVien addNV = new Form_AddNhanVien();
            addNV.Show();
        }
    }
}
