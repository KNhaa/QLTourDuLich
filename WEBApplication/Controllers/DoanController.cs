using BUS_BussinessLayer.BUSServices;
using Microsoft.AspNetCore.Mvc;
using DAL_DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBApplication.Models;
using X.PagedList;

namespace WEBApplication.Controllers
{
    public class DoanController : Controller
    {
        //GET: DoanController
        BUSDoan _busDoan;
        BUSChiTietDoan _busCT;
        BUSKhachHang _busKH;

        public DoanController()
        {
            _busDoan = new BUSDoan();
            _busCT = new BUSChiTietDoan();
            _busKH = new BUSKhachHang();
        }
        public IActionResult Index(string? searchString, int? page)
        {
            ViewBag.dsTour = _busDoan.GetTour().ToList();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            if(String.IsNullOrEmpty(searchString))
            {
                var model = new DoanViewModel()
                {
                    Doan = _busDoan.GetDoan().ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
            else
            {
                var item = _busDoan.GetDoan().Where(doans => doans.maDoan.Equals(searchString)).Select(doans => doans).ToList();
                var model = new DoanViewModel()
                {
                    Doan = item.ToPagedList(pageNumber, pageSize)
                };
                return View(model);
            }
        }

        //POST: DoanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DoanViewModel d)
        {
            DateTime ngKhHanh = Convert.ToDateTime(d.doans.ngayKhoiHanh);
            DateTime ngKThuc = Convert.ToDateTime(d.doans.ngayKetThuc);
            if ((ngKhHanh < DateTime.Now) || (ngKThuc < ngKhHanh))
            {
                return RedirectToAction(nameof(Index));
            }
            else 
            {
                if (ModelState.IsValid)
                {
                    _busDoan.Create(d.doans);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            } 
        }

        //GET:DoanController/edit/id
        public ActionResult edit(int id)
        {
            ViewBag.dsTour = _busDoan.GetTour().ToList();
            var Doan = _busDoan.GetDoan();
            var d = Doan.Single(doans => doans.maDoan == id);
            var model = new DoanViewModel()
            {
                doans = d
            };
            return View(model);
        }

        //POST: DoanController/edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateDoan(DoanViewModel d)
        {
            if (ModelState.IsValid)
            {
                _busDoan.Update(d.doans);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("edit", new {id=d.doans.maDoan });
        }

        //POST: DoanController/Delete/id
        public ActionResult DeleteDoan(int id)
        {
            var Doan = _busDoan.GetDoan();
            var doan = Doan.Single(doans => doans.maDoan == id);
            _busDoan.Delete(doan);
            return RedirectToAction(nameof(Index));
        }

        // GET: DoanController/Details
        public ActionResult Details(int id)
        {
            var Doan = _busDoan.GetDoan();
            var d = Doan.Single(doans => doans.maDoan == id);
            var model = new DoanViewModel()
            {

                ctDoan = _busCT.GetChiTietDoan(d),
                dsDiaDiemDoan = _busCT.GetDiaDiem(d),
                dsKhachDoan = _busCT.GetDsKhach(d),
                dsNhanVienDoan = _busCT.GetDsNhanVien(d),
                dsChiPhiDoan = _busCT.GetDsChiPhi(d),
                dsKhach = _busKH.getListKhachHang(),
                dsNhanVien = _busCT.GetNhanVien(),
                loaiChiPhi = _busCT.GetLoaiChiPhi()
            };

            foreach (Khach khach in model.dsKhach)
            {
                khach.tenKh = khach.maKh + ". " + khach.tenKh;
            }
            ViewBag.khachHang = model.dsKhach;
            return View(model);
        }

        //POST: DoanController/Details/addKhach
        public ActionResult addKhach(DoanViewModel d)
        {
            var Doan = _busDoan.GetDoan();
            var doan = Doan.Single(doans => doans.maDoan == d.ctDoan.maDoan);
            var dsKhach = _busCT.GetDsKhach(doan);
            var khach = dsKhach.Where(khach => khach.maKh == d.Khach.maKh).ToList();
            if(khach.Count == 0)
            {
                ChiTiet ct = new ChiTiet();
                ct.maKh = d.Khach.maKh;
                ct.maDoan = d.ctDoan.maDoan;
                _busCT.addKhach(ct);
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan });
            } else
            {
                ViewBag.addKhachError = 1;
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan });
            }
        }

        //POST: DoanController/Delete/id
        public ActionResult DeleteKhach(int idKhach, int idDoan)
        {
            ChiTiet ct = new ChiTiet();
            ct.maKh = idKhach;
            ct.maDoan = idDoan;
            _busCT.delKhach(ct);
            return RedirectToAction("Details", new { id = idDoan });
        }
    }
}
