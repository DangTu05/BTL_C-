using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Client
{
  public partial class FrmInventoryAuditReport : Form
  {
    public FrmInventoryAuditReport()
    {
      InitializeComponent(); // Khởi tạo các thành phần UI đã được thiết kế.
      InitializeControls();  // Khởi tạo các giá trị ban đầu cho các điều khiển.
      ConfigureDataGridView(); // Cấu hình DataGridView.
    }

    /// <summary>
    /// Khởi tạo các giá trị ban đầu cho các điều khiển trên form.
    /// </summary>
    private void InitializeControls()
    {
      // Đặt giá trị mặc định cho DateTimePicker là đầu và cuối tháng hiện tại.
      dtpNgayBatDauKiemDuyet.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
      dtpNgayKetThucKiemDuyet.Value = DateTime.Now.Date; // Ngày hiện tại
    }

    /// <summary>
    /// Cấu hình hiển thị của DataGridView.
    /// </summary>
    private void ConfigureDataGridView()
    {
      dgvInventory.AutoGenerateColumns = false; // Tắt tự động tạo cột để kiểm soát cột hiển thị.

      // Xóa tất cả các cột hiện có (nếu có) để tránh trùng lặp khi chạy lại.
      dgvInventory.Columns.Clear();

      // Thêm các cột vào DataGridView.
      // DataPropertyName phải khớp với tên thuộc tính trong lớp InventoryItem.
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã Quần Áo", DataPropertyName = "MaQuanAo", Name = "colMaQuanAo" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Thể Loại", DataPropertyName = "TenTheLoai", Name = "colTheLoai" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Màu", DataPropertyName = "TenMau", Name = "colMau" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "NSX", DataPropertyName = "TenNSX", Name = "colNSX" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Đối Tượng", DataPropertyName = "TenDoiTuong", Name = "colDoiTuong" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mùa", DataPropertyName = "TenMua", Name = "colMua" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Cỡ", DataPropertyName = "TenCo", Name = "colCo" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Chất Liệu", DataPropertyName = "TenChatLieu", Name = "colChatLieu" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "SL Tồn Kho", DataPropertyName = "SlTonKho", Name = "colSlTonKho" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Đơn Giá Bán", DataPropertyName = "DonGiaBan", Name = "colDonGiaBan" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Trạng Thái", DataPropertyName = "TrangThai", Name = "colTrangThai" });
      dgvInventory.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày Nhập Cuối Cùng", DataPropertyName = "NgayNhapCuoiCung", Name = "colNgayNhapCuoiCung" });


      // Tùy chỉnh độ rộng cột (tùy chọn)
      dgvInventory.Columns["colMaQuanAo"].Width = 100;
      dgvInventory.Columns["colTheLoai"].Width = 100;
      dgvInventory.Columns["colMau"].Width = 80;
      dgvInventory.Columns["colNSX"].Width = 100;
      dgvInventory.Columns["colDoiTuong"].Width = 100;
      dgvInventory.Columns["colMua"].Width = 80;
      dgvInventory.Columns["colCo"].Width = 50;
      dgvInventory.Columns["colChatLieu"].Width = 100;
      dgvInventory.Columns["colSlTonKho"].Width = 80;
      dgvInventory.Columns["colDonGiaBan"].Width = 100;
      dgvInventory.Columns["colTrangThai"].Width = 80;
      dgvInventory.Columns["colNgayNhapCuoiCung"].Width = 120;


      // Định dạng cột số lượng và đơn giá
      dgvInventory.Columns["colSlTonKho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgvInventory.Columns["colDonGiaBan"].DefaultCellStyle.Format = "N0"; // Định dạng số không có số thập phân
      dgvInventory.Columns["colDonGiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

      // Cho phép người dùng thay đổi kích thước cột
      foreach (DataGridViewColumn col in dgvInventory.Columns)
      {
        col.Resizable = DataGridViewTriState.True;
      }
    }
    public void SetTimKiemListener(EventHandler handler) => btnTimKiem.Click += handler;
    public void SetXuatExcelListener(EventHandler handler) => btnXuatExcel.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public DataGridView GetDataGridViewInventory() => dgvInventory;
    public void LoadDataToGridView(DataView dv)
    {
      dgvInventory.DataSource = dv;
    }
    public DateTime GetStartDate() => dtpNgayBatDauKiemDuyet.Value;
    public DateTime GetEndDate() => dtpNgayKetThucKiemDuyet.Value;

  }
}
