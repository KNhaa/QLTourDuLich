using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.BUSServices
{
    public class BUS_TK_DoanhThu
    {
        DAO_TK_DoanhThu DAO_TK_DT;
        public BUS_TK_DoanhThu()
        {
            DAO_TK_DT = new DAO_TK_DoanhThu();
        }
      
        public static ICollection<Doan> GetDoans()
        {
            return DAO_TK_DoanhThu.GetDoans().ToList();
        }

        public static ICollection<Doan> GetDoansFrom(DateTime tungay, DateTime denngay)
        {
            return DAO_TK_DoanhThu.GetDoansFrom(tungay,denngay).ToList();
        }
        public static ICollection<Doan> tkMaDoan(DateTime tungay, DateTime denngay,string madoan)
        {
            return DAO_TK_DoanhThu.tkMaDoan(tungay, denngay,madoan).ToList();
        }
    }
}
