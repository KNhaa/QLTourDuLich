﻿using DAL_DataAccessLayer.DatabaseContext;
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
                                  .Include("LoaiHinhDuLich")
                                  .Include("GiaTours")
                                  .Include("ThamQuans.DiaDiem")
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
                context.Attach(tour);   
                context.SaveChanges();
            }
        }
    }
}
