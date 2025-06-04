using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class ProductControl : UserControl
  {
    public ProductControl()
    {
      InitializeComponent();
    }
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetTimListener(EventHandler handler) => btnTim.Click += handler;
    public void SetProductCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewProduct.CellClick += handler;

    public void LoadDataToGridView(DataView dv)
    {
      dataGridViewProduct.DataSource = dv;
      dataGridViewProduct.Columns[0].HeaderText = "Mã sản phẩm";

      dataGridViewProduct.Columns[1].HeaderText = "Tên sản phẩm";
      dataGridViewProduct.Columns[1].Width = 147; // Email rộng 147px

      dataGridViewProduct.Columns[2].HeaderText = "Thể loại";
      dataGridViewProduct.Columns[3].HeaderText = "Màu";
      dataGridViewProduct.Columns[4].HeaderText = "Nơi sản xuất";
      dataGridViewProduct.Columns[5].HeaderText = "Đối tượng";
      dataGridViewProduct.Columns[6].HeaderText = "Mùa";
      dataGridViewProduct.Columns[7].HeaderText = "Chất liệu";
      dataGridViewProduct.Columns[8].HeaderText = "Cỡ";
      dataGridViewProduct.Columns[9].HeaderText = "Số lượng tồn kho";
      dataGridViewProduct.Columns[10].HeaderText = "Ảnh";
      dataGridViewProduct.Columns[11].HeaderText = "Đơn giá nhập";
      dataGridViewProduct.Columns[12].HeaderText = "Đơn giá bán";
      dataGridViewProduct.Columns[13].HeaderText = "Trạng thái";

      dataGridViewProduct.ReadOnly = true;
      dataGridViewProduct.AllowUserToAddRows = false;
    }
    public void ResetForm()
    {
      txtMaSanPham.Text = "";
      txtTenSanPham.Text = "";
      txtAnh.Text = "";
      txtSearch.Text = "";
      if (cmbChatLieu.Items.Count > 0) cmbChatLieu.SelectedIndex = 0;
      if (cmbCo.Items.Count > 0) cmbCo.SelectedIndex = 0;
      if (cmbDoiTuong.Items.Count > 0) cmbDoiTuong.SelectedIndex = 0;
      if (cmbMau.Items.Count > 0) cmbMau.SelectedIndex = 0;
      if (cmbMua.Items.Count > 0) cmbMua.SelectedIndex = 0;
      if (cmbNoiSanXuat.Items.Count > 0) cmbNoiSanXuat.SelectedIndex = 0;
      if (cmbTheLoai.Items.Count > 0) cmbTheLoai.SelectedIndex = 0;
      if (cmbTrangThai.Items.Count > 0) cmbTrangThai.SelectedIndex = 0;
      txtSLTonKho.Text = "";
      txtDonGiaBan.Text = "";
      txtDonGiaNhap.Text = "";
    }
    public void SetForm(string masanpham, string tensanpham, string theloai, string chatlieu, string mau, string dt, string mua, string nsx, string co, int sltonkho, float dongianhap, float dongiaban, string anh, string trangthai)
    {
      txtMaSanPham.Text = masanpham ?? "";
      txtTenSanPham.Text = tensanpham ?? "";
      txtAnh.Text = anh ?? "";
      txtSLTonKho.Text = sltonkho.ToString();
      txtDonGiaNhap.Text = dongianhap.ToString("N0"); // Format: 1,000
      txtDonGiaBan.Text = dongiaban.ToString("N0");
      cmbChatLieu.SelectedIndex = cmbChatLieu.FindStringExact(chatlieu);
      cmbMau.SelectedIndex = cmbMau.FindStringExact(mau);
      cmbMua.SelectedIndex = cmbMua.FindStringExact(mua);
      cmbDoiTuong.SelectedIndex = cmbDoiTuong.FindStringExact(dt);
      cmbTheLoai.SelectedIndex = cmbTheLoai.FindStringExact(theloai);
      cmbCo.SelectedIndex = cmbCo.FindStringExact(co);
      cmbNoiSanXuat.SelectedIndex = cmbNoiSanXuat.FindStringExact(nsx);
      cmbTrangThai.SelectedIndex = cmbTrangThai.FindStringExact(trangthai);

      dataGridViewProduct.ClearSelection();

    }
    public DataGridView GetDataGridViewProduct()
    {
      return dataGridViewProduct;
    }
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
    public string GetMaSanPham()
    {
      return txtMaSanPham.Text.Trim();
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
      return cmbNoiSanXuat.SelectedValue.ToString();
    }
    public string GetTrangThai()
    {
      return cmbTrangThai.SelectedItem.ToString();
    }
    public int GetSoLuongTonKho()
    {
      int sl;
      if (int.TryParse(txtSLTonKho.Text, out sl))
      {
        return sl;
      }
      else
      {
        // Có thể log lỗi hoặc trả về giá trị mặc định
        return 1;
      }
    }
    public float GetDonGiaNhap()
    {
      float donGia;
      if (float.TryParse(txtDonGiaNhap.Text, out donGia))
      {
        return donGia;
      }
      else
      {
        // Có thể log lỗi hoặc trả về giá trị mặc định
        return 0f;
      }
    }
    public float GetDonGiaBan()
    {
      float donGia;
      if (float.TryParse(txtDonGiaBan.Text, out donGia))
      {
        return donGia;
      }
      else
      {
        // Có thể log lỗi hoặc trả về giá trị mặc định
        return 0f;
      }
    }

    public string GetAnh()
    {
      return txtAnh.Text.Trim();
    }
    public Form GetForm()
    {
      return this.FindForm();
    }
    public string GetTextSearch()
    {
      return txtSearch.Text.Trim();
    }


  }
}
