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
      
        public ICollection<Doan> GetDoans()
        {
            return DAO_TK_DT.GetDoans().ToList();
        }
        //so sung
        public ICollection<Doan> GetDoans(DateTime denngay)
        {
            return DAO_TK_DT.GetDoans(denngay).ToList();
        }

        public ICollection<Doan> GetDoansFrom(DateTime tungay, DateTime denngay)
        {
            return DAO_TK_DT.GetDoansFrom(tungay,denngay).ToList();
        }
        public ICollection<Doan> tkMaDoan(DateTime tungay, DateTime denngay,string madoan)
        {
            return DAO_TK_DT.tkMaDoan(tungay, denngay,madoan).ToList();
        }
    }
}
