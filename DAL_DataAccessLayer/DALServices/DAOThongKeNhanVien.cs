using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAOThongKeNhanVien
    {
        public static QuanLiTourDbContext context = new QuanLiTourDbContext();
        
        public DAOThongKeNhanVien()
        {

        }

        public static List<DataThongKe> layDuLieuThongKe()
        {
            List<DataThongKe> list = new List<DataThongKe>();
            List<NhanVien> nhanvienList = context.NhanViens.ToList(); // có thể gọi lớp DAO cua NHANVIEN
            List<PhanBo> phanboList = context.PhanBos.ToList();
            List<Doan> doanList = context.Doans.ToList(); // có thể gọi lớp DAO cua DOAN

            //kết bảng NhanVien - PhanBo - Doan
            var joinResult = from nv in nhanvienList
                             join pb in phanboList on nv.maNv equals pb.maNv
                             join d in doanList on pb.maDoan equals d.maDoan
                             select new DataThongKe
                             {
                                 maNv = nv.maNv,
                                 tenNv = nv.tenNv,
                                 maDoan = d.maDoan,
                                 ngayBatDau = d.ngayKhoiHanh,
                                 ngayKetThuc = d.ngayKetThuc
                             };          
            return list = joinResult.ToList();
        }


        // 2 model mới dùng để lưu giá trị khi thống kê
        //DataThongKe lưu kết quả khi kết các bảng
        public class DataThongKe
        {
            public int maNv { get; set; }
            public string tenNv { get; set; }
            public int maDoan { get; set; }
            public DateTime ngayBatDau { get; set; }
            public DateTime ngayKetThuc { get; set; }
        }


        //KetQuaTKNV - kết quả sau khi thống kê
        public class KetQuaTKNV
        {
            public int MaNV { get; set; }
            public string TenNV { get; set; }
            public int SoLuong { get; set; }
        }
        
        

    }
}
