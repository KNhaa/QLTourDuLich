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
        BUSGiaTour _busGiaTour;

        public DoanController()
        {
            _busDoan = new BUSDoan();
            _busCT = new BUSChiTietDoan();
            _busKH = new BUSKhachHang();
            _busGiaTour = new BUSGiaTour();
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
                try
                {
                    var search = int.Parse(searchString);
                    var item = _busDoan.GetDoan().Where(doans => doans.maDoan == search).Select(doans => doans).ToList();
                    var model = new DoanViewModel()
                    {
                        Doan = item.ToPagedList(pageNumber, pageSize)
                    };
                    return View(model);
                }
                catch
                {
                    var item = _busDoan.GetDoan().Where(doans => doans.maDoan.Equals(searchString)).Select(doans => doans).ToList();
                    var model = new DoanViewModel()
                    {
                        Doan = item.ToPagedList(pageNumber, pageSize)
                    };
                    return View(model);
                }
                
            }
        }

        //POST: DoanController/Create
        [HttpPost]
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
                _busDoan.Create(d.doans);
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
        public ActionResult UpdateDoan(DoanViewModel d)
        {
            var gias = _busGiaTour.GetByTourId(d.doans.maTour);
            var gia = gias.SingleOrDefault(g => d.doans.ngayKhoiHanh >= g.ngayKhoiHanh && d.doans.ngayKhoiHanh < g.ngayKetThuc);
            if (gia == null)
            {
                d.doans.doanhThu = 0;
            }
            else
            {
                var khachDoan = _busCT.GetDsKhach(d.doans).ToList();
                d.doans.doanhThu = (float)(khachDoan.Count * gia.thanhTien);
            }
            _busDoan.Update(d.doans);
            return RedirectToAction(nameof(Index));
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
            ViewBag.loaiChiPhi = model.loaiChiPhi;
            ViewBag.tongTien = model.dsChiPhiDoan.Select(cp => cp.soTien).Sum();
            foreach (NhanVien nv in model.dsNhanVien)
            {
                nv.tenNv = nv.maNv + ". " + nv.tenNv;
            }
            ViewBag.nhanVien = model.dsNhanVien;
            return View(model);
        }

        //POST: DoanController/Details/addKhach
        [HttpPost]
        public ActionResult addKhach(DoanViewModel d)
        {
            if(d.Khach.maKh == 0)
            {
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab2" });
            }
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
                dsKhach = _busCT.GetDsKhach(doan);
                doan.doanhThu = (float)(dsKhach.Count * d.ctDoan.giaTour);
                _busDoan.Update(doan);
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab2" });
            } else
            {
                ViewBag.addKhachError = 1;
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab2" });
            }
        }

        //POST: DoanController/deleteKhach/id
        public ActionResult deleteKhach(int idKhach, int idDoan)
        {
            ChiTiet ct = new ChiTiet();
            ct.maKh = idKhach;
            ct.maDoan = idDoan;
            _busCT.delKhach(ct);
            var Doan = _busDoan.GetDoan();
            var doan = Doan.Single(doans => doans.maDoan == idDoan);
            var ctDoan = _busCT.GetChiTietDoan(doan);
            var dsKhach = _busCT.GetDsKhach(doan);
            doan.doanhThu = (float)(dsKhach.Count * ctDoan.giaTour);
            _busDoan.Update(doan);
            return RedirectToAction("Details", new { id = idDoan, tab = "tab2" });
        }

        //POST: DoanController/Details/addChiPhi
        [HttpPost]
        public ActionResult addCP(DoanViewModel d)
        {
            if(d.chiPhi.maLoaiCP == 0)
            {
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab3" });
            }
            ChiPhi cp = new ChiPhi();
            cp.maDoan = d.ctDoan.maDoan;
            cp.soTien = d.chiPhi.soTien;
            cp.maLoaiCP = d.chiPhi.maLoaiCP;
            _busCT.addChiPhi(cp);
            return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab3" });
        }

        //POST: DoanController/Details/deleteCP/id
        public ActionResult deleteCP(int idCP, int idDoan)
        {
            ChiPhi cp = new ChiPhi();
            cp.maDoan = idDoan;
            cp.maChiPhi = idCP;
            _busCT.delChiPhi(cp);
            return RedirectToAction("Details", new { id = idDoan, tab = "tab3" });
        }
        //POST: DoanController/Details/addNhanVien
        [HttpPost]
        public ActionResult addNV(DoanViewModel d)
        {
            if(d.phanBo.maNv == 0)
            {
                return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab4" });
            }
            PhanBo pb = new PhanBo();
            pb.maDoan = d.ctDoan.maDoan;
            pb.maNv = d.phanBo.maNv;
            pb.nhiemVu = d.phanBo.nhiemVu;
            _busCT.addNhanVienDoan(pb);
            return RedirectToAction("Details", new { id = d.ctDoan.maDoan, tab = "tab4" });
        }

        //POST: DoanController/Details/deleteNV/id
        public ActionResult deleteNV(int idNV, int idDoan)
        {
            PhanBo pb = new PhanBo();
            pb.maDoan = idDoan;
            pb.maNv = idNV;
            _busCT.delNhanVien(pb);
            return RedirectToAction("Details", new { id = idDoan, tab = "tab4" });
        }
    }
}
