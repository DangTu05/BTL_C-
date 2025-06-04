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
  public partial class FrmTask : Form
  {
    public FrmTask()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetTaskCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewCongViec.CellClick += handler;
    public void LoadDataToGridViewTask(DataView dv)
    {
      dataGridViewCongViec.DataSource = dv;
      dataGridViewCongViec.Columns[0].HeaderText = "Mã Công Việc";
      dataGridViewCongViec.Columns[0].Width = 159;
      dataGridViewCongViec.Columns[1].HeaderText = "Tên Công Việc";
      dataGridViewCongViec.Columns[1].Width = 160;
      dataGridViewCongViec.AllowUserToAddRows = false;
      dataGridViewCongViec.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string macv, string tencv)
    {
      txtMaCongViec.Text = macv;
      txtTenCongViec.Text = tencv;
    }

    public void ResetForm()
    {
      txtMaCongViec.Text = "";
      txtTenCongViec.Text = "";
    }
    public string GetMaCongViec() => txtMaCongViec.Text.Trim();

    public string GetTenCongViec() => txtTenCongViec.Text.Trim();
    public DataGridView GetDataGridViewTask() => dataGridViewCongViec;
    public Form GetForm() => this;
  }
}