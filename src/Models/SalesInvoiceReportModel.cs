using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Models
{
  public class SalesInvoiceReportModel
  {
    public string So_HDB { get; set; }
    public string Ma_NV { get; set; }
    public string Ten_NV { get; set; } // Tên nhân viên từ bảng NhanVien
    public DateTime Ngay_ban { get; set; }
    public string Ma_KH { get; set; }
    public string Ten_KH { get; set; } // Tên khách hàng từ bảng Khach_hang
    public decimal Tong_tien { get; set; }
  }
}
