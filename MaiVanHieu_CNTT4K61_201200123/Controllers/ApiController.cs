using MaiVanHieu_CNTT4K61_201200123.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaiVanHieu_CNTT4K61_201200123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamsController : ControllerBase
    {
        private QlbanHangQuanAoContext _context = new QlbanHangQuanAoContext();
        [HttpGet("loais/{maLoai}")]
        public IActionResult getSanPhamTheoLoai(string maloai)
        {
            var sanphams = _context.SanPhams.Where(x => x.MaPhanLoaiPhu.Equals(maloai)).ToList();
            return Ok(sanphams);
        }
    }
}
