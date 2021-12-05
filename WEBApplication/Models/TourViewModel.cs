using DAL_DataAccessLayer.Entities;
using X.PagedList;
using X.PagedList.Mvc;

namespace WEBAplication.Models
{
    public class TourViewModel
    {
        public IPagedList<Tour>? Tours { get; set; }
        public Tour? tour { get; set; }
        public int MaDiaDiem { get; set; }
        public string? searchString { get; set; }
       

        public GiaTour? giaTour { get; set; }

    }
}
