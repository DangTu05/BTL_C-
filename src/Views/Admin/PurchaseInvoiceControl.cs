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
    public void SetThemListener(EventHandler handler) => btnThem.Click += handler;
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
    public ComboBox GetCmbSanPham() => cmbSanPham;
    public string GetMaSanPham() => cmbSanPham.SelectedValue.ToString();
    public string GetMaNCC() => cmbMaNCC.SelectedValue.ToString();
    public DateTime GetNgayNhap() => dtpNgayNhap.Value;
    public int GetSoLuong() => (int)nudSoLuong.Value;
    public decimal GetDonGia() => (decimal)nudDonGiaNhap.Value;
    public decimal GetTongTien() => (decimal)nudTongTien.Value;
    public decimal GetGiamGia() => (decimal)nudGiamGia.Value;
    public void SetTxtTongTien(decimal tongtien) => nudTongTien.Value = tongtien;
  }
}
