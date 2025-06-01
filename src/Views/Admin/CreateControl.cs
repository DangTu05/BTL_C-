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
  public partial class CreateControl : UserControl
  {
    public CreateControl()
    {
      InitializeComponent();
    }
    public void SetMuaListener(EventHandler handler) => btnMua.Click += handler;
    public void SetMauListener(EventHandler handler) => btnMau.Click += handler;
    public void SetChatLieuListener(EventHandler handler) => btnChatLieu.Click += handler;
    public void SetTheLoaiListener(EventHandler handler) => btnTheLoai.Click += handler;
    public void SetCoListener(EventHandler handler) => btnCo.Click += handler;
    public void SetDoiTuongListener(EventHandler handler) => btnDoiTuong.Click += handler;
    public void SetNoiSanXuatListener(EventHandler handler) => btnNoiSanXuat.Click += handler;
    public void SetCongViecListener(EventHandler handler) => btnCongViec.Click += handler;
    public Form GetForm()
    {
      return this.FindForm();
    }
  }
}
