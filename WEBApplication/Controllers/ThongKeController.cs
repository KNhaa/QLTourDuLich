using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBApplication.Controllers
{
    public class ThongKeController : Controller
    {
        // tk chi phí
        public IActionResult TK_ChiPhi()
        {
            return View();
           
        }
        public IActionResult TK_DoanhThu()
        {
            return View();

        }
        public IActionResult TK_NhanVien()
        {
            return View();

        }
        public IActionResult TK_Tour()
        {
            return View();

        }

    }
}
