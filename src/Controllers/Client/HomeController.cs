using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
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
    }
    // --- Setup Tab Initial States ---
    private void SetupThongTinNVTab()
    {
      frmHome.LoadThongTinNhanVienHienTai(currentNv); // Thay "NV001" bằng mã NV bạn muốn quản lý trên tab này                                        // Hook up event handler for btnCapNhapNV and btnXoaNV if not already in designer
                                                      // this.btnCapNhapNV.Click += new System.EventHandler(this.btnCapNhapNV_Click);
                                                      // this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
    }
    // --- QuanlyHD Tab Functions ---
    private void LoadDataProductToGridView()
    {
      DataTable allProduct = productDao.getAllRecord();

      // Tạo DataView từ DataTable và lọc theo vai trò
      DataView dv = new DataView(allProduct);
      frmHome.LoadDataProductToGridView(dv);
    }
    private void LoadDataCustomerToGridView()
    {
      DataTable allCustomer = customerDao.getAllRecord();
      DataView dv = new DataView(allCustomer);
      frmHome.LoadDataCustomerToGridView(dv);
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
        frmHome.LoadDataHDBToGridView(dv);
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
  }
}
