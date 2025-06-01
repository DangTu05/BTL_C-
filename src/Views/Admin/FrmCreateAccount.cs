using System;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class FrmCreateAccount : Form
  {
    public FrmCreateAccount()
    {
      InitializeComponent();
    }

    public string getEmail()
    {
      return txtEmail.Text.Trim();
    }
    public string getPassword()
    {
      return txtMatKhau.Text.Trim();
    }
    public string getTenDangNhap()
    {
      return txtTenDangNhap.Text.Trim();
    }
    public string getVaiTro()
    {
      return cmbVaiTro.SelectedItem?.ToString() ?? string.Empty;
    }
    //public void setTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void setTaoListener(EventHandler handler) => btnTao.Click += handler;
    public Form GetForm()
    {
      return this;
    }
  }
}
