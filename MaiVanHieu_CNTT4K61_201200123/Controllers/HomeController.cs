using MaiVanHieu_CNTT4K61_201200123.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace MaiVanHieu_CNTT4K61_201200123.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private QlbanHangQuanAoContext _context = new QlbanHangQuanAoContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var sanphams = _context.SanPhams.ToList();
            return View(sanphams);
        }
        [HttpGet]
        public IActionResult create()
        {
            ViewBag.MaPhanLoai = new SelectList(_context.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(_context.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View();
        }


        [HttpPost]
        public IActionResult create(SanPham sanpham)
        {
            if (ModelState.IsValid)
            {
                _context.SanPhams.Add(sanpham);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaPhanLoai = new SelectList(_context.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(_context.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View();
        }

        public IActionResult Detail(string masp)
        {
            var sanpham = _context.SanPhams.SingleOrDefault(x => x.MaSanPham.Equals(masp));
            return View(sanpham);
        }

        [HttpGet]
        public IActionResult Edit(string masp)
        {
            var sanpham = _context.SanPhams.SingleOrDefault(x => x.MaSanPham.Equals(masp));
            ViewBag.MaPhanLoai = new SelectList(_context.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(_context.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(sanpham);
        }
        [HttpPost]
        public IActionResult Edit(SanPham sanpham)
        {
            if (ModelState.IsValid)
            {
                _context.SanPhams.Update(sanpham);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaPhanLoai = new SelectList(_context.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(_context.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(sanpham);
        }

		[HttpGet]
		public IActionResult delete(string masp)
		{
            var sanpham = _context.SanPhams.Single(x => x.MaSanPham.Equals(masp));   
            _context.SanPhams.Remove(sanpham);
            _context.SaveChanges();
            return RedirectToAction("Index");
		}


		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}