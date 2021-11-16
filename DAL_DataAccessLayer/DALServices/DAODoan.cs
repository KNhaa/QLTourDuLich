using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAODoan
    {
        public static QuanLiTourDbContext context = new QuanLiTourDbContext();
        public DAODoan() { }

        public static ICollection<Doan> GetDoan()
        {
            return context.Doans.ToList();
        }

        public static void Create(Doan doan)
        {
            context.Add(doan);
            context.SaveChanges();
        }

        public static void Update(Doan doan)
        {
            Doan doanUp = context.Doans.Single(doanUp => doanUp.maDoan == doan.maDoan);
            doanUp.ngayKhoiHanh = doan.ngayKhoiHanh;
            doanUp.ngayKetThuc = doan.ngayKetThuc;
            doanUp.doanhThu = doan.doanhThu;
            doanUp.maTour = doan.maTour;
            context.SaveChanges();
        }

        public static void Delete(Doan doan)
        {
            List<ChiPhi> listChiphi = context.ChiPhis.Where(cp => cp.maDoan == doan.maDoan).ToList();
            context.ChiPhis.RemoveRange(listChiphi);

            List<PhanBo> listPhanbo = context.PhanBos.Where(nv => nv.maDoan == doan.maDoan).ToList();
            context.PhanBos.RemoveRange(listPhanbo);

            List<ChiTiet> listChitiet = context.ChiTiets.Where(ct => ct.maDoan == doan.maDoan).ToList();
            context.ChiTiets.RemoveRange(listChitiet);

            context.Doans.Remove(doan);
            context.SaveChanges();
        }

        public static ICollection<Tour> GetTour()
        {
            return context.Tours.ToList();
        }
    }
}
