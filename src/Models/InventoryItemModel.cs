using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Models
{
  internal class InventoryItemModel
  {
    public string MaQuanAo { get; set; }
    public string TenTheLoai { get; set; }
    public string TenMau { get; set; }
    public string TenNSX { get; set; }
    public string TenDoiTuong { get; set; }
    public string TenMua { get; set; }
    public string TenCo { get; set; }
    public string TenChatLieu { get; set; }
    public int SlTonKho { get; set; }
    public decimal DonGiaBan { get; set; }
    public string TrangThai { get; set; }
    public DateTime? NgayNhapCuoiCung { get; set; } // Ngày nhập gần nhất của sản phẩm

  }
}
