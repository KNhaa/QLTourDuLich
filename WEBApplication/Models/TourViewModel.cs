using DAL_DataAccessLayer.Entities;
using X.PagedList;

namespace WEBAplication.Models
{
    public class TourViewModel
    {
        public IPagedList<Tour> Tours { get; set; }
        public Tour tour { get; set; }
        public int MaDiaDiem { get; set; }
        public string searchString { get; set; }
       

    }
}
