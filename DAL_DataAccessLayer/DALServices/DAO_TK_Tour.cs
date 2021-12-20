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
      /*  public ICollection<T> GetTours()
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
           
        } */
      /*  public ICollection<T> GetToursFrom(DateTime tungay, DateTime denngay)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from t in dbcontext.Tours
                        join d in dbcontext.Doans on t.maTour equals d.maTour
                        join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
                        where gt.ngayKhoiHanh >= tungay && gt.ngayKetThuc <=denngay
                        // bo sung 
                        && d.ngayKhoiHanh >= gt.ngayKhoiHanh && d.ngayKhoiHanh <= gt.ngayKetThuc
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
        }*/

        //public ICollection<T> tkMaTour (DateTime tungay, DateTime denngay, string matour)
        //{
        //    using var dbcontext = new QuanLiTourDbContext();
        //    {
        //        return (from t in dbcontext.Tours
        //                join d in dbcontext.Doans on t.maTour equals d.maTour
        //                join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
        //                where 
        //                // bo sung 
        //                 d.ngayKhoiHanh >= gt.ngayKhoiHanh && d.ngayKhoiHanh <= gt.ngayKetThuc
        //                 //
        //                && gt.ngayKhoiHanh >= tungay && gt.ngayKetThuc <= denngay && t.maTour.ToString() == matour
        //                select new T
        //                {
        //                    maTourTK = t.maTour,
        //                    tenTourTK = t.tenTour,
        //                    maDoanTK = d.maDoan,
        //                    ngayKhoiHanhTK = gt.ngayKhoiHanh,
        //                    ngayKetThucTK = gt.ngayKetThuc,
        //                    giaTourTK = gt.thanhTien
        //                }).ToList();
        //    }
        //}
        //--- bo sung
        public ICollection<T> GetTours(DateTime denngay)
        {
            using var dbcontext = new QuanLiTourDbContext();
            {
                return (from t in dbcontext.Tours
                        join d in dbcontext.Doans on t.maTour equals d.maTour
                        join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
                        join ct in dbcontext.ChiTiets on d.maDoan equals ct.maDoan
                        where d.ngayKhoiHanh <= denngay

                        //D.ngayKhoiHanh BETWEEN GT.ngayKhoiHanh AND GT.ngayKetThuc
                        && d.ngayKhoiHanh >= gt.ngayKhoiHanh && d.ngayKhoiHanh <= gt.ngayKetThuc

                        //group by T.maTour, GT.ngayKhoiHanh,GT.ngayKetThuc, GT.thanhTien,D.maDoan
                        group ct by new { t.maTour,d.maDoan,gt.ngayKhoiHanh, gt.ngayKetThuc,
                                            gt.thanhTien,t.tenTour} into slkhachhang
                       

                        select new T
                        {

                            /*maTourTK = t.maTour,
                            tenTourTK = t.tenTour,
                            maDoanTK = d.maDoan,
                            //maDoanTK = slkhachhang.Key,
                            ngayKhoiHanhTK = gt.ngayKhoiHanh,
                            ngayKetThucTK = gt.ngayKetThuc,
                            giaTourTK = gt.thanhTien,
                            SLkhach= slkhachhang.Count()*/

                            maTourTK = slkhachhang.Key.maTour,
                            tenTourTK = slkhachhang.Key.tenTour,
                            maDoanTK = slkhachhang.Key.maDoan,
                            ngayKhoiHanhTK = slkhachhang.Key.ngayKhoiHanh,
                            ngayKetThucTK = slkhachhang.Key.ngayKetThuc,
                            giaTourTK = slkhachhang.Key.thanhTien,
                            SLkhach = slkhachhang.Count(),
                            doanhThu = slkhachhang.Count() * slkhachhang.Key.thanhTien

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
                        join ct in dbcontext.ChiTiets on d.maDoan equals ct.maDoan
                        where d.ngayKhoiHanh <= DateTime.Now
                        //D.ngayKhoiHanh BETWEEN GT.ngayKhoiHanh AND GT.ngayKetThuc
                        && d.ngayKhoiHanh >= gt.ngayKhoiHanh && d.ngayKhoiHanh <= gt.ngayKetThuc

                        //tim trong khoang ngay
                        && gt.ngayKhoiHanh >= tungay && gt.ngayKetThuc <= denngay

                        //group by T.maTour, GT.ngayKhoiHanh,GT.ngayKetThuc, GT.thanhTien,D.maDoan
                        group ct by new
                        {
                            t.maTour,
                            d.maDoan,
                            gt.ngayKhoiHanh,
                            gt.ngayKetThuc,
                            gt.thanhTien,
                            t.tenTour
                        } into slkhachhang


                        select new T
                        {

                            maTourTK = slkhachhang.Key.maTour,
                            tenTourTK = slkhachhang.Key.tenTour,
                            maDoanTK = slkhachhang.Key.maDoan,
                            ngayKhoiHanhTK = slkhachhang.Key.ngayKhoiHanh,
                            ngayKetThucTK = slkhachhang.Key.ngayKetThuc,
                            giaTourTK = slkhachhang.Key.thanhTien,
                            SLkhach = slkhachhang.Count(),
                            doanhThu = slkhachhang.Count() * slkhachhang.Key.thanhTien

                        }).ToList();
            }

        }
        public ICollection<T> tkMaTour(DateTime tungay, DateTime denngay, string matour)
        {
            using var dbcontext = new QuanLiTourDbContext();
          
            {
                return (from t in dbcontext.Tours
                        join d in dbcontext.Doans on t.maTour equals d.maTour
                        join gt in dbcontext.GiaTours on t.maTour equals gt.maTour
                        join ct in dbcontext.ChiTiets on d.maDoan equals ct.maDoan
                        where d.ngayKhoiHanh <= DateTime.Now
                        //D.ngayKhoiHanh BETWEEN GT.ngayKhoiHanh AND GT.ngayKetThuc
                        && d.ngayKhoiHanh >= gt.ngayKhoiHanh && d.ngayKhoiHanh <= gt.ngayKetThuc

                        //tim trong khoang ngay
                        && gt.ngayKhoiHanh >= tungay && gt.ngayKetThuc <= denngay && t.maTour.ToString() == matour

                        //group by T.maTour, GT.ngayKhoiHanh,GT.ngayKetThuc, GT.thanhTien,D.maDoan
                        group ct by new
                        {
                            t.maTour,
                            d.maDoan,
                            gt.ngayKhoiHanh,
                            gt.ngayKetThuc,
                            gt.thanhTien,
                            t.tenTour
                        } into slkhachhang


                        select new T
                        {

                            maTourTK = slkhachhang.Key.maTour,
                            tenTourTK = slkhachhang.Key.tenTour,
                            maDoanTK = slkhachhang.Key.maDoan,
                            ngayKhoiHanhTK = slkhachhang.Key.ngayKhoiHanh,
                            ngayKetThucTK = slkhachhang.Key.ngayKetThuc,
                            giaTourTK = slkhachhang.Key.thanhTien,
                            SLkhach = slkhachhang.Count(),
                            doanhThu = slkhachhang.Count() * slkhachhang.Key.thanhTien

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

            // them
            public int SLkhach { get; set; }
            public decimal doanhThu { get; set; }
           
        }
       
    }

}
