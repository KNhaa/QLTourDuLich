using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer.DALServices;

namespace WEBApplication.Controllers
{
    public class ThongKeController : Controller
    {
        BUSThongKeNhanVien busThongKeNhanVien = new BUSThongKeNhanVien();
        BUSThongKeChiPhi busThongKeChiPhi = new BUSThongKeChiPhi();
        BUSTour busTour = new BUSTour();
        // tk chi phí
        //====================THỐNG KÊ CHI PHÍ============================================================
        public IActionResult TK_ChiPhi(string? startDateTKCP, string? endDateTKCP, int? idTour, int? page)
        {
            ViewBag.DSTours = busTour.GetTours().ToList();
            ViewBag.total = 0;

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if(!String.IsNullOrEmpty(startDateTKCP) && !String.IsNullOrEmpty(endDateTKCP))
            {
                DateTime dateStart = Convert.ToDateTime(startDateTKCP);
                DateTime dateEnd = Convert.ToDateTime(endDateTKCP);
                if (idTour == null)
                {
                    //thống kê chi phí của tất cả các tour trong khoảng thời gian                  
                    var model = new Models.ThongKeModel()
                    {
                        
                        listKetQuaTKCP = busThongKeChiPhi.loadChiPhiTheoNgay(dateStart, dateEnd).ToPagedList(pageNumber, pageSize)
                    };                    
                    return View(model);
                }            
                else 
                {
                    //thống kê chi phí của 1 tour trong khoảng thời gian
                    var model = new Models.ThongKeModel()
                    {
                        
                        listKetQuaTKCP = busThongKeChiPhi.loadChiPhiTheoNgayMaTour(dateStart, dateEnd, (int)idTour).ToPagedList(pageNumber, pageSize)
                    };
                    return View(model);
                }    
            }
            else
            {
                //thống kê chi phí từ trước tới nay
                var model = new Models.ThongKeModel()
                {
                    
                    listKetQuaTKCP = busThongKeChiPhi.loadChiPhiTatCa().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }    
            
           
        }
        public IActionResult TK_DoanhThu()
        {
            return View();

        }


        //====================THỐNG KẾ SỐ LẦN ĐI TOUR CỦA NHÂN VIÊN=======================================
        public IActionResult TK_NhanVien(string? startDateTKNV, string? endDateTKNV, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if (String.IsNullOrEmpty(startDateTKNV) || String.IsNullOrEmpty(endDateTKNV))
            {
                var model = new Models.ThongKeModel()
                {

                   listKetQuaTKNV = busThongKeNhanVien.thongkeTatCaNgay().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
            else
            {
                DateTime dateStart = Convert.ToDateTime(startDateTKNV);
                DateTime dateEnd = Convert.ToDateTime(endDateTKNV);
                var model = new Models.ThongKeModel()
                {

                    listKetQuaTKNV = busThongKeNhanVien.thongkeTheoNgay(dateStart, dateEnd)
                                                        .ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }

        }
        public IActionResult TK_Tour()
        {
            return View();

        }

    }
}
