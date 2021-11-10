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
    public class DAOGiaTour
    {
        public static ICollection<GiaTour> GetByTourId(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var result = context.GiaTours.Where(tour => tour.maTour==ID).Select(tour =>tour).ToList();
                return result;
            }
        }

        public static GiaTour GetById(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                return context.GiaTours.Find(ID);
            }
        }

        public static void Create(GiaTour giaTour)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                context.Add(giaTour);
                context.SaveChanges();
            }
        }

        public static void Delete(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var giaTour = GetById(ID);
                context.GiaTours.Remove(giaTour);
                context.SaveChanges();
            }
        }

        public static void Update(GiaTour giaTour)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                //  context.GiaTours.Attach(giaTour);
                context.GiaTours.Update(giaTour);
                context.SaveChanges();
            }
        }
    }
}
