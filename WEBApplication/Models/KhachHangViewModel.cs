using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace WEBAplication.Models
{
    public class KhachHangViewModel
    {
        public IPagedList<Khach> khachHangs { get; set; }
        public IPagedList<Doan> doans { get; set; }
        public Khach khach { get; set; }
        public string searchString { get; set; }
    }
}

