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
  public partial class FrmSeason : Form
  {
    public FrmSeason()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetSeasonCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewMua.CellClick += handler;
    public void LoadDataToGridViewSeaSon(DataView dv)
    {
      dataGridViewMua.DataSource = dv;
      dataGridViewMua.Columns[0].HeaderText = "Mã Mùa";
      dataGridViewMua.Columns[0].Width = 159;
      dataGridViewMua.Columns[1].HeaderText = "Tên Mùa";
      dataGridViewMua.Columns[1].Width = 160;
      dataGridViewMua.AllowUserToAddRows = false;
      dataGridViewMua.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string mamua, string tenmua)
    {
      txtMaMua.Text = mamua;
      txtTenMua.Text = tenmua;
    }

    public void ResetForm()
    {
      txtMaMua.Text = "";
      txtTenMua.Text = "";
    }
    public string GetMaMua() => txtMaMua.Text.Trim();

    public string GetTenMua() => txtTenMua.Text.Trim();
    public DataGridView GetDataGridViewSeason() => dataGridViewMua;
    public Form GetForm() => this;
  }
}
