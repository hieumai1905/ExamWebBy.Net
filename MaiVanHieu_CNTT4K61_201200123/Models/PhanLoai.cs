using System;
using System.Collections.Generic;

namespace MaiVanHieu_CNTT4K61_201200123.Models;

public partial class PhanLoai
{
    public string MaPhanLoai { get; set; } = null!;

    public string? PhanLoaiChinh { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
