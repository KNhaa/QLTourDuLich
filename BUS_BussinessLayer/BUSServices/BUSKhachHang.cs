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

        public BUSKhachHang()
        {

        }
        public static List<Khach> getListKhachHang()
        {
            return DAOKhachHang.getListKhachHang();
        }
        // day la function them khach hang
        public static void themKhachHang(String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {
            DAOKhachHang.themKhachHang(tenKH,  diaChi,  cMND, gioiTinh,  SDT, quocTich);
        }
        public static void updateKhachHang(int idKH, String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {

            DAOKhachHang.updateKhachHang( idKH, tenKH , diaChi , cMND , gioiTinh, SDT, quocTich);
        }
        public static void deleteKhachHang(int idKH, String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {
            DAOKhachHang.deletKhachHang(idKH, tenKH, diaChi, cMND, gioiTinh, SDT, quocTich);
        }
        public static List<Khach> searchKhachHang(String keyword)
        {
            return DAOKhachHang.searchKhachHang(keyword);
        }
    }
}
