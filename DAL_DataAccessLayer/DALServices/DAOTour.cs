using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAOTour
    {
        
        public DAOTour()
        {
            
        }

        public static ICollection<Tour> GetTours()
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                return context.Tours
                    .Include("LoaiHinhDuLich")
                    .Include("GiaTours")
                    .Include("ThamQuans.DiaDiem") 
                    .ToList();
            }
        }

        public static Tour GetTour(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var tour = context.Tours
                                  
                                  .Include(tour => tour.ThamQuans)
                                   .Single(tour => tour.maTour == ID);
                
                return tour;
            }
        }

        public static void Create(Tour tour)
        {
            using (QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                context.Add(tour);
                context.SaveChanges();
            }
        }

        public static void Update(Tour tour)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                //context.Entry(tour).State = EntityState.Unchanged;
                context.Attach(tour);
               

                context.SaveChanges();
            }
           // UpdateThamQuan(tour);
        }

        public static void UpdateThamQuan(Tour tour)
        {
           using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var list = context.ThamQuans.Where(item => item.maTour == tour.maTour).Select(thamquan => thamquan).ToList();
                foreach(var item in tour.ThamQuans)
                {
                    if(list.Any(x =>x.maDiaDiem == item.maDiaDiem))
                    {
                        var tmp = list.FirstOrDefault(x => x.maDiaDiem == item.maDiaDiem);
                        tmp.thuTuThamQuan = item.thuTuThamQuan;
                        context.ThamQuans.Update(tmp);
                    }
                }
                foreach(var item in list)
                {
                    if(list.Any(x => x.maDiaDiem == item.maDiaDiem) && !tour.ThamQuans.Any(x => x.maDiaDiem == item.maDiaDiem))
                    {
                        context.ThamQuans.Remove(item);
                    }
                }
                
                context.SaveChanges();
            }
        }
       
    }
}
