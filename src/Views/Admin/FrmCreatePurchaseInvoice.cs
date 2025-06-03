using BTL_C_.src.Utils;
using DocumentFormat.OpenXml.Wordprocessing;
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
  public partial class FrmCreatePurchaseInvoice : Form
  {
    public FrmCreatePurchaseInvoice()
    {
      InitializeComponent();
    }
    public void SetThemListener(EventHandler handler) => btnThem.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetCellEndEditListener(DataGridViewCellEventHandler handler) => dgvCTHDN.CellEndEdit += handler;
    public void SetUserAddedRowListener(DataGridViewRowEventHandler handler) => dgvCTHDN.UserAddedRow += handler;
    public ComboBox GetCmbNCC() => cmbNhaCungCap;
    public DataGridView GetDgvCTHDN() => dgvCTHDN;
    public string GetMaNCC() => cmbNhaCungCap.SelectedValue.ToString();
    public string GetGhiChu() => txtGhiChu.Text.Trim();
    public decimal GetTongTien() => nudTongTien.Value;
    public DateTime GetNgayNhap() => dtpNgayNhap.Value;
    public Form GetForm() => this;
    public void SetupDataGridView()
    {
      //ClearTaoHDFields(); // Sinh mã hóa đơn mới và xóa các trường
      dgvCTHDN.Columns.Add("colMaSP", "Mã SP");         // cột 0
      dgvCTHDN.Columns.Add("colTenSP", "Tên sản phẩm");    // cột 1
      dgvCTHDN.Columns.Add("colSoLuong", "Số lượng");   // cột 2
      dgvCTHDN.Columns.Add("colDonGia", "Đơn giá");     // cột 3
      dgvCTHDN.Columns.Add("colGiamGia", "Giảm giá");   // cột 4
      dgvCTHDN.Columns.Add("colThanhTien", "Thành tiền"); // cột 5

      dgvCTHDN.AutoGenerateColumns = false;

    }
    private void dgvChiTietHoaDonban_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      // Set giá trị mặc định cho các cột nếu cần (ví dụ: GiamGia = 0)
      e.Row.Cells["colGiamGia"].Value = 0m;
      e.Row.Cells["colSoLuong"].Value = 0;
      e.Row.Cells["colDonGia"].Value = 0m;
      e.Row.Cells["colThanhTien"].Value = 0m;
    }
    //// Tính toán thành tiền cho một dòng cụ thể trong DataGridView
    public void CalculateThanhTienForRow(DataGridViewRow row)
    {
      decimal donGia = 0m;
      int soLuong = 0;
      decimal giamGiaPhanTram = 0m;

      if (row.Cells["colDonGia"].Value != null && decimal.TryParse(row.Cells["colDonGia"].Value.ToString(), out donGia) &&
          row.Cells["colSoLuong"].Value != null && int.TryParse(row.Cells["colSoLuong"].Value.ToString(), out soLuong) &&
          row.Cells["colGiamGia"].Value != null && decimal.TryParse(row.Cells["colGiamGia"].Value.ToString(), out giamGiaPhanTram))
      {
        if (soLuong < 0) soLuong = 0; // Đảm bảo số lượng không âm
        if (giamGiaPhanTram < 0 || giamGiaPhanTram > 100) giamGiaPhanTram = 0; // Đảm bảo giảm giá hợp lệ

        decimal giamGiaDecimal = giamGiaPhanTram / 100;
        decimal thanhTien = soLuong * donGia * (1 - giamGiaDecimal);
        row.Cells["colThanhTien"].Value = thanhTien;
      }
      else
      {
        row.Cells["colThanhTien"].Value = 0m;
      }
    }

    // Cập nhật tổng tiền của hóa đơn
    public void UpdateOverallTongTien()
    {
      decimal total = 0;
      foreach (DataGridViewRow row in dgvCTHDN.Rows)
      {
        if (!row.IsNewRow && row.Cells["colThanhTien"].Value != null)
        {
          total += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
        }
      }
      nudTongTien.Value = total;
    }

    // Nút Thêm SP trong chi tiết hóa đơn (nay chỉ thêm dòng trống)
    public void ThemDong(object sender, EventArgs e)
    {
      dgvCTHDN.Rows.Add(); // Thêm một dòng trống mới
      dgvCTHDN.CurrentCell = dgvCTHDN.Rows[dgvCTHDN.Rows.Count - 2].Cells["colMaSP"];
      dgvCTHDN.BeginEdit(true); // Bắt đầu chỉnh sửa ô Mã SP
    }
    // Nút Xóa SP trong chi tiết hóa đơn
    public void XoaSP_CTHD()
    {
      if (dgvCTHDN.SelectedRows.Count == 0)
      {
        MessageUtil.ShowWarning("Vui lòng chọn một dòng để xóa!");
        return;
      }

      DataGridViewRow selectedRow = dgvCTHDN.SelectedRows[0];
      if (selectedRow.IsNewRow) return; // Không xóa dòng thêm mới trống

      if (MessageUtil.Confirm("Bạn có chắc chắn muốn xóa dòng sản phẩm này khỏi hóa đơn?"))
      {
        dgvCTHDN.Rows.Remove(selectedRow);
        UpdateOverallTongTien(); // Cập nhật lại tổng tiền
        MessageUtil.ShowInfo("Đã xóa sản phẩm khỏi chi tiết hóa đơn!");
      }
    }
    public void ClearTaoHDFields()
    {
      dgvCTHDN.DataSource = null; // Clear DataGridView
      dgvCTHDN.Rows.Clear(); // Đảm bảo DataGridView trống rỗng
      nudTongTien.Value = 0;
    }
  }
}
