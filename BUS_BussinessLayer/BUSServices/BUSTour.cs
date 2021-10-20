using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSTour
    {
         DAOTour tour;
        public BUSTour()
        {
            tour = new DAOTour();
        }
        public ICollection<Tour> GetTour()
        {
            return tour.GetTours().ToList();
        }
    }
}
