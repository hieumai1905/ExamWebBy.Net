using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaiVanHieu_CNTT4K61_201200123.Models;

public partial class SanPham
{
    public string MaSanPham { get; set; } = null!;

    [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Tên sản phẩm phải bắt đầu bằng một chữ cái.")]
    [Display(Name ="test")]
    public string TenSanPham { get; set; } = null!;

    public string? MaPhanLoai { get; set; }
    [RegularExpression(@"^\d+$", ErrorMessage = "Giá nhập phải là số")]
    public long? GiaNhap { get; set; }
    [RegularExpression(@"^\d+$", ErrorMessage = "Giá bán nhỏ nhất phải là số")]
    public long? DonGiaBanNhoNhat { get; set; }
    [RegularExpression(@"^\d+$", ErrorMessage = "Giá bán lớn nhất phải là số")]
    public long? DonGiaBanLonNhat { get; set; }

    public bool? TrangThai { get; set; }

    [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Mô tả ngắn phải bắt đầu bằng một chữ cái.")]
    public string? MoTaNgan { get; set; }

    public string? AnhDaiDien { get; set; }

    public bool? NoiBat { get; set; }

    public string? MaPhanLoaiPhu { get; set; }

    public virtual PhanLoai? MaPhanLoaiNavigation { get; set; }

    public virtual PhanLoaiPhu? MaPhanLoaiPhuNavigation { get; set; }

    public virtual ICollection<SptheoMau> SptheoMaus { get; set; } = new List<SptheoMau>();
}
