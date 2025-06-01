using System;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class FrmCreateProduct : Form
  {
    public FrmCreateProduct()
    {
      InitializeComponent();
    }
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public ComboBox GetCmbCo()
    {
      return cmbCo;
    }
    public ComboBox GetCmbChatLieu()
    {
      return cmbChatLieu;
    }
    public ComboBox GetCmbTheLoai()
    {
      return cmbTheLoai;
    }
    public ComboBox GetCmbMua()
    {
      return cmbMua;
    }
    public ComboBox GetCmbMau()
    {
      return cmbMau;
    }
    public ComboBox GetCmbDoiTuong()
    {
      return cmbDoiTuong;
    }
    public ComboBox GetCmbNoiSanXuat()
    {
      return cmbNoiSanXuat;
    }
    public string GetTenSanPham()
    {
      return txtTenSanPham.Text.Trim();
    }
    public string GetMaTheLoai()
    {
      return cmbTheLoai.SelectedValue.ToString();
    }
    public string GetMaChatLieu()
    {
      return cmbChatLieu.SelectedValue.ToString();
    }
    public string GetMaMau()
    {
      return cmbMau.SelectedValue.ToString();
    }
    public string GetMaMua()
    {
      return cmbMua.SelectedValue.ToString();
    }
    public string GetMaCo()
    {
      return cmbCo.SelectedValue.ToString();
    }
    public string GetMaDoiTuong()
    {
      return cmbDoiTuong.SelectedValue.ToString();
    }
    public string GetMaNoiSanXuat()
    {
      return cmbNoiSanXuat.SelectedValue?.ToString() ?? string.Empty;
    }
    public string GetTrangThai()
    {
      return cmbTrangThai.SelectedItem.ToString();
    }
    public int GetSoLuongTonKho()
    {
      return (int)slTonKho.Value;
    }
    public float GetDonGiaNhap()
    {
      return (float)donGiaNhap.Value;
    }
    public float GetDonGiaBan()
    {
      return (float)donGiaBan.Value;
    }
    public Form GetForm()
    {
      return this;
    }
  }
}
