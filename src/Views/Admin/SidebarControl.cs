using System;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class SidebarControl : UserControl
  {
    public SidebarControl()
    {
      InitializeComponent();
    }
    public void SetTaiKhoanListener(EventHandler handler) => btnTaiKhoan.Click += handler;
    public void SetSanPhamListener(EventHandler handler) => btnSanPham.Click += handler;
    public void SetDangXuatListener(EventHandler handler) => btnDangXuat.Click += handler;
    public void SetNhaCungCapListener(EventHandler handler) => btnNhaCungCap.Click += handler;
    public void SetTrangChuListener(EventHandler handler) => btnTrangChu.Click += handler;
    public void SetNhanVienListener(EventHandler handler) => btnNhanVien.Click += handler;
    public void SetKhachHangListener(EventHandler handler) => btnKhachHang.Click += handler;
    public void SetDoanhThuListener(EventHandler handler) => btnDoanhThu.Click += handler;
    public void SetBaoCaoListener(EventHandler handler) => btnBaoCao.Click += handler;
  }
}
