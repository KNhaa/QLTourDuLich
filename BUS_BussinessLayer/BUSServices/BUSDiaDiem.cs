using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUSDiaDiem
    {
        public static ICollection<DiaDiem> GetAll()
        {
            return DAODiaDiem.GetAll();
        }
        public static DiaDiem GetItem(int Id)
        {
            return DAODiaDiem.GetById(Id);
        }
    }
}
