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
  public class BUSKhachHang
    {
        DAOKhachHang _daoKhachHang = null;
        public BUSKhachHang()
        {
            _daoKhachHang = new DAOKhachHang();
        }
        public List<Khach> getListKhachHang()
        {
            return _daoKhachHang.getListKhachHang();
        }
        // day la function them khach hang
        public void themKhachHang(Khach kh)
        {
            _daoKhachHang.themKhachHang(kh);
        }
        public void updateKhachHang(Khach kh)
        {

            _daoKhachHang.updateKhachHang(kh);
        }
        public void deleteKhachHang(Khach kh)
        {
            _daoKhachHang.deletKhachHang(kh);
        }
        public List<Khach> searchKhachHang(String keyword)
        {
            return _daoKhachHang.searchKhachHang(keyword);
        }
        public Khach getKhach(int id)
        {
            return _daoKhachHang.getKhach(id);
        }
    }
}
