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
  public partial class FrmCategory : Form
  {
    public FrmCategory()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetCategoryCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewTheLoai.CellClick += handler;
    public void LoadDataToGridViewCategory(DataView dv)
    {
      dataGridViewTheLoai.DataSource = dv;
      dataGridViewTheLoai.Columns[0].HeaderText = "Mã Thể Loại";
      dataGridViewTheLoai.Columns[0].Width = 159;
      dataGridViewTheLoai.Columns[1].HeaderText = "Tên Thể Loại";
      dataGridViewTheLoai.Columns[1].Width = 160;
      dataGridViewTheLoai.AllowUserToAddRows = false;
      dataGridViewTheLoai.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string matl, string tentl)
    {
      txtMaTheLoai.Text = matl;
      txtTenTheLoai.Text = tentl;
    }

    public void ResetForm()
    {
      txtMaTheLoai.Text = "";
      txtTenTheLoai.Text = "";
    }
    public string GetMaTheLoai() => txtMaTheLoai.Text.Trim();

    public string GetTenTheLoai() => txtTenTheLoai.Text.Trim();
    public DataGridView GetDataGridViewCategory() => dataGridViewTheLoai;
    public Form GetForm() => this;
  }
}