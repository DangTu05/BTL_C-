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
  public partial class PurchaseInvoiceControl : UserControl
  {
    public PurchaseInvoiceControl()
    {
      InitializeComponent();
    }
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetTimKiemListener(EventHandler handler) => btnTimKiem.Click += handler;
    public void SetLocListener(EventHandler handler) => btnLoc.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetXuatExcelHDNListener(EventHandler handler) => btnXuatExcelHDN.Click += handler;
    public void SetXuatExcelCTHDNListener(EventHandler handler) => btnXuatExcelCTHDN.Click += handler;
    public void SetHDNCellClickListener(DataGridViewCellEventHandler handler) => dgvHoaDonNhap.CellClick += handler;
    public void LoadDataPurchaseInvoiceDetailToGridView(DataSet ds)
    {
      //Lấy ra 2 cột trong DataSet làm khóa liên kết
      DataColumn parentColumn = ds.Tables["tblHoaDonNhap"].Columns["SoHDN"];
      DataColumn childColumn = ds.Tables["tblChiTietHoaDonNhap"].Columns["SoHDN"];
      //Tạo một mối quan hệ (DataRelation) giữa bảng cha và bảng con
      DataRelation relation = new DataRelation("HoaDon_ChiTiet", parentColumn, childColumn);
      //Thêm quan hệ vừa tạo vào DataSet → để DataSet biết rằng 2 bảng này có liên kết cha-con
      ds.Relations.Add(relation);
      BindingSource parentBindingSource = new BindingSource();
      BindingSource childBindingSource = new BindingSource();

      // Bind hóa đơn vào DataGridView
      parentBindingSource.DataSource = ds;
      parentBindingSource.DataMember = "tblHoaDonNhap";

      // Gán BindingSource của bảng con dựa trên bảng cha và quan hệ
      childBindingSource.DataSource = parentBindingSource;
      childBindingSource.DataMember = "HoaDon_ChiTiet";
      // Gán vào DataGridView
      dgvHoaDonNhap.DataSource = parentBindingSource;
      dgvHoaDonNhap.Columns[3].Width = 220;
      dgvChiTietHDN.DataSource = childBindingSource;
    }
    public ComboBox GetCmbLocNCC() => cmbLocNCC;
    public ComboBox GetCmbNhaCungCap() => cmbMaNCC;
    public string GetMaNCC() => cmbMaNCC.SelectedValue.ToString();
    public string GetMaNCCLoc() => cmbLocNCC?.SelectedValue?.ToString();

    public DateTime GetNgayNhap() => dtpNgayNhap.Value;
    public string GetMaHDN() => txtMaHDN.Text.Trim();
    public decimal GetDonGia() => (decimal)nudDonGiaNhap.Value;
    public decimal GetTongTien() => (decimal)nudTongTien.Value;
    public void SetTxtTongTien(decimal tongtien) => nudTongTien.Value = tongtien;
    public DataGridView GetDgvHDN() => dgvHoaDonNhap;
    public DataGridView GetDgvCTHDN() => dgvChiTietHDN;
    public void SetTxtThongKe(string thongke) => lblThongKe.Text = thongke;
    public DateTime GetNgayBatDau() => dtpLocTuNgay.Value;
    public DateTime GetNgayKetThuc() => dtpLocDenNgay.Value;
    public Form GetForm()
    {
      return this.FindForm();
    }
    public void SetFormHDN(string sohdn, DateTime ngaynhap, decimal tongtien, string mancc, string ghichu)
    {
      txtMaHDN.Text = sohdn;
      dtpNgayNhap.Value = ngaynhap;
      nudTongTien.Value = tongtien;
      cmbMaNCC.SelectedValue = mancc;
      txtGhiChu.Text = ghichu;
    }
    public void ResetFormHDN()
    {
      txtMaHDN.Text = "";
      dtpNgayNhap.Value = DateTime.Now;
      nudTongTien.Value = 1;
      cmbMaNCC.SelectedIndex = 0;
      txtGhiChu.Text = "";
    }
  }
}
