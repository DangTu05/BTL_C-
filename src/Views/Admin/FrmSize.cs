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
  public partial class FrmSize : Form
  {
    public FrmSize()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetSizeCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewCo.CellClick += handler;
    public void LoadDataToGridViewSize(DataView dv)
    {
      dataGridViewCo.DataSource = dv;
      dataGridViewCo.Columns[0].HeaderText = "Mã Cỡ";
      dataGridViewCo.Columns[0].Width = 159;
      dataGridViewCo.Columns[1].HeaderText = "Tên Cỡ";
      dataGridViewCo.Columns[1].Width = 160;
      dataGridViewCo.AllowUserToAddRows = false;
      dataGridViewCo.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string maco, string tenco)
    {
      txtMaCo.Text = maco;
      txtTenCo.Text = tenco;
    }

    public void ResetForm()
    {
      txtMaCo.Text = "";
      txtTenCo.Text = "";
    }
    public string GetMaCo() => txtMaCo.Text.Trim();

    public string GetTenCo() => txtTenCo.Text.Trim();
    public DataGridView GetDataGridViewSize() => dataGridViewCo;
  }
}