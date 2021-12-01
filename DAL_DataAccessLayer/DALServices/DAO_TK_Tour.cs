using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAO_TK_Tour
    {
        public DAO_TK_Tour(){}
        public ICollection<T> GetTours()
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
             return   (from t in dbcontext.Tours
                               join d in dbcontext.Doans on t.maTour equals d.maTour
                              join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
                               select new T
                               {
                                   maTourTK = t.maTour,
                                   tenTourTK = t.tenTour,
                                   maDoanTK = d.maDoan,
                                   ngayKhoiHanhTK = gt.ngayKhoiHanh,
                                   ngayKetThucTK = gt.ngayKetThuc,
                                   giaTourTK = gt.thanhTien
                               }).ToList();
            }
           
        }
        public ICollection<T> GetToursFrom(DateTime tungay, DateTime denngay)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from t in dbcontext.Tours
                        join d in dbcontext.Doans on t.maTour equals d.maTour
                        join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
                        where gt.ngayKhoiHanh >= tungay && gt.ngayKetThuc <=denngay
                        select new T
                        {
                            maTourTK = t.maTour,
                            tenTourTK = t.tenTour,
                            maDoanTK = d.maDoan,
                            ngayKhoiHanhTK = gt.ngayKhoiHanh,
                            ngayKetThucTK = gt.ngayKetThuc,
                            giaTourTK = gt.thanhTien
                        }).ToList();
            }
        }
        public ICollection<T> tkMaTour (DateTime tungay, DateTime denngay, string matour)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from t in dbcontext.Tours
                        join d in dbcontext.Doans on t.maTour equals d.maTour
                        join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
                        where gt.ngayKhoiHanh >= tungay && gt.ngayKetThuc <= denngay && t.maTour.ToString()== matour
                        select new T
                        {
                            maTourTK = t.maTour,
                            tenTourTK = t.tenTour,
                            maDoanTK = d.maDoan,
                            ngayKhoiHanhTK = gt.ngayKhoiHanh,
                            ngayKetThucTK = gt.ngayKetThuc,
                            giaTourTK = gt.thanhTien
                        }).ToList();
            }
        }

        public class T
        {
            public int maTourTK { get; set; }
            public string tenTourTK { get; set; }
            public int maDoanTK { get; set; }
            public DateTime ngayKhoiHanhTK { get; set; }
            public DateTime ngayKetThucTK { get; set; }
            public decimal giaTourTK { get; set; }
           
        }
       
    }

}
