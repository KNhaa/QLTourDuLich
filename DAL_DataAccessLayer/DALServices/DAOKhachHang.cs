using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.DALServices
{
   public class DAOKhachHang
    {
       public static QuanLiTourDbContext dbContext = new QuanLiTourDbContext();
        public DAOKhachHang()
        {

        }
        public static List<Khach> getListKhachHang()
        {                        
                return dbContext.Khachs.ToList();        
        }
        //them khach hang
        public static void themKhachHang(String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {
            Khach khach = new Khach() { tenKh = tenKH, diaChi = diaChi, cnmd = cMND, gioiTinh = gioiTinh, sdt = SDT, quocTich = quocTich};
            dbContext.Add(khach);
            dbContext.SaveChanges();
        }
    }
}
