using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAOThamQuan
    {
        public static ICollection<ThamQuan> GetDSThamQuan(Tour tour)
        {
            using (QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                return context.ThamQuans.Where(item => item.maTour == tour.maTour).Select(item => item).ToList();
            }
        }

        public static void UpdateThamQuan(Tour tour)
        {
            using (QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var list = context.ThamQuans.Where(item => item.maTour == tour.maTour).Select(thamquan => thamquan).ToList();
                foreach (var item in tour.ThamQuans)
                {
                    if (list.Any(x => x.maDiaDiem == item.maDiaDiem))
                    {
                        var tmp = list.FirstOrDefault(x => x.maDiaDiem == item.maDiaDiem);
                        tmp.thuTuThamQuan = item.thuTuThamQuan;
                        context.ThamQuans.Update(tmp);
                    }
                }
                foreach (var item in list)
                {
                    if (list.Any(x => x.maDiaDiem == item.maDiaDiem) && !tour.ThamQuans.Any(x => x.maDiaDiem == item.maDiaDiem))
                    {
                        context.ThamQuans.Remove(item);
                    }
                }
                context.SaveChanges();
            }
        }

        public static void UpdateDSThamQuan(ThamQuan thamQuan)
        {
            using (QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                context.ThamQuans.Update(thamQuan);
                context.SaveChanges();
            }
        }

        public static void RemoveItemDSThamQuan(ThamQuan thamQuan)
        {
            using (QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                context.ThamQuans.Remove(thamQuan);
                context.SaveChanges();
            }
        }
    }
}
