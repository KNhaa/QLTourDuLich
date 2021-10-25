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
       /* public static List<Khach> getListKhachHang()
        {                        
                return dbContext.Khachs.ToList();        
        }*/
        public static List<Khach> getListKhachHang()
        {
            List<Khach> listKhachs = new List<Khach>();
            var querys = dbContext.Khachs.
                                         Select(kh => new
                                         {
                                             kh.tenKh,
                                             kh.diaChi,
                                             kh.cnmd,
                                             kh.gioiTinh,
                                             kh.sdt,
                                             kh.quocTich
                                         }).ToList();
            foreach (var emp in querys)
            {
                Khach k = new Khach();
               
                k.tenKh = emp.tenKh;
                k.diaChi = emp.diaChi;
                k.cnmd = emp.cnmd;
                k.gioiTinh = emp.gioiTinh;
                k.sdt = emp.sdt;
                k.quocTich = emp.quocTich;
                listKhachs.Add(k);
            }
            return listKhachs;
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
