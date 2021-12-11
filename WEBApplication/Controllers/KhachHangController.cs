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

namespace WEBApplication.Controllers
{
    public class KhachHangController : Controller
    {
        public static int idKhach = 0;
        BUSKhachHang _busKhachHang = new BUSKhachHang();
        BUSKhachHangDoan _bus_KhachDoan = new BUSKhachHangDoan();
        // GET: KhachHangController
        public ActionResult Index(string? searchString, int? page)
        {
            List<String> gioiTinhs = new List<string>();
            gioiTinhs.Add("Nam");
            gioiTinhs.Add("Nữ");
            ViewBag.gioiTinh = gioiTinhs;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if (String.IsNullOrEmpty(searchString))
            {
                var model = new KhachHangViewModel()
                {
                    khachHangs =_busKhachHang.getListKhachHang().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
            else
            {
                var item =_busKhachHang.searchKhachHang(searchString);
                var model = new KhachHangViewModel()
                {
                    khachHangs= item.ToPagedList(pageNumber, pageSize),
                };
                return View(model);
            }
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(int id, int ?page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
                var model = new KhachHangViewModel()
                {
                    doans = _bus_KhachDoan.getAllDoans(id).ToPagedList(pageNumber, pageSize)
                };
                return View("Details",model);
        }
        // GET: KhachHangController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: KhachHangController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KhachHangViewModel kh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   _busKhachHang.themKhachHang(kh.khach);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {

                idKhach = id;
                var model = new KhachHangViewModel()
                {
                    khach = _busKhachHang.getKhach(id)
                    };
                  
                
                return View("Edit", model);

            }
            catch
            {
                return View();
            }
        }
        // POST: KhachHangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditKhach(KhachHangViewModel kh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Khach k = new Khach();
                    k.maKh = idKhach;
                    k.tenKh = kh.khach.tenKh;
                    k.diaChi = kh.khach.diaChi;
                    k.cnmd = kh.khach.cnmd;
                    k.gioiTinh = kh.khach.gioiTinh;
                    k.quocTich = kh.khach.quocTich;
                    k.sdt = kh.khach.sdt;
                    
                  
                    _busKhachHang.updateKhachHang(k);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteKhachDoan(int id)
        {
            _bus_KhachDoan.deleteDoanVaChiTiet(id);
            return RedirectToAction(nameof(Details));
        }
        // GET: KhachHangController/Delete/5
        // delete khach hàng
        public ActionResult Delete(int id)
        {
            Khach kh = _busKhachHang.getKhach(id);
                if( kh!= null)
            {
                _busKhachHang.deleteKhachHang(kh);
            }
            return RedirectToAction(nameof(Index));
        }
        // POST: KhachHangController/Delete/5
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
    }
}
