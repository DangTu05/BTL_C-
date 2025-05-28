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
  public partial class RevenueControl : UserControl
  {
    public RevenueControl()
    {
      InitializeComponent();
    }
    public void SetTimListener(EventHandler handler) => btnTim.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTinhTongListener(EventHandler handler) => btnTinhTong.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetRevenueCellClickListener(DataGridViewCellEventHandler handler) => dgvDoanhthu.CellClick += handler;
    public DateTime GetDate() => dateDoanhThu.Value;
    public void LoadDataToGridView(DataView dv)
    {
      dgvDoanhthu.DataSource = dv;
      dgvDoanhthu.Columns[0].HeaderText = "Mã hóa đơn";
      dgvDoanhthu.Columns[1].HeaderText = "Mã nhân viên";
      dgvDoanhthu.Columns[2].HeaderText = "Mã khách hàng";
      dgvDoanhthu.Columns[3].HeaderText = "Tên khách hàng";
      dgvDoanhthu.Columns[4].HeaderText = "Ngày bán";
      dgvDoanhthu.Columns[5].HeaderText = "Tổng tiền";
      dgvDoanhthu.Columns[5].Width = 120;
      dgvDoanhthu.ReadOnly = true;
      dgvDoanhthu.AllowUserToAddRows = false;
    }
    public void SetTongDoanhThu(string tong)
    {
      lblTongDoanhThu.Text = tong;
    }
    public void SetFormData(string mahdb)
    {
      txtMaHoaDonBan.Text = mahdb;
    }
    public void ResetForm()
    {
      txtMaHoaDonBan.Text = "";
    }
    public DataGridView GetDataGridViewRevenue() => dgvDoanhthu;
    public string GetSoHDB() => txtMaHoaDonBan.Text.Trim();
  }
}
