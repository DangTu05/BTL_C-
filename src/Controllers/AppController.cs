using BTL_C_.src.Controllers.Admin;
using BTL_C_.src.Controllers.Client;
using BTL_C_.src.Views;
using BTL_C_.src.Views.Admin;
using System.Windows.Forms;
using WebQLCHQuanAo;

namespace BTL_C_.src.Controllers
{
  internal class AppController
  {
    public static void startDashBoard(Form previousForm)
    {
      Home home = new Home();
      Admin.HomeController homeController = new Admin.HomeController(home);
      home.Show();
      previousForm.Hide();
    }
    public static void startFrmCreateAccount(Form previousForm)
    {
      FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
      AccountController accountController = new AccountController(frmCreateAccount);
      frmCreateAccount.Show();
      previousForm.Hide();
    }
    public static void startFrmCreateProduct(Form previousForm)
    {
      FrmCreateProduct frmCreateProduct = new FrmCreateProduct();
      ProductController productController = new ProductController(frmCreateProduct);
      frmCreateProduct.Show();
      previousForm.Hide();
    }
    public static void startFrmLogin(Form previousForm)
    {
      FrmLogin frmLogin = new FrmLogin();
      LoginController loginController = new LoginController(frmLogin);
      frmLogin.Show();
      previousForm.Hide();
    }
    public static void StartFrmColor(Form previousForm)
    {
      FrmColor frmColor = new FrmColor();
      ColorController colorController = new ColorController(frmColor);
      frmColor.Show();
      previousForm.Hide();
    }
    public static void StartFrmMaterial(Form previousForm)
    {
      FrmMaterial frmMaterial = new FrmMaterial();
      MaterialController materialController = new MaterialController(frmMaterial);
      frmMaterial.Show();
      previousForm.Hide();
    }
    public static void StartFrmSize(Form previousForm)
    {
      FrmSize frmSize = new FrmSize();
      SizeController sizeController = new SizeController(frmSize);
      frmSize.Show();
      previousForm.Hide();
    }
    public static void StartFrmDemographic(Form previousForm)
    {
      FrmDemographic frmDemographic = new FrmDemographic();
      DemographicController demographicController = new DemographicController(frmDemographic);
      frmDemographic.Show();
      previousForm.Hide();
    }
    public static void StartFrmSeason(Form previousForm)
    {
      FrmSeason frmSeason = new FrmSeason();
      SeasonController seasonController = new SeasonController(frmSeason);
      frmSeason.Show();
      previousForm.Hide();
    }
    public static void StartHomeClient(Form previousForm)
    {
      FrmHome frmHome = new FrmHome();
      Client.HomeController homeController = new Client.HomeController(frmHome);
      frmHome.Show();
      previousForm.Hide();
    }
  }
}
