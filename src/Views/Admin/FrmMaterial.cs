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
  public partial class FrmMaterial : Form
  {
    public FrmMaterial()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetMaterialCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewChatLieu.CellClick += handler;
    public void LoadDataToGridViewMaterial(DataView dv)
    {
      dataGridViewChatLieu.DataSource = dv;
      dataGridViewChatLieu.Columns[0].HeaderText = "Mã Chất liệu";
      dataGridViewChatLieu.Columns[0].Width = 159;
      dataGridViewChatLieu.Columns[1].HeaderText = "Tên Chất liệu";
      dataGridViewChatLieu.Columns[1].Width = 160;
      dataGridViewChatLieu.AllowUserToAddRows = false;
      dataGridViewChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string macl, string tencl)
    {
      txtMaChatLieu.Text = macl;
      txtTenChatLieu.Text = tencl;
    }

    public void ResetForm()
    {
      txtMaChatLieu.Text = "";
      txtTenChatLieu.Text = "";
    }
    public string GetMaChatLieu() => txtMaChatLieu.Text.Trim();

    public string GetTenChatLieu() => txtTenChatLieu.Text.Trim();
    public DataGridView GetDataGridViewMaterial() => dataGridViewChatLieu;
    public Form GetForm() => this;
  }
}
