using DAL_DataAccessLayer.DALServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_DataAccessLayer.DALServices.DAOThongKeChiPhi;

namespace BUS_BussinessLayer.BUSServices
{
   public class BUSThongKeChiPhi
    {
        List<DataThongKeCP> dataThongKeCP;
        DAOThongKeChiPhi _daoThongKeChiPhi;

        public BUSThongKeChiPhi()
        {
            _daoThongKeChiPhi = new DAOThongKeChiPhi();
            dataThongKeCP = _daoThongKeChiPhi.laydulieuThongKe();
        }
        public List<KetQuaTKCP> loadChiPhiTatCa()
        {
            List<KetQuaTKCP> list = new List<KetQuaTKCP>();
            var groupResult = from j in dataThongKeCP
                              orderby j.MaTour, j.TenLoaiCP
                              group j by new { j.MaTour, j.TenTour, j.TenLoaiCP } into gr
                              select new KetQuaTKCP
                              {
                                  maTour = gr.Key.MaTour,
                                  tenTour = gr.Key.TenTour,
                                  tenLoaiChiPhi = gr.Key.TenLoaiCP,
                                  tongChiPhi = gr.Sum(x => x.SoTien)

                              };
            
            return list = groupResult.ToList();
        }

        public List<KetQuaTKCP> loadChiPhiTheoNgay(DateTime dateStart, DateTime dateEnd)
        {
            List<KetQuaTKCP> list = new List<KetQuaTKCP>();
            var groupResult = from j in dataThongKeCP
                              where j.NgayBatDau.Date >= dateStart && j.NgayKetThuc.Date <= dateEnd
                              orderby j.MaTour, j.TenLoaiCP
                              group j by new { j.MaTour, j.TenTour, j.TenLoaiCP } into gr
                              select new KetQuaTKCP
                              {
                                  maTour = gr.Key.MaTour,
                                  tenTour = gr.Key.TenTour,
                                  tenLoaiChiPhi = gr.Key.TenLoaiCP,
                                  tongChiPhi = gr.Sum(x => x.SoTien)

                              };
            return list = groupResult.ToList();

        }

        public List<KetQuaTKCP> loadChiPhiTheoNgayMaTour(DateTime dateStart, DateTime dateEnd, int maTour)
        {
            List<KetQuaTKCP> list = new List<KetQuaTKCP>();
            var groupResult = from j in dataThongKeCP
                              where j.NgayBatDau.Date >= dateStart && j.NgayKetThuc.Date <= dateEnd
                              && j.MaTour == maTour
                              orderby j.MaTour, j.TenLoaiCP
                              group j by new { j.MaTour, j.TenTour, j.TenLoaiCP } into gr
                              select new KetQuaTKCP
                              {
                                  maTour = gr.Key.MaTour,
                                  tenTour = gr.Key.TenTour,
                                  tenLoaiChiPhi = gr.Key.TenLoaiCP,
                                  tongChiPhi = gr.Sum(x => x.SoTien)

                              };
            return list = groupResult.ToList();

        }
    }

}
