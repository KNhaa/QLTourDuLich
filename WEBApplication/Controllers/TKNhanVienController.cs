using BUS_BussinessLayer.BUSServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAplication.Models;
using X.PagedList;

namespace WEBApplication.Controllers
{
    public class TKNhanVienController : Controller
    {
        BUSThongKeNhanVien busThongKeNhanVien = new BUSThongKeNhanVien();
        public IActionResult Index(string? dateStartSearch, string? dateEndSearch, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if(String.IsNullOrEmpty(dateStartSearch) || String.IsNullOrEmpty(dateEndSearch))
            {
                var model = new Models.TKNhanVienViewModel()
                {

                    listKetQuaTKNV = busThongKeNhanVien.thongkeTatCaNgay().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
            else
            {
                DateTime dateStart = Convert.ToDateTime(dateStartSearch);
                DateTime dateEnd = Convert.ToDateTime(dateEndSearch);
                var model = new Models.TKNhanVienViewModel()
                {

                    listKetQuaTKNV = busThongKeNhanVien.thongkeTheoNgay(dateStart, dateEnd)
                                                        .ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }    
        }    
            
    }
}
