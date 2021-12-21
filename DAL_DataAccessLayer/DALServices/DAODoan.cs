using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAODoan
    {
        public QuanLiTourDbContext context = new QuanLiTourDbContext();
        public DAODoan() { }

        public ICollection<Doan> GetDoan()
        {
            return context.Doans.ToList();
        }

        public List<nDoan> GetNDoans()
        {
            var ndoans = (from d in context.Doans
                          join t in context.Tours on d.maTour equals t.maTour
                          select new nDoan
                          {
                              maDoan = d.maDoan,
                              ngayKhoiHanh = d.ngayKhoiHanh,
                              ngayKetThuc = d.ngayKetThuc,
                              tenTour = t.tenTour,
                              doanhThu = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", d.doanhThu)
                          });
            return ndoans.ToList();
        }

        public void Create(Doan doan)
        {
            context.Add(doan);
            context.SaveChanges();
        }

        public void Update(Doan doan)
        {
            Doan doanUp = context.Doans.Single(doanUp => doanUp.maDoan == doan.maDoan);
            doanUp.ngayKhoiHanh = doan.ngayKhoiHanh;
            doanUp.ngayKetThuc = doan.ngayKetThuc;
            doanUp.doanhThu = doan.doanhThu;
            doanUp.maTour = doan.maTour;
            context.SaveChanges();
        }

        public void Delete(Doan doan)
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

        public ICollection<Tour> GetTour()
        {
            return context.Tours.ToList();
        }

        public class nDoan
        {
            public int maDoan { get; set; }
            public DateTime ngayKhoiHanh { get; set; }
            public DateTime ngayKetThuc { get; set; }
            public String doanhThu { get; set; }
            public String tenTour { get; set; }
        }
    }
}
