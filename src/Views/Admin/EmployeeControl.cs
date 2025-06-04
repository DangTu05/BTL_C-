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
  public partial class EmployeeControl : UserControl
  {
    public EmployeeControl()
    {
      InitializeComponent();
    }
    public void SetLamMoiLítener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetTimListener(EventHandler handler) => btnTim.Click += handler;
    public void SetEmployeeCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewEmployee.CellClick += handler;
    public void LoadDataToGridView(DataView dv)
    {
      dataGridViewEmployee.DataSource = dv;
      dataGridViewEmployee.Columns[0].HeaderText = "Mã nhân viên";

      dataGridViewEmployee.Columns[1].HeaderText = "Tên nhân viên";
      dataGridViewEmployee.Columns[1].Width = 157;

      dataGridViewEmployee.Columns[2].HeaderText = "Giới tính";
      dataGridViewEmployee.Columns[3].HeaderText = "Ngày sinh";
      dataGridViewEmployee.Columns[4].HeaderText = "Số điện thoại";
      dataGridViewEmployee.Columns[5].HeaderText = "Công việc";
      dataGridViewEmployee.Columns[6].HeaderText = "Địa chỉ";
      dataGridViewEmployee.Columns[6].Width = 113;

      dataGridViewEmployee.ReadOnly = true;
      dataGridViewEmployee.AllowUserToAddRows = false;
    }
    public void SetForm(string manv, string tennv, string diachi, string gt, string congviec, string sdt, DateTime? ngaysinh)
    {
      txtMaNhanVien.Text = manv;
      txtTenNhanVien.Text = tennv;
      txtDiaChi.Text = diachi;
      if (cmbGioiTinh.Items.Contains(gt))
        cmbGioiTinh.SelectedItem = gt;

      // Công việc
      int idx = cmbCongViec.FindStringExact(congviec);
      if (idx != -1)
      {
        cmbCongViec.SelectedIndex = idx;
      }
      mskSDT.Text = sdt;
      dateNgaySinh.Value = ngaysinh ?? DateTime.Today;
    }
    public void ResetForm()
    {
      txtMaNhanVien.Text = "";
      txtTenNhanVien.Text = "";
      txtDiaChi.Text = "";
      if (cmbGioiTinh.Items.Count > 0)
        cmbGioiTinh.SelectedIndex = 0;

      if (cmbCongViec.Items.Count > 0)
        cmbCongViec.SelectedIndex = 0;

      mskSDT.Text = "";
      dateNgaySinh.Value = DateTime.Today;
    }
    public ComboBox GetCmbCongViec()
    {
      return cmbCongViec;
    }
    public string GetMaNV() => txtMaNhanVien.Text.Trim();

    public string GetTenNV() => txtTenNhanVien.Text.Trim();

    public string GetDiaChi() => txtDiaChi.Text.Trim();
    public string GetCongViec() => cmbCongViec.SelectedValue.ToString();
    public string GetGioiTinh() => (string)cmbGioiTinh.SelectedItem;
    public DateTime GetNgaySinh() => dateNgaySinh.Value;
    public string GetSDT() => mskSDT.Text.Trim();
    public string GetTextSearch() => txtSearch.Text.Trim();
    public DataGridView GetDataGridViewEmployee() => dataGridViewEmployee;
  }
}
