using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebQLCHQuanAo;

namespace BTL_C_.src.Controllers.Admin
{
  internal class PurchaseInvoiceController
  {
    private PurchaseInvoiceControl viewPurchaseInvoiceControl;
    private FrmCreatePurchaseInvoice frmCreatePurchaseInvoice;
    private PurchaseInvoiceDAO purchaseInvoiceDao;
    private ProductDAO productDao;
    public PurchaseInvoiceController(PurchaseInvoiceControl viewPurchaseInvoiceControl)
    {
      this.viewPurchaseInvoiceControl = viewPurchaseInvoiceControl;
      purchaseInvoiceDao = new PurchaseInvoiceDAO();
      LoadDataPurchaseInvoiceDetailToGridView();
      FillDataToComboBox();
    }
    public PurchaseInvoiceController(FrmCreatePurchaseInvoice frmCreatePurchaseInvoice)
    {
      this.frmCreatePurchaseInvoice = frmCreatePurchaseInvoice;
      purchaseInvoiceDao = new PurchaseInvoiceDAO();
      productDao = new ProductDAO();
      FillSupplierToCombo(frmCreatePurchaseInvoice.GetCmbNCC());
      frmCreatePurchaseInvoice.SetupDataGridView();
      SetupEventForFrmCreateListener();
    }
    private void SetupEventForFrmCreateListener()
    {
      frmCreatePurchaseInvoice.SetTaoListener(ThemHD);
      frmCreatePurchaseInvoice.SetThemListener(frmCreatePurchaseInvoice.ThemDong);
      frmCreatePurchaseInvoice.SetXoaListener(XoaHDTao);
      frmCreatePurchaseInvoice.SetCellEndEditListener(dgvChiTietHoaDonban_CellEndEdit);
      frmCreatePurchaseInvoice.SetUserAddedRowListener(dgvChiTietHoaDonban_UserAddedRow);
    }
    private void FillDataToComboBox()
    {
      try
      {
        FillSupplierToCombo(viewPurchaseInvoiceControl.GetCmbNhaCungCap());
        ProductDAO.fillProductCombo(viewPurchaseInvoiceControl.GetCmbSanPham());
        SupplierDAO.fillSupplierCombo(viewPurchaseInvoiceControl.GetCmbNhaCungCap());

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void FillSupplierToCombo(ComboBox cmb)
    {

      try
      {
        SupplierDAO.fillSupplierCombo(cmb);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void LoadDataPurchaseInvoiceDetailToGridView()
    {
      try
      {
        DataSet ds = purchaseInvoiceDao.getData();
        DataTable dtChiTietHoaDonNhap = ds.Tables["tblChiTietHoaDonNhap"];
        viewPurchaseInvoiceControl.LoadDataPurchaseInvoiceDetailToGridView(ds);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi !!!");
      }
    }
    private void ThemHD(object sender, EventArgs e)
    {
      try
      {

        // Initialize the list if not already done  
        List<PurchaseInvoiceDetailModel> currentChiTietHoaDonList = new List<PurchaseInvoiceDetailModel>();
        string sohdn = GenerateIdUtil.GenerateId("PI");
        // Cập nhật currentChiTietHoaDonList từ DataGridView trước khi lưu  
        foreach (DataGridViewRow row in frmCreatePurchaseInvoice.GetDgvCTHDN().Rows)
        {
          if (!row.IsNewRow) // Bỏ qua dòng trống cuối cùng  
          {
            string maSP = row.Cells["colMaSP"].Value?.ToString();
            int soLuong = 0;
            decimal donGia = 0m;
            decimal giamGia = 0m;
            decimal thanhTien = 0m;

            if (string.IsNullOrWhiteSpace(maSP) ||
                !int.TryParse(row.Cells["colSoLuong"].Value?.ToString(), out soLuong) ||
                !decimal.TryParse(row.Cells["colDonGia"].Value?.ToString(), out donGia) ||
                !decimal.TryParse(row.Cells["colGiamGia"].Value?.ToString(), out giamGia) ||
                !decimal.TryParse(row.Cells["colThanhTien"].Value?.ToString(), out thanhTien))
            {
              MessageUtil.ShowWarning("Dữ liệu chi tiết hóa đơn không hợp lệ. Vui lòng kiểm tra lại các dòng!");
              return;
            }
            currentChiTietHoaDonList.Add(new PurchaseInvoiceDetailModel
            {
              sohdn = sohdn, // Fix: Provide the required 'mahdb' parameter  
              maquanao = maSP,
              soluong = soLuong,
              dongia = donGia,
              giamgia = giamGia / 100, // Lưu dưới dạng thập phân  
              thanhtien = thanhTien
            });
          }
        }

        if (currentChiTietHoaDonList.Count == 0)
        {
          MessageUtil.ShowWarning("Hóa đơn phải có ít nhất một sản phẩm!");
          return;
        }

        PurchaseInvoiceModel newHoaDon = new PurchaseInvoiceModel
        {
          soHDN = sohdn,
          mancc = frmCreatePurchaseInvoice.GetMaNCC(),
          tongtien = frmCreatePurchaseInvoice.GetTongTien(),
          ngaynhap = frmCreatePurchaseInvoice.GetNgayNhap(),
          ghichu = string.IsNullOrWhiteSpace(frmCreatePurchaseInvoice.GetGhiChu()) ? string.Empty : frmCreatePurchaseInvoice.GetGhiChu()
        };

        if (purchaseInvoiceDao.AddHoaDonNhap(newHoaDon, currentChiTietHoaDonList))
        {
          MessageUtil.ShowInfo("Thêm hóa đơn thành công!");
          frmCreatePurchaseInvoice.ClearTaoHDFields();
        }
        else
        {
          MessageUtil.ShowError("Thêm hóa đơn thất bại!!!");
        }
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo hóa đơn!!!");
      }
    }
    //// Xử lý khi người dùng kết thúc chỉnh sửa một ô trong DataGridView
    private void dgvChiTietHoaDonban_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0 || e.RowIndex >= frmCreatePurchaseInvoice.GetDgvCTHDN().Rows.Count - 1) return; // Tránh hàng thêm mới cuối cùng  

      DataGridViewRow row = frmCreatePurchaseInvoice.GetDgvCTHDN().Rows[e.RowIndex];
      string colName = frmCreatePurchaseInvoice.GetDgvCTHDN().Columns[e.ColumnIndex].Name;

      // Xử lý khi MaSP được nhập  
      if (colName == "colMaSP")
      {
        string maSP = row.Cells["colMaSP"].Value?.ToString();
        if (!string.IsNullOrWhiteSpace(maSP))
        {
          ProductModel sp = productDao.findRecordByField("maquanao", maSP);
          if (sp != null)
          {
            row.Cells["colTenSP"].Value = "Tên: " + sp.tenquanao; // Placeholder or actual product name if available  
            row.Cells["colDonGia"].Value = sp.dongiaban;
            // Mặc định giảm giá 0% nếu chưa có  
            if (row.Cells["colGiamGia"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colGiamGia"].Value.ToString()))
            {
              row.Cells["colGiamGia"].Value = 0m;
            }
          }
          else
          {
            MessageBox.Show("Không tìm thấy sản phẩm với mã này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            row.Cells["colMaSP"].Value = null; // Clear invalid input  
            row.Cells["colTenSP"].Value = null;
            row.Cells["colDonGia"].Value = 0m;
            row.Cells["colSoLuong"].Value = 0;
            row.Cells["colGiamGia"].Value = 0m;
          }
        }
      }
      // Tính toán Thành tiền khi Số lượng, Đơn giá, Giảm giá thay đổi
      if (colName == "colSoLuong" || colName == "colDonGia" || colName == "colGiamGia" || colName == "colMaSP")
      {
        frmCreatePurchaseInvoice.CalculateThanhTienForRow(row);
        frmCreatePurchaseInvoice.UpdateOverallTongTien();
      }
    }
    private void dgvChiTietHoaDonban_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      // Set giá trị mặc định cho các cột nếu cần (ví dụ: GiamGia = 0)
      e.Row.Cells["colGiamGia"].Value = 0m;
      e.Row.Cells["colSoLuong"].Value = 0;
      e.Row.Cells["colDonGia"].Value = 0m;
      e.Row.Cells["colThanhTien"].Value = 0m;
    }
    private void XoaHDTao(object sender, EventArgs e)
    {
      frmCreatePurchaseInvoice.XoaSP_CTHD();
    }

  }
}
