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
        public DAOGiaTour _dao;
        public BUSGiaTour()
        {
            _dao = new DAOGiaTour();
        }

        public  ICollection<GiaTour> GetListItemByTourId(int ID)
        {
            var result =_dao.GetListItemByTourId(ID);
            return result;
        }
        /////Day la function 
    }
}
  