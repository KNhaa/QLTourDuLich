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
        public static void themKhachHang(String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {
            DAOKhachHang.themKhachHang(tenKH,  diaChi,  cMND, gioiTinh,  SDT, quocTich);
        }
    }
}
