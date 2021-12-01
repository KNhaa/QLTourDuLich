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
        DAOKhachHang _daoKhachHang;
        public BUSKhachHang()
        {
            _daoKhachHang = new DAOKhachHang();
        }
        public List<Khach> getListKhachHang()
        {
            return _daoKhachHang.getListKhachHang();
        }
        // day la function them khach hang
        public void themKhachHang(String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {
            _daoKhachHang.themKhachHang(tenKH,  diaChi,  cMND, gioiTinh,  SDT, quocTich);
        }
        public void updateKhachHang(int idKH, String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {

            _daoKhachHang.updateKhachHang( idKH, tenKH , diaChi , cMND , gioiTinh, SDT, quocTich);
        }
        public void deleteKhachHang(int idKH, String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {
            _daoKhachHang.deletKhachHang(idKH, tenKH, diaChi, cMND, gioiTinh, SDT, quocTich);
        }
        public List<Khach> searchKhachHang(String keyword)
        {
            return _daoKhachHang.searchKhachHang(keyword);
        }
    }
}
