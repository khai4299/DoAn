using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QlKho.Interface;
using QlKho.Models;

namespace QlKho.Controllers
{
    public class HomeController : Controller
    {
        IService service;
        public HomeController(IService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult BanHang()  /// Tran them man hinh ban hang
        {
            return View();
        }
        public IActionResult TonKho()  /// Tran them man hinh hien san pham khi ban hang
        {
            return View();
        }
        public IActionResult TraCuuPhieuThu()  /// Tran them man hinh hien san pham khi ban hang
        {
            return View();
        }
        public IActionResult TaoPhieuNhap()
        {
            //dynamic mymodel = new ExpandoObject();
            //mymodel.PM_STORE = service.GetAllStore();
            //mymodel.PM_INPUTORDER = service.GetAllPM_INPUTORDER();
            TaoPhieuNhap mymodel = new TaoPhieuNhap();
            mymodel.pS = service.GetAllStore();
            list.Clear();
            return View(mymodel);
        }
        [HttpPost]
        public IActionResult TaoPhieuNhap(PM_INPUTORDER pi)
        {
            service.TaoPhieuNhap(pi);
            return RedirectToAction(nameof(Index));
        }
        public static List<SP_TaoPhieuNhap> list = new List<SP_TaoPhieuNhap>();
        public IActionResult ThemSanPham(PM_INPUTORDER pi, SP_TaoPhieuNhap spt)
        {
            Debug.WriteLine("Log" + list.Count);
            TaoPhieuNhap mymodel = new TaoPhieuNhap();
            mymodel.pS = service.GetAllStore();
            mymodel.ispt = service.GetAllThemSanPham(list, spt);
            mymodel.tpnt = new TaoPhieuNhap_Temp();
            mymodel.pi = pi;
            service.TaoPhieuNhap_Temp(mymodel.tpnt, mymodel);
            return View("TaoPhieuNhap", mymodel);
        }
        public IActionResult TaoPhieuXuat()
        {
            TaoPhieuXuat mymodel = new TaoPhieuXuat();
            mymodel.pS = service.GetAllStore();
            return View(mymodel);
        }
        [HttpPost]
        public IActionResult TaoPhieuXuat(PM_OUTPUTVOUCHER po)
        {
            service.TaoPhieuXuat(po);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ChuyenKho()
        {
            return View();
        }
        public IActionResult TraCuuPhieuNhap()
        {
            TraCuuPhieuNhap mymodel = new TraCuuPhieuNhap();
            mymodel.pS = service.GetAllStore();
            mymodel.TuNgay = DateTime.Today;
            mymodel.DenNgay = mymodel.TuNgay.AddDays(1);
            return View(mymodel);
        }
        [HttpPost]
        public IActionResult TraCuuPhieuNhap(TraCuuPhieuNhap traCuuPhieuNhap)
        {
            TraCuuPhieuNhap mymodel = new TraCuuPhieuNhap();
            mymodel.pS = service.GetAllStore();
            mymodel.pi = service.TraCuuPhieuNhap(traCuuPhieuNhap);
            return View(mymodel);
        }
        public IActionResult TraCuuPhieuXuat()
        {
            TraCuuPhieuXuat mymodel = new TraCuuPhieuXuat();
            mymodel.pS = service.GetAllStore();
            mymodel.TuNgay = DateTime.Today;
            mymodel.DenNgay = mymodel.TuNgay.AddDays(1);
            return View(mymodel);
        }
        [HttpPost]
        public IActionResult TraCuuPhieuXuat(TraCuuPhieuXuat traCuuPhieuXuat)
        {
            TraCuuPhieuXuat mymodel = new TraCuuPhieuXuat();
            mymodel.pS = service.GetAllStore();
            mymodel.po = service.TraCuuPhieuXuat(traCuuPhieuXuat);
            foreach (var item in mymodel.po)
            {
                Debug.WriteLine(item.OUTPUTVOUCHERID);
            }
            return View(mymodel);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
