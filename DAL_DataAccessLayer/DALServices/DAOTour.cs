using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.Migrations;
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

        public ICollection<Tour> GetTours()
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                return context.Tours.ToList();
            }
        }

        public Tour GetTour(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var tour = context.Tours
                                  .Include(tour => tour.LoaiHinhDuLich)
                                   .Single(tour => tour.maTour == ID);
                return tour;
            }
        }
    }
}
