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
        public ICollection<Doan> GetDoans()
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return dbcontext.Doans
                    .ToList();
            }
        }

        public ICollection<Doan> GetDoansFrom(DateTime tungay, DateTime denngay)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from Doan in dbcontext.Doans
                        where Doan.ngayKetThuc <= denngay && Doan.ngayKhoiHanh >= tungay
                        select Doan).ToList();
                
            }
        }

        public ICollection<Doan> tkMaDoan(DateTime tungay, DateTime denngay,string madoan)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from Doan in dbcontext.Doans
                        where Doan.ngayKetThuc <= denngay && Doan.ngayKhoiHanh >= tungay && Doan.maDoan.ToString() == madoan
                        select Doan).ToList();

            }
        }
        //bo sung
        public ICollection<Doan> GetDoans(DateTime denngay)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from Doan in dbcontext.Doans
                        where Doan.ngayKetThuc <= denngay 
                        select Doan).ToList();
            }
        }

        //======WEB======

        //public class TK_DoanhThu
        //{
        //    public int maDoan { get; set; }
        //    public DateTime ngayKhoiHanh { get; set; }
        //    public DateTime ngayKetThuc { get; set; }
        //    public float doanhThu { get; set; }

        //}

    }
}
