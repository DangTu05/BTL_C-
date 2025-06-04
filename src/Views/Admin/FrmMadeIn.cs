using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class FrmMadeIn : Form
  {
    public FrmMadeIn()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetMadeInCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewNoiSanXuat.CellClick += handler;
    public void LoadDataToGridViewMadeIn(DataView dv)
    {
      dataGridViewNoiSanXuat.DataSource = dv;
      dataGridViewNoiSanXuat.Columns[0].HeaderText = "Mã Nơi Sản Xuất";
      dataGridViewNoiSanXuat.Columns[0].Width = 159;
      dataGridViewNoiSanXuat.Columns[1].HeaderText = "Tên Nơi Sản Xuất";
      dataGridViewNoiSanXuat.Columns[1].Width = 160;
      dataGridViewNoiSanXuat.AllowUserToAddRows = false;
      dataGridViewNoiSanXuat.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string mansx, string tennsx)
    {
      txtMaNoiSanXuat.Text = mansx;
      txtTenNoiSanXuat.Text = tennsx;
    }

    public void ResetForm()
    {
      txtMaNoiSanXuat.Text = "";
      txtTenNoiSanXuat.Text = "";
    }
    public string GetMaNoiSanXuat() => txtMaNoiSanXuat.Text.Trim();

    public string GetTenNoiSanXuat() => txtTenNoiSanXuat.Text.Trim();
    public DataGridView GetDataGridViewMadeIn() => dataGridViewNoiSanXuat;
    public Form GetForm() => this;
  }
}