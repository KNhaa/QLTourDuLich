using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using static DAL_DataAccessLayer.DALServices.DAOThongKeNhanVien;

namespace WEBApplication.Models
{
    public class TKNhanVienViewModel
    {
        //public KetQuaTKNV ketqua { get; set; }
        public IPagedList<KetQuaTKNV> listKetQuaTKNV { get; set; }
        public string dateStartSearch { get; set; }
        public string dateEndSearch { get; set; }
    }
}
