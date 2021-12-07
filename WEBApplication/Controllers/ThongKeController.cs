using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        //====================THỐNG KÊ DOANH THU=========================================================

         BUS_TK_DoanhThu busTKDT = new BUS_TK_DoanhThu();
       
         public IActionResult TK_DoanhThu(string? startDateTKDT, string? endDateTKDT, int? idDoan, int? page)
         {
             ViewBag.DSDoan = busTKDT.GetDoans().ToList();
             ViewBag.total = 0;
             
            int pageSize = 10;
             int pageNumber = (page ?? 1);
             if (!String.IsNullOrEmpty(startDateTKDT) && !String.IsNullOrEmpty(endDateTKDT))
             {
                 DateTime dateStart = Convert.ToDateTime(startDateTKDT);
                 DateTime dateEnd = Convert.ToDateTime(endDateTKDT);
                 if (idDoan == null)
                 {
                    //thống kê doanh thu của tất cả các đoàn trong khoảng thời gian                  
                    var model = new Models.ThongKeModel()
                    {

                        kq_TK_DoanhThu = busTKDT.GetDoansFrom(dateStart, dateEnd).ToPagedList(pageNumber, pageSize),
                        //sum= busTKDT.GetDoansFrom(dateStart, dateEnd).Select(c => c.doanhThu).Sum()

                };
                    
                     return View(model);
                 }
                 else
                 {
                     //thống kê doanh thu của 1 đoàn trong khoảng thời gian
                     var model = new Models.ThongKeModel()
                     {

                         kq_TK_DoanhThu = busTKDT.tkMaDoan(dateStart, dateEnd,idDoan.ToString()).ToPagedList(pageNumber, pageSize)
                         

                     };
                    
                     return View(model);
                 }
             }
             else
             {
                //thống kê doanh thu từ trước tới nay
                var model = new Models.ThongKeModel()
                {

                    kq_TK_DoanhThu = busTKDT.GetDoans().ToPagedList(pageNumber, pageSize),
                    //sum = busTKDT.GetDoans().Select(c => c.doanhThu).Sum()

                };
                return View(model);
             }
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
        //====================Thống kê doanh số TOUR dựa trên mã TOUR==================
        
        BUS_TK_Tour busTKTour = new BUS_TK_Tour();

        public IActionResult TK_Tour(string? startDateTKTour, string? endDateTKTour, int? idTour_TKT, int? page)
        {
            ViewBag.DSTour = busTKTour.GetTours().ToList();
            ViewBag.total = 0;

            //ViewBag.MaTour = new SelectList(busTKTour.GetTours().Distinct(), "maTourTK", "maTourTk").ToList();

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(startDateTKTour) && !String.IsNullOrEmpty(endDateTKTour))
            {
                DateTime dateStart = Convert.ToDateTime(startDateTKTour);
                DateTime dateEnd = Convert.ToDateTime(endDateTKTour);
                if (idTour_TKT == null)
                {
                    //thống kê tour trong khoảng thời gian                  
                    var model = new Models.ThongKeModel()
                    {

                        kq_TK_Tour = busTKTour.GetToursFrom(dateStart, dateEnd).ToPagedList(pageNumber, pageSize)


                    };

                    return View(model);
                }
                else
                {
                    //thống kê tour của 1 đoàn trong khoảng thời gian
                    var model = new Models.ThongKeModel()
                    {

                        kq_TK_Tour = busTKTour.tkMaTour(dateStart, dateEnd, idTour_TKT.ToString()).ToPagedList(pageNumber, pageSize)


                    };

                    return View(model);
                }
            }
            else
            {
                //thống kê tour từ trước tới nay
                var model = new Models.ThongKeModel()
                {
                   
                    kq_TK_Tour = busTKTour.GetTours().ToPagedList(pageNumber, pageSize)
                    

                };
                return View(model);
            }
        }

    }
}
