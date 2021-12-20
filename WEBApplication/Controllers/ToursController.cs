using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAplication.Models;
using X.PagedList;

namespace WEBAplication.Controllers
{
    public class ToursController : Controller
    {
        // GET: TourController

        BUSTour _busTour;
        BUSDiaDiem _busDiaDiem;
        BUSLoaiHinhDuLich _loaiHinhDuLich;
        BUSGiaTour _busGiaTour;
        BUSDoan _busDoan;
        BUSChiTietDoan _busChiTietDoan;
        public ToursController()
        {
            _busTour = new BUSTour();
            _busDiaDiem = new BUSDiaDiem();
            _loaiHinhDuLich = new BUSLoaiHinhDuLich();
            _busGiaTour = new BUSGiaTour();
            _busDoan = new BUSDoan();
            _busChiTietDoan = new BUSChiTietDoan();
        }
        public ActionResult Index(string? searchString, int? page)
        {
            ViewBag.DSDiaDiem = _busDiaDiem.GetAll().ToList();
            ViewBag.DSLoaiHinh = _loaiHinhDuLich.GetAll().ToList();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if (String.IsNullOrEmpty(searchString))
            {
                var model = new TourViewModel()
                {
                    Tours = _busTour.GetTours().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
            else
            {
                var item = _busTour.GetTours().Where(item => item.tenTour.Contains(searchString)).ToList();
                var model = new TourViewModel()
                {
                    Tours = item.ToPagedList(pageNumber, pageSize),
                };
                return View(model);
            }
        }

        // GET: TourController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.DSDiaDiem = _busDiaDiem.GetAll();
            ViewBag.DSLoaiHinh = _loaiHinhDuLich.GetAll();
            var tour = new TourViewModel()
            {
                tour = _busTour.GetTour(id)
            };
            return View(tour);
        }

        // GET: TourController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TourController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TourViewModel vm)
        {
            vm.tour!.trangThai = true;
            if (ModelState.IsValid)
            {
                Console.WriteLine("Hello");
              
                _busTour.Create(vm.tour);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: TourController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TourController/Edit/5
        [HttpPost]
        public ActionResult Edit(TourViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var tour = vm.tour;
                tour.trangThai = true;
                _busTour.Update(tour);
                return RedirectToAction("Details", new { id = tour!.maTour });
            }
            else
            {
                Console.WriteLine("Hello");
            }
          
            return RedirectToAction("Details", new { id = vm.tour!.maTour });
        }

        // GET: TourController/Delete/5

  
        
        // POST: TourController/Delete/5
 
        public ActionResult Delete(int id)
        {
            var tour = _busTour.GetTour(id);
            tour!.trangThai = false;
            _busTour.Update(tour);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public ActionResult ThemDiaDiem(TourViewModel vm)
        {

            ViewBag.DSDiaDiem = _busDiaDiem.GetAll();
            var tour = _busTour.GetTour(vm.tour!.maTour);

            var maxIndex = 0;
            if (tour.ThamQuans.Count != 0   )
            {
                  maxIndex = tour.ThamQuans.Where(item => item.thuTuThamQuan == tour.ThamQuans.Max(item => item.thuTuThamQuan)).FirstOrDefault().thuTuThamQuan;
            }
          
            if(!tour.ThamQuans.Any(item => item.maDiaDiem == vm.MaDiaDiem))
            {
                tour.ThamQuans.Add(new ThamQuan { maDiaDiem = vm.MaDiaDiem,thuTuThamQuan = maxIndex + 1 });
                _busTour.Update(tour);


            }
            return RedirectToAction("Details", new { id = tour.maTour });
        }

        public ActionResult Up(int id,int thuTu)
        {
            var tour = _busTour.GetTour(id);
            if (thuTu != 1)
            {
                var Obj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu).FirstOrDefault();
                var beforeObj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu-1).FirstOrDefault();
                beforeObj!.thuTuThamQuan = thuTu;
                Obj!.thuTuThamQuan = thuTu - 1;
                _busTour.UpdateData(tour);
                
            }
            return RedirectToAction("Details", new { id = tour.maTour });

        }
        public ActionResult Down(int id, int thuTu)
        {
            var tour = _busTour.GetTour(id);
            var maxIndex = tour.ThamQuans.Where(item => item.thuTuThamQuan == tour.ThamQuans.Max(item => item.thuTuThamQuan)).FirstOrDefault().thuTuThamQuan;
            if (thuTu != maxIndex)
            {
                var Obj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu).FirstOrDefault();
                var afterObj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu + 1).FirstOrDefault();
                afterObj!.thuTuThamQuan = thuTu;
                Obj!.thuTuThamQuan = thuTu + 1;
                _busTour.UpdateData(tour);
            }
            return RedirectToAction("Details", new {id=tour.maTour}); 

        }

        public ActionResult DeleteDiaChi(int id, int maDiaDiem)
        {
            var tour = _busTour.GetTour(id);
            var Obj = tour.ThamQuans.Where(item => item.maDiaDiem==maDiaDiem).FirstOrDefault();
            tour.ThamQuans.Remove(Obj);
            var i = 1;
            foreach(var item in tour.ThamQuans)
            {
                item.thuTuThamQuan = i;
                i++;
            }
            _busTour.UpdateData(tour);
           
            return RedirectToAction("Details",new { id=id});
        }

        public ActionResult DeleteGiaTour(int id, int maGiaTour)
        {

            var tour = _busTour.GetTour(id);

            var Obj = tour.GiaTours.Where(item => item.maGiaTour == maGiaTour && item.maTour==id).FirstOrDefault();
            tour.GiaTours.Remove(Obj);
            _busGiaTour.Delete(Obj!.maGiaTour);
            _busTour.Update(tour);
            return RedirectToAction("Details", new { id = tour.maTour });
        }

        public ActionResult ThemGiaTour(TourViewModel vm)
        {
            var tour = _busTour.GetTour(vm.tour!.maTour);
            tour.GiaTours.Add(vm.giaTour);
            _busTour.Update(tour);
            var doans = _busDoan.GetDoan().ToList();
            var doan = doans.Where(d => d.maTour == vm.giaTour.maTour && (d.ngayKhoiHanh >= vm.giaTour.ngayKhoiHanh && d.ngayKhoiHanh < vm.giaTour.ngayKetThuc)).ToList();
            if (doan.Count != 0)
            {
                foreach (Doan d in doan)
                {
                    var slKhach = _busChiTietDoan.GetDsKhach(d).Count;
                    d.doanhThu = (float)(slKhach * vm.giaTour.thanhTien);
                    _busDoan.Update(d);
                }
            }
            return RedirectToAction("Details", new { id = tour.maTour });

        }
    }
}
