using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL_DataAccessLayer
{
  public  class DAOKhachHangDoan
    {
        public static QuanLiTourDbContext dbContext = new QuanLiTourDbContext();
        public static Doan _doan = null;
        List<Doan> listDoans = null;
      public  DAOKhachHangDoan()
        {
            _doan= new Doan();
            listDoans = new List<Doan>();
        }
        public List<Doan> getAllDoans(int maKH)
        {
            
            var doans =( from k in dbContext.Khachs
                        join ct in dbContext.ChiTiets on k.maKh equals ct.maKh
                        join d in dbContext.Doans on ct.maDoan equals d.maDoan
                        where (d.maDoan == ct.maDoan) && (ct.maKh == k.maKh) && (k.maKh == maKH)
                        select new { MaDoan = d.maDoan,NgayKH = d.ngayKhoiHanh,NgayKT= d.ngayKetThuc,DoanhThu = d.doanhThu }).ToList(); 
            foreach( var doan in doans)
            {
                Doan d = new Doan();
                d.maDoan = doan.MaDoan;
                d.ngayKhoiHanh = doan.NgayKH;
                d.ngayKetThuc = doan.NgayKT;
                d.doanhThu = doan.DoanhThu;
                listDoans.Add(d);
            }
            return listDoans;
        }
        // khi thêm đoàn thì bắt buộc chi tiết đoàn khách cũng phải đc thêm nên ta có hàm thêm chi tiết đoàn khách
        public void themChiTietDoanKhach( int maDoan, int maKhach)
        {
            ChiTiet chiTiet = new ChiTiet() { maDoan = maDoan, maKh = maKhach };
            dbContext.Add(chiTiet);
            dbContext.SaveChanges();
        }
        // khi thêm đoàn thì chi tiết đoàn cũng phải đc thêm nên ta gọi thêm hàm thêm chitieets đoàn sau khi thêm đoàn xong
        public void themDoan(DateTime ngayKhoiHanh, DateTime ngayKetThuc, int maDoan, int maKhach)
        {
            Doan doan = new Doan() { ngayKhoiHanh = ngayKhoiHanh, ngayKetThuc = ngayKetThuc };
            dbContext.Add(doan);
            dbContext.SaveChanges();
            themChiTietDoanKhach(maDoan, maKhach);
        }
        public void deleteDoanVaChiTiet(int maDoan)
        {
            // lay thông tin khách hàng cần update theo id(Phải lấy được idKH thì mới update đc)
            var doanDelete = dbContext.Doans.SingleOrDefault
                    (x => x.maDoan == maDoan);
            // nếu khách hàng này có thì cập nhật lại thông tin khách hàng lấy được từ db này thành 
            if (doanDelete != null)
            {
                dbContext.Remove(doanDelete);
            }
            dbContext.SaveChanges();
        }


    }
}
