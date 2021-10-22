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
        public ICollection<GiaTour> GetListItemByTourId(int ID)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var result = context.GiaTours.Where(tour => tour.maTour==ID).Select(tour =>tour).ToList();
                return result;
            }
        }
    }
}
