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
        DAOKhachHangDoan _khachHangDoan;
        public BUSKhachHangDoan()
        {
            _khachHangDoan = new DAOKhachHangDoan();
        }
        public List<Doan> getAllDoans(int maKH)
        {
            return _khachHangDoan.getAllDoans(maKH);
        }
        public void deleteDoanVaChiTiet(int maDoan)
        {
            _khachHangDoan.deleteDoanVaChiTiet(maDoan);
        }
        public void themDoan(DateTime ngayKhoiHanh, DateTime ngayKetThuc, int maDoan, int maKhach)
        {
            _khachHangDoan.themDoan(ngayKhoiHanh, ngayKetThuc, maDoan, maKhach);
        }
    }
}
