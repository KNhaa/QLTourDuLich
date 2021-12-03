using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using static DAL_DataAccessLayer.DALServices.DAOThongKeNhanVien;
using static DAL_DataAccessLayer.DALServices.DAOThongKeChiPhi;
using DAL_DataAccessLayer.Entities;

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
        
    }
}
