using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSDoan
    {
        DAODoan DAOdoan;

        public BUSDoan()
        {
            DAOdoan = new DAODoan();
        }

        public static ICollection<Doan> GetDoan()
        {
            return DAODoan.GetDoan().ToList();
        }

        public static void Create(Doan doan)
        {
            DAODoan.Create(doan);
        }

        public static void Update(Doan doan)
        {
            DAODoan.Update(doan);
        }

        public static void Delete(Doan doan)
        {
            DAODoan.Delete(doan);
        }

        public static ICollection<Tour> GetTour()
        {
            return DAODoan.GetTour().ToList();
        }
    }
}
