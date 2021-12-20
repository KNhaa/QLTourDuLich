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

        public ICollection<Doan> GetDoan()
        {
            return DAOdoan.GetDoan().ToList();
        }

        public void Create(Doan doan)
        {
            DAOdoan.Create(doan);
        }

        public void Update(Doan doan)
        {
            DAOdoan.Update(doan);
        }

        public void Delete(Doan doan)
        {
            DAOdoan.Delete(doan);
        }

        public ICollection<Tour> GetTour()
        {
            return DAOdoan.GetTour().ToList();
        }
        
    }
}
