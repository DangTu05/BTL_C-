using System;

namespace BTL_C_.src.Models
{
  public class EmployeeModel
  {
    public string MaNhanVien { get; set; }
    public string TenNhanVien { get; set; }
    public DateTime? NgaySinh { get; set; }
    public string SoDienThoai { get; set; }
    public string DiaChi { get; set; }
    public string MaCV { get; set; }
    public string GioiTinh { get; set; }


    // Constructor không tham số
    public EmployeeModel() { }

    // Constructor đầy đủ tham số
    public EmployeeModel(string manhanvien, string tennhanvien, DateTime? ngaysinh,
                    string sodienthoai, string diachi, string macv, string gioitinh)
    {
      MaNhanVien = manhanvien;
      TenNhanVien = tennhanvien;
      NgaySinh = ngaysinh ?? null;
      SoDienThoai = sodienthoai;
      DiaChi = diachi;
      MaCV = macv;
      GioiTinh = gioitinh;
    }

  }
}
