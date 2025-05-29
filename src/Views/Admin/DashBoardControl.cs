using System;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class DashBoardControl : UserControl
  {
    public DashBoardControl()
    {
      InitializeComponent();
    }
    public void SetSanPhamNoiBatListener(EventHandler handler) => pnlSanPhamNoiBat.Click += handler;
    public void loadFormData(int slsp, int slncc, int slkh, int slnv, int slcl, int sll, int slcv, int slhdn, int slhdb, string tenkhnb)
    {
      lblSLSP.Text = slsp.ToString();
      lblSLNCC.Text = slncc.ToString();
      lblSLKH.Text = slkh.ToString();
      lblSLNV.Text = slnv.ToString();
      lblSLCL.Text = slcl.ToString();
      lblSLL.Text = sll.ToString();
      lblSLCV.Text = slcv.ToString();
      lblSLHDN.Text = slhdn.ToString();
      lblSLHDB.Text = slhdb.ToString();
      lblKhachHangNoiBat.Text = tenkhnb.ToString();
    }

  }
}
