using BTL_C_.src.Controllers;
using BTL_C_.src.Controllers.Admin;
using BTL_C_.src.Controllers.Client;
using BTL_C_.src.Views;
using BTL_C_.src.Views.Admin;
using BTL_C_.src.Views.Client;
using System;
using System.Windows.Forms;

namespace BTL_C_
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //FrmCreateAccount view = new FrmCreateAccount();
      //new AccountController(view);
      FrmLogin view = new FrmLogin();
      //Home view = new Home();
      //FrmHome view = new FrmHome();
      //FrmInventoryAuditReport view = new FrmInventoryAuditReport();
      //InvoiceDetailControl view = new InvoiceDetailControl();
      //FrmSeason view = new FrmSeason();
      new LoginController(view);

      //FrmCreateProduct view = new FrmCreateProduct();
      //view.Load += (s, e) =>
      //{
      //new ProductController(view);
      //new HomeController(view);
      //new InventoryAuditReportController(view);
      //new InvoiceDetailController(view);
      //new SeasonController(view);
      //};
      Application.Run(view);
    }
  }
}
