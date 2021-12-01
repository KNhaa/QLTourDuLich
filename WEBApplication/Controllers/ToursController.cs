using BUS_BussinessLayer.BUSServices;
using DAL_DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Index(string? searchString, int? page)
        {
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll().ToList();
            ViewBag.DSLoaiHinh = BUSLoaiHinhDuLich.GetAll().ToList();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if (String.IsNullOrEmpty(searchString))
            {
                var model = new TourViewModel()
                {
                    Tours = BUSTour.GetTours().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
            else
            {
                var item = BUSTour.GetTours().Where(item => item.tenTour.Contains(searchString)).ToList();
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
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll();
            var tour = new TourViewModel()
            {
                tour = BUSTour.GetTour(id)
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
            if (ModelState.IsValid)
            {
                vm.tour.trangThai = true;
                BUSTour.Create(vm.tour);
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
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TourController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TourController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult ThemDiaDiem(TourViewModel vm)
        {
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll();
            var tour = BUSTour.GetTour(vm.tour.maTour);
            
            var maxIndex = 0;
            if (tour.ThamQuans.Count != 0   )
            {
                  maxIndex = tour.ThamQuans.Where(item => item.thuTuThamQuan == tour.ThamQuans.Max(item => item.thuTuThamQuan)).FirstOrDefault().thuTuThamQuan;
            }
           
            if(!tour.ThamQuans.Any(item => item.maDiaDiem == vm.MaDiaDiem))
            {
                tour.ThamQuans.Add(new ThamQuan { maDiaDiem = vm.MaDiaDiem,thuTuThamQuan = maxIndex + 1 });
                BUSTour.Update(tour);


            }
            var model = new TourViewModel
            {
                tour = BUSTour.GetTour(vm.tour.maTour),
            };

            return View("Details", model); ;
        }


      
        public ActionResult Up(int id,int thuTu)
        {
            var tour = BUSTour.GetTour(id);
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll();
            if (thuTu != 1)
            {
                var Obj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu).FirstOrDefault();
                var beforeObj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu-1).FirstOrDefault();
                beforeObj.thuTuThamQuan = thuTu;
                Obj.thuTuThamQuan = thuTu - 1;
                BUSTour.UpdateData(tour);
                
            }
            var model = new TourViewModel
            {
                tour = BUSTour.GetTour(tour.maTour),
            };
            return View("Details", model); ;

        }
        public ActionResult Down(int id, int thuTu)
        {
            var tour = BUSTour.GetTour(id);
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll();
            var maxIndex = tour.ThamQuans.Where(item => item.thuTuThamQuan == tour.ThamQuans.Max(item => item.thuTuThamQuan)).FirstOrDefault().thuTuThamQuan;
            if (thuTu != maxIndex)
            {
                var Obj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu).FirstOrDefault();
                var afterObj = tour.ThamQuans.Where(item => item.thuTuThamQuan == thuTu + 1).FirstOrDefault();
                afterObj.thuTuThamQuan = thuTu;
                Obj.thuTuThamQuan = thuTu + 1;
                BUSTour.UpdateData(tour);

            }
            var model = new TourViewModel
            {
                tour = BUSTour.GetTour(tour.maTour),
            };
            return View("Details", model); 

        }

        public ActionResult DeleteDiaChi(int id, int maDiaDiem)
        {
            var tour = BUSTour.GetTour(id);
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll();
            var Obj = tour.ThamQuans.Where(item => item.maDiaDiem==maDiaDiem).FirstOrDefault();
            tour.ThamQuans.Remove(Obj);
            var i = 1;
            foreach(var item in tour.ThamQuans)
            {
                item.thuTuThamQuan = i;
                i++;
            }
            BUSTour.UpdateData(tour);
            var model = new TourViewModel
            {
                tour = BUSTour.GetTour(tour.maTour),
            };
            return View("Details", model); 
        }

        public ActionResult DeleteGiaTour(int id, int maGiaTour)
        {
            var tour = BUSTour.GetTour(id);
            
            ViewBag.DSDiaDiem = BUSDiaDiem.GetAll();
            Console.WriteLine(tour.GiaTours.Count);

            var Obj = tour.GiaTours.Where(item => item.maGiaTour == maGiaTour).FirstOrDefault();
            tour.GiaTours.Remove(Obj); 
            BUSTour.Update(tour);
            var model = new TourViewModel
            {
                tour = BUSTour.GetTour(id)
            };
            Console.WriteLine(model.tour.GiaTours.Count);
            return View("Details", model);
        }
    }
}
