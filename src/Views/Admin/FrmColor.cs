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
  public partial class FrmColor : Form
  {
    public FrmColor()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetColorCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewMau.CellClick += handler;
    public void LoadDataToGridViewColor(DataView dv)
    {
      dataGridViewMau.DataSource = dv;
      dataGridViewMau.Columns[0].HeaderText = "Mã Màu";
      dataGridViewMau.Columns[0].Width = 159;
      dataGridViewMau.Columns[1].HeaderText = "Tên Màu";
      dataGridViewMau.Columns[1].Width = 160;
      dataGridViewMau.AllowUserToAddRows = false;
      dataGridViewMau.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string mamau, string tenmau)
    {
      txtMaMau.Text = mamau;
      txtTenMau.Text = tenmau;
    }

    public void ResetForm()
    {
      txtMaMau.Text = "";
      txtTenMau.Text = "";
    }
    public string GetMaMau() => txtMaMau.Text.Trim();

    public string GetTenMau() => txtTenMau.Text.Trim();
    public DataGridView GetDataGridViewColor() => dataGridViewMau;
  }
}
