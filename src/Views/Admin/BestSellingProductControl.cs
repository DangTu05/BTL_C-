using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class BestSellingProductControl : UserControl
  {
    public BestSellingProductControl()
    {
      InitializeComponent();
      dateThoigianbatdau.Value = DateTime.Now.AddDays(-30);
      dateThoigianketthuc.Value = DateTime.Now;
    }
    public void SetTimKiemListener(EventHandler handler) => btnTim.Click += handler;
    public DateTime GetNgayBatDau() => dateThoigianbatdau.Value;
    public DateTime GetNgayKetThuc() => dateThoigianketthuc.Value;
    public DataGridView GetDataGridView() => dgvSanpham;
    public void SetTongSoLuong(string tong) => lblTongSoLuong.Text = tong;
    public void SetTongTien(string tongtien) => lblTongTien.Text = tongtien;
  }
}
