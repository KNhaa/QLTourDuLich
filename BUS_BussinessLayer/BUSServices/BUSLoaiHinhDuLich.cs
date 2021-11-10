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
    public class BUSLoaiHinhDuLich
    {
        public static ICollection<LoaiHinhDuLich> GetAll()
        {
            return DAOLoaiHinhDuLich.GetAll();
        }
    }
}
