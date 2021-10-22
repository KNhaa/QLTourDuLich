using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSTour
    {
         DAOTour tour;
        public BUSTour()
        {
            tour = new DAOTour();
        }
        public ICollection<Tour> GetTours()
        {
            return tour.GetTours().ToList();
        }

        public Tour GetTour(int ID)
        {
            return tour.GetTour(ID);
        }
    }
}
