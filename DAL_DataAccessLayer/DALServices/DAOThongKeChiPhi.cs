using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{

    public class DAOThongKeChiPhi
    {

        public static QuanLiTourDbContext context = new QuanLiTourDbContext();

        public DAOThongKeChiPhi()
        {

        }

        public static List<DataThongKeCP> laydulieuThongKe()
        {
            List<LoaiChiPhi> loaichiphiList = context.LoaiChiPhis.ToList();
            List<ChiPhi> chiphiList = context.ChiPhis.ToList();
            List<Doan> doanList = context.Doans.ToList();
            List<Tour> tourList = context.Tours.ToList();

            var joinResult = from tour in tourList
                             join d in doanList on tour.maTour equals d.maTour
                             join cp in chiphiList on d.maDoan equals cp.maDoan
                             join lp in loaichiphiList on cp.maLoaiCP equals lp.maLoaiCP
                             select new DataThongKeCP
                             {
                                 MaTour = tour.maTour,
                                 TenTour = tour.tenTour,
                                 MaDoan = d.maDoan,
                                 NgayBatDau = d.ngayKhoiHanh,
                                 NgayKetThuc = d.ngayKetThuc,                              
                                 SoTien = cp.soTien,
                                 TenLoaiCP = lp.tenLoaiCP                          
                             };
            return joinResult.ToList();
        }


        // 2 model moi de luu tru thong tin thong ke
        public class DataThongKeCP
        {
            public int MaTour { get; set; }
            public String TenTour { get; set; }
            public int MaDoan { get; set; }
            public DateTime NgayBatDau { get; set; }
            public DateTime NgayKetThuc { get; set; }
            public decimal SoTien { get; set; }
            public String TenLoaiCP { get; set; }
        }
        public class KetQuaTKCP
        {
            public int maTour { get; set; }
            public String tenTour { get; set; }
            public String tenLoaiChiPhi { get; set; }
            public decimal tongChiPhi { get; set; }

        }
    }
}
