using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.BUSServices
{
  public  class BUSKhachHangDoan
    {
        public BUSKhachHangDoan()
        {
           
        }
        public static List<Doan> getAllDoans(int maKH)
        {
            return DAOKhachHangDoan.getAllDoans(maKH);
        }
        public static void deleteDoanVaChiTiet(int maDoan)
        {
            DAOKhachHangDoan.deleteDoanVaChiTiet(maDoan);
        }
        public static void themDoan(DateTime ngayKhoiHanh, DateTime ngayKetThuc, int maDoan, int maKhach)
        {
            DAOKhachHangDoan.themDoan(ngayKhoiHanh, ngayKetThuc, maDoan, maKhach);
        }
    }
}
