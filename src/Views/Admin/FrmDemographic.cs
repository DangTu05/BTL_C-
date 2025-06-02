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
  public partial class FrmDemographic : Form
  {
    public FrmDemographic()
    {
      InitializeComponent();
    }
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetThoatListener(EventHandler handler) => btnThoat.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetObjectCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewDoiTuong.CellClick += handler;
    public void LoadDataToGridViewObject(DataView dv)
    {
      dataGridViewDoiTuong.DataSource = dv;
      dataGridViewDoiTuong.Columns[0].HeaderText = "Mã Đối Tượng";
      dataGridViewDoiTuong.Columns[0].Width = 159;
      dataGridViewDoiTuong.Columns[1].HeaderText = "Tên Đối Tượng";
      dataGridViewDoiTuong.Columns[1].Width = 160;
      dataGridViewDoiTuong.AllowUserToAddRows = false;
      dataGridViewDoiTuong.EditMode = DataGridViewEditMode.EditProgrammatically;// Chỉ được chỉnh sửa ô bằng code, không cho người dùng tự click và sửa nội dung
    }

    public void SetFormData(string madt, string tendt)
    {
      txtMaDoiTuong.Text = madt;
      txtTenDoiTuong.Text = tendt;
    }

    public void ResetForm()
    {
      txtMaDoiTuong.Text = "";
      txtTenDoiTuong.Text = "";
    }
    public string GetMaDoiTuong() => txtMaDoiTuong.Text.Trim();

    public string GetTenDoiTuong() => txtTenDoiTuong.Text.Trim();
    public DataGridView GetDataGridViewObject() => dataGridViewDoiTuong;
    public Form GetForm() => this;
  }
}
