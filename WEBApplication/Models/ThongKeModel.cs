using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using static DAL_DataAccessLayer.DALServices.DAOThongKeNhanVien;
using static DAL_DataAccessLayer.DALServices.DAOThongKeChiPhi;
using static DAL_DataAccessLayer.DALServices.DAO_TK_DoanhThu;
using DAL_DataAccessLayer.Entities;
using static DAL_DataAccessLayer.DALServices.DAO_TK_Tour;

namespace WEBApplication.Models
{
    public class ThongKeModel
    {
        

        public int idTour { get; set; }

        //=============THỐNG KÊ CHI PHÍ=================
        public IPagedList<KetQuaTKCP> listKetQuaTKCP { get; set; }
        public string startDateTKCP { get; set; }
        public string endDateTKCP { get; set; }
        



        // ============THỐNG KÊ NHÂN VIÊN===============
        public IPagedList<KetQuaTKNV> listKetQuaTKNV { get; set; }
        public string startDateTKNV { get; set; }
        public string endDateTKNV { get; set; }



        // ============THỐNG KÊ DOANH THU===============
        public int idDoan { get; set; }

        //public IPagedList<TK_DoanhThu> kq_TK_DoanhThu { get; set; }

        public IPagedList<Doan> kq_TK_DoanhThu { get; set; }
        public string startDateTKDT { get; set; }
        public string endDateTKDT { get; set; }


        // ============THỐNG KÊ TOUR===============
        public int idTour_TKT { get; set; }

        public IPagedList<T> kq_TK_Tour{ get; set; }
        public string startDateTKTour { get; set; }
        public string endDateTKTour { get; set; }

    }
}
