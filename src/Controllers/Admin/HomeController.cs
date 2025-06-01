using BTL_C_.src.Utils;
using BTL_C_.src.Views.Admin;
using System;

namespace BTL_C_.src.Controllers.Admin
{
  internal class HomeController
  {
    private Home viewHome;
    public HomeController(Home viewHome)
    {
      this.viewHome = viewHome;
      setupEventListeners();
      DashBoardControl viewDashBoardControl = new DashBoardControl();
      viewHome.loadControl(viewDashBoardControl);
      new DashBoardController(viewDashBoardControl, this);

    }
    public HomeController()
    {

    }
    private void setupEventListeners()
    {
      viewHome.getSidebar().SetTaiKhoanListener(initViewWithControllerAccount);
      viewHome.getSidebar().SetSanPhamListener(initViewWithControllerProduct);
      viewHome.getSidebar().SetNhaCungCapListener(initViewWithControllerSupplier);
      viewHome.getSidebar().SetTrangChuListener(initViewWithControllerDashBoard);
      viewHome.getSidebar().SetNhanVienListener(initViewWithControllerEmployee);
      viewHome.getSidebar().SetKhachHangListener(initViewWithControllerCustomer);
      viewHome.getSidebar().SetDoanhThuListener(initViewWithControllerRevenue);
      viewHome.getSidebar().SetBaoCaoListener(initViewWithControllerReport);
      viewHome.getSidebar().SetTaoListener(initViewWithControllerCreate);
      viewHome.getSidebar().SetDangXuatListener(logout);

    }
    private void initViewWithControllerAccount(object sender, EventArgs e)
    {
      AccountControl accountControl = new AccountControl();
      AccountController accountController = new AccountController(accountControl);
      viewHome.loadControl(accountControl);
    }
    private void initViewWithControllerProduct(object sender, EventArgs e)
    {
      ProductControl productControl = new ProductControl();
      ProductController productController = new ProductController(productControl);
      viewHome.loadControl(productControl);
    }
    private void initViewWithControllerSupplier(object sender, EventArgs e)
    {
      SupplierControl supplierControl = new SupplierControl();
      SupplierController supplierController = new SupplierController(supplierControl);
      viewHome.loadControl(supplierControl);
    }
    private void initViewWithControllerDashBoard(object sender, EventArgs e)
    {
      DashBoardControl dashBoardControl = new DashBoardControl();
      new DashBoardController(dashBoardControl, this);
      viewHome.loadControl(dashBoardControl);

    }
    private void initViewWithControllerEmployee(object sender, EventArgs e)
    {
      EmployeeControl employeeControl = new EmployeeControl();
      new EmployeeController(employeeControl);
      viewHome.loadControl(employeeControl);
    }
    private void initViewWithControllerCustomer(object sender, EventArgs e)
    {
      CustomerControl customerControl = new CustomerControl();
      new CustomerController(customerControl);
      viewHome.loadControl(customerControl);
    }
    private void initViewWithControllerRevenue(object sender, EventArgs e)
    {
      RevenueControl revenueControl = new RevenueControl();
      new RevenueController(revenueControl);
      viewHome.loadControl(revenueControl);
    }
    private void initViewWithControllerReport(object sender, EventArgs e)
    {
      ReportControl reportControl = new ReportControl();
      new ReportController(reportControl);
      viewHome.loadControl(reportControl);

    }
    public void initViewWithControllerBestSellingProduct(object sender, EventArgs e)
    {
      BestSellingProductControl bestSellingProductControl = new BestSellingProductControl();
      new BestSellingProductController(bestSellingProductControl);
      viewHome.loadControl(bestSellingProductControl);
    }
    public void initViewWithControllerInvoiceDetail(object sender, EventArgs e)
    {
      InvoiceDetailControl invoiceDetailControl = new InvoiceDetailControl();
      new InvoiceDetailController(invoiceDetailControl);
      viewHome.loadControl(invoiceDetailControl);
    }
    public void initViewWithControllerCreate(object sender, EventArgs e)
    {
      CreateControl createControl = new CreateControl();
      CreateController createController = new CreateController(createControl);
      viewHome.loadControl(createControl);
    }
    private void logout(object sender, EventArgs e)
    {
      if (!MessageUtil.Confirm("Bạn có muốn đăng xuất?"))
        return;
      AppController.startFrmLogin(viewHome.getForm());
    }
  }
}
