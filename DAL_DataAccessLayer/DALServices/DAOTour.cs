using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Migrations;
using Microsoft.Data.SqlClient;
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
        DataTable dt = new DataTable();
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
    }
}
