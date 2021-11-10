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
         DAOTour tourDAO;
        public BUSTour()
        {
            tourDAO= new DAOTour();
        }
        public static  ICollection<Tour> GetTours()
        {
            return DAOTour.GetTours().ToList();
        }

        public static Tour GetTour(int ID)
        {
            return DAOTour.GetTour(ID);
        }

        public static void Create(Tour tour)
        {
            DAOTour.Create(tour);
        }

        public static void Update(Tour tour)
        {
            DAOTour.Update(tour);
        }

        public static void UpdateData(Tour tour)
        {
            DAOTour.UpdateThamQuan(tour);
        }
    }
}
