﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL_DataAccessLayer.DALServices
{
   public class DAOKhachHang
    {
       public static Khach khach = new Khach();
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
                                             kh.maKh,
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
                k.maKh = emp.maKh;
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
        // update khách hàng
        public static void updateKhachHang(int idKH, String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {

            khach.maKh = idKH;
            khach.tenKh = tenKH;
            khach.diaChi = diaChi;
            khach.cnmd = cMND;
            khach.gioiTinh = gioiTinh;
            khach.sdt = SDT;
            khach.quocTich = quocTich;
            // lay thông tin khách hàng cần update theo id(Phải lấy được idKH thì mới update đc)
            var khUpdate = dbContext.Khachs.SingleOrDefault
                    (x => x.maKh == khach.maKh);
            // nếu khách hàng này có thì cập nhật lại thông tin khách hàng lấy được từ db này thành 
            if( khUpdate != null)
            {
                khUpdate.tenKh = khach.tenKh;
                khUpdate.diaChi = khach.diaChi;
                khUpdate.cnmd = khach.cnmd;
                khUpdate.gioiTinh = khach.gioiTinh;
                khUpdate.sdt = khach.sdt;
                khUpdate.quocTich = khach.quocTich;
            }
            dbContext.SaveChanges();
        }
        // xóa khách hàng
        public static void deletKhachHang(int idKH, String tenKH, String diaChi, String cMND, String gioiTinh, String SDT, String quocTich)
        {

            khach.maKh = idKH;
            khach.tenKh = tenKH;
            khach.diaChi = diaChi;
            khach.cnmd = cMND;
            khach.gioiTinh = gioiTinh;
            khach.sdt = SDT;
            khach.quocTich = quocTich;
            // lay thông tin khách hàng cần update theo id(Phải lấy được idKH thì mới update đc)
            var khDelete = dbContext.Khachs.SingleOrDefault
                    (x => x.maKh == khach.maKh);
            // nếu khách hàng này có thì cập nhật lại thông tin khách hàng lấy được từ db này thành 
            if (khDelete != null)
            {
                dbContext.Remove(khDelete);
            }
            dbContext.SaveChanges();
        }
        public static List<Khach> searchKhachHang(String keyword) 
            {

            List<Khach> listKhachs = new List<Khach>();
            var querys = dbContext.Khachs
                                         .Where(khach => khach.tenKh.Contains(keyword) || khach.quocTich.Contains(keyword) || khach.sdt.Contains(keyword) 
                                         || khach.diaChi.Contains(keyword) || khach.gioiTinh.Contains(keyword))  
                                          .Select(kh => new
                                         {
                                             kh.maKh,
                                             kh.tenKh,
                                             kh.diaChi,
                                             kh.cnmd,
                                             kh.gioiTinh,
                                             kh.sdt,
                                             kh.quocTich
                                         }).ToList();
            foreach (var khachHang in querys)
            {
                Khach k = new Khach();
                k.maKh = khachHang.maKh;
                k.tenKh = khachHang.tenKh;
                k.diaChi = khachHang.diaChi;
                k.cnmd = khachHang.cnmd;
                k.gioiTinh = khachHang.gioiTinh;
                k.sdt = khachHang.sdt;
                k.quocTich = khachHang.quocTich;
                listKhachs.Add(k);
            }
            return listKhachs;
           
            } 
    }
}
