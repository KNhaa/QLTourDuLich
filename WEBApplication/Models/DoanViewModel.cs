using DAL_DataAccessLayer.Entities;
using System.Collections.Generic;
using X.PagedList;
using static DAL_DataAccessLayer.DALServices.DAOChiTietDoan;
using static DAL_DataAccessLayer.DALServices.DAODoan;

namespace WEBApplication.Models
{
    public class DoanViewModel
    {
        public Doan? doans { get; set; }
        public IPagedList<Doan>? Doan { get; set; }
        public string? searchString { get; set; }
        public ChiTietDoan? ctDoan { get; set; }
        public List<newDiaDiem> dsDiaDiemDoan { get; set; }
        public List<newNhanVien> dsNhanVienDoan { get; set; }
        public ICollection<NhanVien>? dsNhanVien { get; set; }
        public PhanBo? phanBo { get; set; }
        public ChiPhi? chiPhi { get; set; }
        public List<newChiPhi>? dsChiPhiDoan { get; set; }
        public ICollection<LoaiChiPhi>? loaiChiPhi { get; set; }
        public List<Khach>? dsKhachDoan { get; set; }
        public List<Khach>? dsKhach { get; set; }
        public Khach? Khach { get; set; }

    }
}
