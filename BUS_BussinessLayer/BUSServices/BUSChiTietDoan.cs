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

        public static ChiTietDoan GetChiTietDoan(Doan doan)
        {
            return DAOChiTietDoan.GetChiTietDoan(doan);
        }

        public static List<newDiaDiem> GetDiaDiem(Doan doan)
        {
            return DAOChiTietDoan.GetDiaDiem(doan);
        }

        public static List<Khach> GetDsKhach(Doan doan)
        {
            return DAOChiTietDoan.GetDsKhach(doan);
        }

        public static void addKhach(ChiTiet ct)
        {
            DAOChiTietDoan.addKhach(ct);
        }

        public static void delKhach(ChiTiet ct)
        {
            DAOChiTietDoan.delKhach(ct);
        }
        public static List<newChiPhi> GetDsChiPhi(Doan doan)
        {
            return DAOChiTietDoan.GetDsChiPhi(doan);
        }

        public static ICollection<LoaiChiPhi> GetLoaiChiPhi()
        {
            return DAOChiTietDoan.GetLoaiChiPhi().ToList();
        }

        public static void addChiPhi(ChiPhi cp)
        {
            DAOChiTietDoan.addChiPhi(cp);
        }

        public static void delChiPhi(ChiPhi cp)
        {
            DAOChiTietDoan.delChiPhi(cp);
        }

        public static List<newNhanVien> GetDsNhanVien(Doan doan)
        {
            return DAOChiTietDoan.GetDsNhanVien(doan);
        }

        public static ICollection<NhanVien> GetNhanVien()
        {
            return context.NhanViens.ToList();
        }

        public static void addNhanVienDoan(PhanBo pb)
        {
            DAOChiTietDoan.addNhanVienDoan(pb);
        }

        public static void delNhanVien(PhanBo pb)
        {
            DAOChiTietDoan.delNhanVien(pb);
        }

        public static void addNhanVien(NhanVien nv)
        {
            DAOChiTietDoan.addNhanVien(nv);
        }
    }
}
