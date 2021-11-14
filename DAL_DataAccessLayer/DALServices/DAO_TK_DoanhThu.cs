using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAO_TK_DoanhThu
    {
        public DAO_TK_DoanhThu() { }
        public static ICollection<Doan> GetDoans()
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return dbcontext.Doans
                    .ToList();
            }
        }

        public static ICollection<Doan> GetDoansFrom(DateTime tungay, DateTime denngay)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from Doan in dbcontext.Doans
                        where Doan.ngayKetThuc <= denngay && Doan.ngayKhoiHanh >= tungay
                        select Doan).ToList();
                
            }
        }

        public static ICollection<Doan> tkMaDoan(DateTime tungay, DateTime denngay,string madoan)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from Doan in dbcontext.Doans
                        where Doan.ngayKetThuc <= denngay && Doan.ngayKhoiHanh >= tungay && Doan.maDoan.ToString() == madoan
                        select Doan).ToList();

            }
        }

    }
}
