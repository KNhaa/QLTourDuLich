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
      public  DAOKhachHangDoan()
        {
            _doan= new Doan();
        }
        public List<Doan> getAllDoans(int maKH)
        {
            List<Doan> listDoans = new List<Doan>();
            var doans =( from d in dbContext.Doans
                        join ct in dbContext.ChiTiets on d.maDoan equals ct.maDoan
                        join kh in dbContext.Khachs on ct.maKh equals kh.maKh
                        where (d.maDoan == ct.maDoan) && (ct.maKh == kh.maKh) && (kh.maKh == maKH)
                        select new { MaDoan = d.maDoan,NgayKH = d.ngayKhoiHanh,NgayKT= d.ngayKetThuc,DoanhThu = d.doanhThu }).ToList(); 
            foreach( var doan in doans)
            {
                _doan.maDoan = doan.MaDoan;
                _doan.ngayKhoiHanh = doan.NgayKH;
                _doan.ngayKetThuc = doan.NgayKT;
                _doan.doanhThu = doan.DoanhThu;
                listDoans.Add(_doan);
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
