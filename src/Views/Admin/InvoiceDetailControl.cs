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
  public partial class InvoiceDetailControl : UserControl
  {
    public InvoiceDetailControl()
    {
      InitializeComponent();
    }
    public void SetTaiLaiListener(EventHandler handler) => btnTaiLai.Click += handler;
    public void SetXuatExcelListener(EventHandler handler) => btnXuatExcel.Click += handler;
    public void SetXoaCTHDBListener(EventHandler handler) => btnXoaCTHDB.Click += handler;
    public void SetTinKiemListener(EventHandler handler) => btnTimKiem.Click += handler;
    public void SetInvoiceDetailCellClickListener(DataGridViewCellEventHandler handler) => dgvChiTietHDBan.CellClick += handler;
    public void SetSaleInvoiceCellClickListener(DataGridViewCellEventHandler handler) => dgvHDBan.CellClick += handler;
    public void LoadDataToGridView(DataSet ds)
    {

      //Lấy ra 2 cột trong DataSet làm khóa liên kết
      DataColumn parentColumn = ds.Tables["tblHoaDonBan"].Columns["SoHDB"];
      DataColumn childColumn = ds.Tables["tblChiTietHoaDonBan"].Columns["SoHDB"];
      //Tạo một mối quan hệ (DataRelation) giữa bảng cha và bảng con
      DataRelation relation = new DataRelation("HoaDon_ChiTiet", parentColumn, childColumn);
      //Thêm quan hệ vừa tạo vào DataSet → để DataSet biết rằng 2 bảng này có liên kết cha-con
      ds.Relations.Add(relation);
      BindingSource parentBindingSource = new BindingSource();
      BindingSource childBindingSource = new BindingSource();

      // Bind hóa đơn vào DataGridView
      parentBindingSource.DataSource = ds;
      parentBindingSource.DataMember = "tblHoaDonBan";

      // Gán BindingSource của bảng con dựa trên bảng cha và quan hệ
      childBindingSource.DataSource = parentBindingSource;
      childBindingSource.DataMember = "HoaDon_ChiTiet";
      // Gán vào DataGridView
      dgvHDBan.DataSource = parentBindingSource;
      dgvHDBan.Columns[4].Width = 200;
      dgvChiTietHDBan.DataSource = childBindingSource;


    }
    public DataGridView GetDataGridViewCTHDB() => dgvChiTietHDBan;
    public DataGridView GetDataGridViewHDB() => dgvHDBan;
    public void SetFormDataCTHDB(string sohdb, string masp, decimal dongia, decimal thanhtien, decimal giamgia, int soluong)
    {
      txtMaHoaDonBan.Text = sohdb;
      txtMaSanPham.Text = masp;
      nudDonGia.Value = dongia;
      nudGiamGia.Value = giamgia;
      nudSoLuong.Value = soluong;
      nudThanhTien.Value = thanhtien;
    }
    public void SetFormDataHDB(string sohdb, string manv, string makh, DateTime ngayban, decimal tongtien)
    {
      txtMaHoaDonBan.Text = sohdb;
      txtMaNhanVien.Text = manv;
      txtMaKhachHang.Text = makh;
      nudTongTien.Value = tongtien;
      dateNgayBan.Value = ngayban;
    }
    public void ResetForm()
    {
      txtMaHoaDonBan.Text = "";
      txtMaSanPham.Text = "";
      nudDonGia.Value = 1;
      nudGiamGia.Value = 1;
      nudSoLuong.Value = 1;
      nudThanhTien.Value = 1;
      txtMaKhachHang.Text = "";
      txtMaNhanVien.Text = "";
      dateNgayBan.Value = DateTime.Now;
      nudTongTien.Value = 1;
    }
    public string GetSoHDB() => txtMaHoaDonBan.Text.Trim();
    public string GetMaSP() => txtMaSanPham.Text.Trim();
    public string GetTimKiem() => txtTimKiem.Text.Trim().Replace("'", "''"); // Thay thế dấu nháy để tránh lỗi;
  }
}
