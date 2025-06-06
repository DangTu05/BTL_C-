﻿using System;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class DashBoardControl : UserControl
  {
    public DashBoardControl()
    {
      InitializeComponent();
    }
    public void SetSanPhamNoiBatListener(EventHandler handler) => pnlSanPhamNoiBat.Click += handler;
    public void SetHoaDonBanListener(EventHandler handler) => pnlHoaDonBan.Click += handler;
    public void SetHoaDonNhapListener(EventHandler handler) => pnlHoaDonNhap.Click += handler;
    public void loadFormData(int slsp, int slncc, int slkh, int slnv, int slcl, int sll, int slcv, int slhdn, int slhdb, string tenkhnb, int thang, decimal tongdoanhthu)
    {
      lblSLSP.Text = slsp.ToString();
      lblSLNCC.Text = slncc.ToString();
      lblSLKH.Text = slkh.ToString();
      lblSLNV.Text = slnv.ToString();
      lblSLCL.Text = slcl.ToString();
      lblSLL.Text = sll.ToString();
      lblSoTien.Text = slcv.ToString();
      lblSLHDN.Text = slhdn.ToString();
      lblSLHDB.Text = slhdb.ToString();
      lblKhachHangNoiBat.Text = tenkhnb.ToString();
      lblDoanhThuThang.Text = $"Doanh thu tháng {thang}";
      lblSoTien.Text = $"{tongdoanhthu.ToString()}VNĐ";
    }

  }
}
