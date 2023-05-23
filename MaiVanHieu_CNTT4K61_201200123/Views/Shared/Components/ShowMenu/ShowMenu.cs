using MaiVanHieu_CNTT4K61_201200123.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaiVanHieu_CNTT4K61_201200123.Views.Shared.Components.ShowMenu
{
    [ViewComponent]
    public class ShowMenu : ViewComponent
    {
        QlbanHangQuanAoContext _context = new QlbanHangQuanAoContext();
        public ShowMenu() { }

        public IViewComponentResult Invoke()
        {
            var phanloais = _context.PhanLoaiPhus.ToList();
            return View(phanloais);
        }
    }
}
