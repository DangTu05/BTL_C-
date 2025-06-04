using BTL_C_.src.DAO;
using BTL_C_.src.Entry;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using DocumentFormat.OpenXml.Wordprocessing;
using SixLabors.Fonts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebQLCHQuanAo;


namespace BTL_C_.src.Controllers.Client
{
  internal class HomeController
  {
    private FrmHome frmHome;
    private EmployeeDAO employeeDAO;
    private EmployeeModel currentNv;
    private ProductDAO productDao;
    private CustomerDAO customerDao;
    private InvoiceDetailDAO invoiceDetailDao;
    private SalesInvoiceDAO salesInvoiceDao;
    public HomeController(FrmHome frmHome)
    {
      this.frmHome = frmHome;
      employeeDAO = new EmployeeDAO();
      productDao = new ProductDAO();
      customerDao = new CustomerDAO();
      currentNv = Session.GetEmployee();
      invoiceDetailDao = new InvoiceDetailDAO();
      salesInvoiceDao = new SalesInvoiceDAO();
      SetupThongTinNVTab();
      LoadDataProductToGridView();
      LoadDataCustomerToGridView();
      LoadDataInvoiceDetailToGridView();
      LoadDataSalesInvoiceToGridView();
      frmHome.SetupTaoHDTab();
      SetupEventListener();
    }
    private void SetupEventListener()
    {
      frmHome.SetCapNhatNVListener(CapNhatNV);
      frmHome.SetDangXuatListener(Logout);
      frmHome.SetTimKiemSPListener(TimKiemSP);
      frmHome.SetLamMoiHDBListener(LamMoiHDB);
      frmHome.SetThemKHListener(ThemKH);
      frmHome.SetLamMoiFormKH(ResetFormKH);
    }
    // --- Setup Tab Initial States ---
    private void SetupThongTinNVTab()
    {
      frmHome.LoadThongTinNhanVienHienTai(currentNv); // Thay "NV001" bằng mã NV bạn muốn quản lý trên tab này                                        // Hook up event handler for btnCapNhapNV and btnXoaNV if not already in designer
                                                      // this.btnCapNhapNV.Click += new System.EventHandler(this.btnCapNhapNV_Click);
                                                      // this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
      frmHome.SetCellEndEditListener(dgvChiTietHoaDonban_CellEndEdit);
      frmHome.SetUserAddedRowListener(dgvChiTietHoaDonban_UserAddedRow);
      frmHome.SetThemSPListener(frmHome.ThemDong);
      frmHome.SetTaoHDListener(ThemHD);
      frmHome.SetXoaHoaDonTaoListener(XoaHDTao);
      frmHome.SetTimKiemHDListener(TimkiemHD);
      frmHome.SetTonKhoListener(RedirectTonkho);
      frmHome.SetTimKiemKHListener(TimKiemKhachHang);
    }
    // --- QuanlyHD Tab Functions ---
    private void LoadDataProductToGridView()
    {

      try
      {
        DataTable allProduct = productDao.getAllRecord();

        // Tạo DataView từ DataTable và lọc theo vai trò
        DataView dv = new DataView(allProduct);
        frmHome.LoadDataProductToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void LoadDataCustomerToGridView()
    {

      try
      {
        DataTable allCustomer = customerDao.getAllRecord();
        DataView dv = new DataView(allCustomer);
        frmHome.LoadDataCustomerToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void LoadDataInvoiceDetailToGridView()
    {
      try
      {
        DataSet ds = invoiceDetailDao.getData();
        DataTable dtChiTietHoaDonBan = ds.Tables["tblChiTietHoaDonBan"];
        frmHome.LoadDataInvoiceDetailToGridView(ds);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi !!!");
      }
    }
    private void LoadDataSalesInvoiceToGridView()
    {
      try
      {
        DataTable allHdb = salesInvoiceDao.getAllRecord();
        DataView dv = new DataView(allHdb);

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void ResetFormTaoHoaDon()
    {
      //frmHome.
    }



    private void ThemHD(object sender, EventArgs e)
    {
      try
      {
        CustomerModel kh = null;
        if (!string.IsNullOrWhiteSpace(frmHome.GetMaKH()))
        {
          kh = customerDao.findRecordByField("makh", frmHome.GetMaKH());
          if (kh == null)
          {
            MessageUtil.ShowInfo("Không có khách hàng có mã như vậy!");
            return;
          }
        }
        // Initialize the list if not already done  
        List<InvoiceDetailModel> currentChiTietHoaDonList = new List<InvoiceDetailModel>();
        string sohdb = GenerateIdUtil.GenerateId("RE");
        // Cập nhật currentChiTietHoaDonList từ DataGridView trước khi lưu  
        foreach (DataGridViewRow row in frmHome.GetDgvTaoHoaDon().Rows)
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
            //if (sol)
            currentChiTietHoaDonList.Add(new InvoiceDetailModel
            {
              mahdb = sohdb, // Fix: Provide the required 'mahdb' parameter  
              masp = maSP,
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

        SalesInvoiceModel newHoaDon = new SalesInvoiceModel
        {
          soHDB = sohdb,
          manv = Session.GetEmployee().MaNhanVien,
          makh = frmHome.GetMaKH(),
          ngayban = DateTime.Now,
          tongtien = !string.IsNullOrWhiteSpace(frmHome.GetTongTien()) ? (float)decimal.Parse(frmHome.GetTongTien()) : 1f,
        };
        if (salesInvoiceDao.AddHoaDonBan(newHoaDon, currentChiTietHoaDonList))
        {
          MessageUtil.ShowInfo("Thêm hóa đơn thành công!");
          if (kh != null)
          {
            kh.diem = kh.diem + 1;
            customerDao.UpdatePoint(kh);
          }

          frmHome.ClearTaoHDFields();
          LoadDataInvoiceDetailToGridView(); // Cập nhật danh sách hóa đơn ở tab Quản lý HD
          LoadDataProductToGridView();
          LoadDataCustomerToGridView();
        }
        else
        {
          MessageUtil.ShowError("Thêm hóa đơn thất bại!!!");
        }
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, ex.Message);
      }
    }
    //// Xử lý khi người dùng kết thúc chỉnh sửa một ô trong DataGridView
    private void dgvChiTietHoaDonban_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      int sltonkho = 0;
      if (e.RowIndex < 0 || e.RowIndex >= frmHome.GetDgvTaoHoaDon().Rows.Count - 1) return; // Tránh hàng thêm mới cuối cùng  

      DataGridViewRow row = frmHome.GetDgvTaoHoaDon().Rows[e.RowIndex];
      string colName = frmHome.GetDgvTaoHoaDon().Columns[e.ColumnIndex].Name;

      // Xử lý khi MaSP được nhập  
      if (colName == "colMaSP")
      {
        string maSP = row.Cells["colMaSP"].Value?.ToString();
        if (!string.IsNullOrWhiteSpace(maSP))
        {
          ProductModel sp = productDao.findRecordByField("maquanao", maSP);
          if (sp != null)
          {
            if (sp.trangthai != null && sp.trangthai.Equals("ngưng bán"))
            {
              MessageUtil.ShowWarning("Sản phẩm này tạm thời đã ngưng bán!");
              return;
            }
            if (sp.sltonkho == 0)
            {
              MessageUtil.ShowWarning("Sản phẩm này đã hết hàng!");
              return;
            }
            sltonkho = sp.sltonkho;
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
            MessageUtil.ShowWarning("Không tìm thấy sản phẩm với mã như này!");
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
        object value = row.Cells["colSoLuong"].Value;
        int soluong = (value != null && value != DBNull.Value) ? Convert.ToInt32(value) : 0;

        // Tìm lại sản phẩm để kiểm tra tồn kho
        string maSP = row.Cells["colMaSP"].Value?.ToString();
        if (!string.IsNullOrWhiteSpace(maSP))
        {
          ProductModel sp = productDao.findRecordByField("maquanao", maSP);
          if (sp != null)
          {
            sltonkho = sp.sltonkho;

            if (soluong > sltonkho)
            {
              MessageUtil.ShowWarning("Số lượng không đủ!");
              row.Cells["colSoLuong"].Value = 0;
              return;
            }
          }
        }
        frmHome.CalculateThanhTienForRow(row);
        frmHome.UpdateOverallTongTien();
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
      frmHome.XoaSP_CTHD();
    }
    private void CapNhatNV(object sender, EventArgs e)
    {
      try
      {
        string tennv = frmHome.GetTenNhanVien();
        string sdt = frmHome.GetSdt();
        // Validation cơ bản
        if (!InputValidate.InputInfoNVValidate(tennv, sdt))
          return;


        EmployeeModel nv = new EmployeeModel
        {
          MaNhanVien = frmHome.GetMaNV(),
          TenNhanVien = frmHome.GetTenNhanVien(),
          NgaySinh = frmHome.GetNgaySinh(),
          GioiTinh = string.IsNullOrWhiteSpace(frmHome.GetGT()) ? null : frmHome.GetGT(),
          DiaChi = string.IsNullOrWhiteSpace(frmHome.GetDiaChi()) ? null : frmHome.GetDiaChi(),
          SoDienThoai = ConvertUtil.convertSdtToDB(frmHome.GetSdt()),
        };

        // Cập nhật
        if (employeeDAO.update(nv))
        {
          MessageUtil.ShowInfo("Cập nhật thành công!");
        }
        else
        {
          MessageUtil.ShowInfo("Cập nhật thất bại!!!");
        }

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật thông tin!!!");
      }
    }
    private void Logout(object sender, EventArgs e)
    {
      if (!MessageUtil.Confirm("Bạn có muốn đăng xuất?"))
        return;
      Session.Logout();
      AppController.startFrmLogin(frmHome.GetForm());
    }

    private void TimKiemSP(object sender, EventArgs e)
    {
      try
      {
        string tensp = frmHome.GetSearchSP();
        DataView dv = productDao.findRecordsByName("tenquanao", tensp);

        if (dv.Count == 0)
        {
          MessageUtil.ShowInfo("Không tìm thấy sản phẩm nào có tên như vậy!");
        }
        else
        {
          frmHome.LoadDataProductToGridView(dv);
        }
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm sản phẩm!!!");
      }
    }
    private void TimkiemHD(object sender, EventArgs e)
    {
      try
      {
        string ngayBan = frmHome.GetNgayTimKiemHoaDon().ToString("dd/MM/yyyy");
        DataView dv = salesInvoiceDao.findRecordsByName("ngayban", ngayBan);
        frmHome.GetDgvHoaDonBan().DataSource = dv;
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
    private void LamMoiHDB(object sender, EventArgs e)
    {
      frmHome.SetNgayTimKiemHoaDon(DateTime.Now);
      LoadDataInvoiceDetailToGridView();
    }
    private void ThemKH(object sender, EventArgs e)
    {
      string sdt = ConvertUtil.convertSdtToDB(frmHome.GetSDTKH());
      string tenkh = frmHome.GetTenKH();
      try
      {
        if (!InputValidate.InputKhachHangValidate(sdt, tenkh))
          return;

        CustomerModel kh = new CustomerModel
        {
          makh = GenerateIdUtil.GenerateId("CUS"), // Automatically generate ID  
          tenkh = tenkh,
          sdt = ConvertUtil.convertSdtToDB(sdt),
          diem = 1
        };

        if (customerDao.Insert(kh))
        {
          MessageUtil.ShowInfo("Đã thêm thành công!");
          LoadDataCustomerToGridView();
          frmHome.ClearQuanLyKHFields();
        }
        else
        {
          MessageUtil.ShowError("Thêm không thành công!!!");
        }
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi thêm!!!");
      }

    }
    private void RedirectTonkho(object sender, EventArgs e)
    {
      AppController.StartFrmInventoryAuditReport(frmHome.GetForm());
    }
    private void ResetFormKH(object sender, EventArgs e)
    {
      frmHome.ClearQuanLyKHFields();
      LoadDataCustomerToGridView();
    }
    private void TimKiemKhachHang(object sender, EventArgs e)
    {
      try
      {
        CustomerModel customer = customerDao.findRecordByField("sdt", frmHome.GetSDTSearch());
        if (customer == null)
        {
          MessageUtil.ShowInfo("Không có khách hàng nào có số điện thoại như vậy!");
          return;
        }
        DataView dv = ConvertToDataView.ObjectToDataView(customer);
        frmHome.LoadDataCustomerToGridView(dv);

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
  }
}