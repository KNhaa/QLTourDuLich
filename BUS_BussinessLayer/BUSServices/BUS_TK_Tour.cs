using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_DataAccessLayer.DALServices.DAO_TK_Tour;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUS_TK_Tour
    {
        DAO_TK_Tour DAO_TK_Tour;

        public BUS_TK_Tour()
        {
            DAO_TK_Tour = new DAO_TK_Tour();
        }
        public static ICollection<T> GetTours()
        {
            return DAO_TK_Tour.GetTours().ToList();
        }
        public static ICollection<T> GetToursFrom(DateTime tungay, DateTime denngay)
        {
            return DAO_TK_Tour.GetToursFrom(tungay, denngay).ToList();
        }
        public static ICollection<T> tkMaTour(DateTime tungay, DateTime denngay, string matour)
        {
            return DAO_TK_Tour.tkMaTour(tungay, denngay, matour).ToList();
        }
    }
}
