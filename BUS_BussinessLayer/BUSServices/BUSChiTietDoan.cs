using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_DataAccessLayer.DALServices.DAOChiTietDoan;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSChiTietDoan
    {
        DAOChiTietDoan DAOctDoan;

        public BUSChiTietDoan()
        {
            DAOctDoan = new DAOChiTietDoan();
        }

        public ChiTietDoan GetChiTietDoan(Doan doan)
        {
            return DAOctDoan.GetChiTietDoan(doan);
        }

        public List<newDiaDiem> GetDiaDiem(Doan doan)
        {
            return DAOctDoan.GetDiaDiem(doan);
        }

        public List<Khach> GetDsKhach(Doan doan)
        {
            return DAOctDoan.GetDsKhach(doan);
        }

        public void addKhach(ChiTiet ct)
        {
            DAOctDoan.addKhach(ct);
        }

        public void delKhach(ChiTiet ct)
        {
            DAOctDoan.delKhach(ct);
        }
        public List<newChiPhi> GetDsChiPhi(Doan doan)
        {
            return DAOctDoan.GetDsChiPhi(doan);
        }

        public ICollection<LoaiChiPhi> GetLoaiChiPhi()
        {
            return DAOctDoan.GetLoaiChiPhi().ToList();
        }

        public void addChiPhi(ChiPhi cp)
        {
            DAOctDoan.addChiPhi(cp);
        }

        public void delChiPhi(ChiPhi cp)
        {
            DAOctDoan.delChiPhi(cp);
        }

        public List<newNhanVien> GetDsNhanVien(Doan doan)
        {
            return DAOctDoan.GetDsNhanVien(doan);
        }

        public ICollection<NhanVien> GetNhanVien()
        {
            return DAOctDoan.GetNhanVien();
        }

        public void addNhanVienDoan(PhanBo pb)
        {
            DAOctDoan.addNhanVienDoan(pb);
        }

        public void delNhanVien(PhanBo pb)
        {
            DAOctDoan.delNhanVien(pb);
        }

        public void addNhanVien(NhanVien nv)
        {
            DAOctDoan.addNhanVien(nv);
        }
    }
}
