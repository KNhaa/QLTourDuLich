using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAOChiTietDoan
    {
        public static QuanLiTourDbContext context = new QuanLiTourDbContext();
        public static ChiTietDoan GetChiTietDoan(Doan doan)
        {
            int slKhach = (from sl in context.PhanBos
                            where sl.maDoan == doan.maDoan
                            select sl).Count();
            Tour tour = context.Tours.Single(tenTour => tenTour.maTour == doan.maTour);
            ChiTietDoan ctDoan = new ChiTietDoan();
                ctDoan.maDoan = doan.maDoan;
                ctDoan.tenTour = tour.tenTour;
                ctDoan.ngKhoiHanh = doan.ngayKhoiHanh;
                ctDoan.ngKetThuc = doan.ngayKetThuc;
                ctDoan.sLKhach = slKhach;
                ctDoan.dThu = doan.doanhThu;
                ctDoan.noiDung = tour.noiDungTour;
            return ctDoan;
        }

        public static List<newDiaDiem> GetDiaDiem(Doan doan)
        {
            var dsDiaDiem = (from d in context.Doans
                            join t in context.Tours on d.maTour equals t.maTour
                            join tq in context.ThamQuans on t.maTour equals tq.maTour
                            join dd in context.DiaDiems on tq.maDiaDiem equals dd.maDiaDiem
                            where d.maDoan == doan.maDoan
                            select new newDiaDiem
                            {
                                diaDiem = dd.tenDiaDiem,
                                TTdiaDiem = tq.thuTuThamQuan
                            });
            return dsDiaDiem.ToList();
        }

        public static List<Khach> GetDsKhach(Doan doan)
        {
            using (QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                var dsKhach = (from kh in context.Khachs
                               join ct in context.ChiTiets on kh.maKh equals ct.maKh
                               join d in context.Doans on ct.maDoan equals d.maDoan
                               where d.maDoan == doan.maDoan
                               select kh);
                return dsKhach.ToList();
            }
        }

        //them khach vao doan
        public static void addKhach(ChiTiet ct)
        {
            context.Add(ct);
            context.SaveChanges();
        }

        public static List<newChiPhi> GetDsChiPhi(Doan doan)
        {
            var dsChiPhi = (from lcp in context.LoaiChiPhis
                            join cp in context.ChiPhis on lcp.maLoaiCP equals cp.maLoaiCP
                            join d in context.Doans on cp.maDoan equals d.maDoan
                            where d.maDoan == doan.maDoan
                            select new newChiPhi
                            {
                                chiPhi = cp.maChiPhi,
                                soTien = cp.soTien,
                                tenLoaiCP = lcp.tenLoaiCP
                            });
            return dsChiPhi.ToList();
        }

        public static ICollection<LoaiChiPhi> GetLoaiChiPhi()
        {
            return context.LoaiChiPhis.ToList();
        }

        public static void addChiPhi(ChiPhi cp)
        {
            context.Add(cp);
            context.SaveChanges();
        }

        public static List<newNhanVien> GetDsNhanVien(Doan doan)
        {
            var dsNhanVien = (from nv in context.NhanViens
                                join pb in context.PhanBos on nv.maNv equals pb.maNv
                                join d in context.Doans on pb.maDoan equals d.maDoan
                                where d.maDoan == doan.maDoan
                                select new newNhanVien
                                {
                                    tenNV = nv.tenNv,
                                    nhiemVu = pb.nhiemVu
                                });
            return dsNhanVien.ToList();
        }

        public static ICollection<NhanVien> GetNhanVien()
        {
            return context.NhanViens.ToList();
        }

        public static void addNhanVienDoan(PhanBo pb)
        {
            context.Add(pb);
            context.SaveChanges();
        }

        public static void addNhanVien(NhanVien nv)
        {
            context.Add(nv);
            context.SaveChanges();
        }

        // tao moi chi tiet doan
        public class ChiTietDoan
        {
            public int maDoan { get; set; }
            public String tenTour { get; set; }
            public int sLKhach { get; set; }
            public DateTime ngKhoiHanh { get; set; }
            public DateTime ngKetThuc { get; set; }
            public float dThu { get; set; }
            public String noiDung { get; set; }
        }
        
        // tao moi dia diem theo doan
        public class newDiaDiem
        {
            public String diaDiem { get; set; }
            public int TTdiaDiem { get; set; }
        }

        //tao moi nha vien theo doan
        public class newNhanVien
        {
            public String tenNV { get; set; }
            public String nhiemVu { get; set; }
        }

        //tao moi chi phi theo doan
        public class newChiPhi
        {
            public int chiPhi { get; set; }
            public decimal soTien { get; set; }
            public String tenLoaiCP { get; set; }
        }
    }
}
