using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSGiaTour
    {
       
        public static ICollection<GiaTour> GetByTourId(int ID)
        {
            var result = DAOGiaTour.GetByTourId(ID);
            return result;
        }
        
        public static void Create(GiaTour giaTour)
        {
            
                DAOGiaTour.Create(giaTour);
        }

        public static void Delete(int ID)
        {
            DAOGiaTour.Delete(ID);
        }

        public static void Update(GiaTour giaTour)
        {
            DAOGiaTour.Update(giaTour);
        }
    }
}
  