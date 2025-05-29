using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal class EmployeeController
  {
    private EmployeeDAO employeeDao;
    private EmployeeControl viewEmployeeControl;


    public EmployeeController(EmployeeControl viewEmployeeControl)
    {
      this.viewEmployeeControl = viewEmployeeControl;
      employeeDao = new EmployeeDAO();
      LoadFormDataToGridView();
      TaskDAO.fillTaskCombo(viewEmployeeControl.GetCmbCongViec());
      SetupEventListeners();
    }
    private void SetupEventListeners()
    {
      viewEmployeeControl.SetLuuListener(UpdateEmployee);
      viewEmployeeControl.SetEmployeeCellClickListener(OnEmployeeCellClick);
      viewEmployeeControl.SetLamMoiLítener(ResetForm);
      viewEmployeeControl.SetTimListener(FindEmployeesBySearch);
    }
    private void LoadFormDataToGridView()
    {
      // Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
      DataTable allAccounts = employeeDao.getAllRecord();

      // Tạo DataView từ DataTable và lọc theo vai trò
      DataView dv = new DataView(allAccounts);

      viewEmployeeControl.LoadDataToGridView(dv);
    }
    private void UpdateEmployee(object sender, EventArgs e)
    {
      string manv = viewEmployeeControl.GetMaNV();
      if (string.IsNullOrWhiteSpace(manv))
      {
        MessageUtil.ShowWarning("Vui lòng chọn thông tin nhân viên muốn sửa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
        return;
      string tennv = viewEmployeeControl.GetTenNV();
      string gioitinh = viewEmployeeControl.GetGioiTinh();
      DateTime ngaysinh = viewEmployeeControl.GetNgaySinh();
      string sdt = ConvertUtil.convertSdtToDB(viewEmployeeControl.GetSDT());
      string macv = viewEmployeeControl.GetCongViec();
      string diachi = viewEmployeeControl.GetDiaChi();
      EmployeeModel employee = new EmployeeModel(manv, tennv, ngaysinh, sdt, diachi, macv, gioitinh);
      try
      {
        if (!employeeDao.update(employee))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        ResetForm(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }
    private void OnEmployeeCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewEmployeeControl.GetDataGridViewEmployee();
        var row = dgv.Rows[e.RowIndex];
        string manv = row.Cells[0].Value.ToString();
        string tennv = row.Cells[1].Value.ToString();
        string gioitinh = row.Cells[2].Value.ToString();
        DateTime? ngaysinh = null;

        if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime tempDate))
        {
          ngaysinh = tempDate;
        }
        else
        {
          ngaysinh = null; // hoặc dùng DateTime.MinValue nếu cần giá trị mặc định
        }
        string sdt = row.Cells[4].Value.ToString();
        string tencv = row.Cells[5].Value.ToString();
        string diachi = row.Cells[6].Value.ToString();
        viewEmployeeControl.SetForm(manv, tennv, diachi, gioitinh, tencv, sdt, ngaysinh);
      }
    }
    private void FindEmployeesBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = employeeDao.findRecordsByName("tennv", viewEmployeeControl.GetTextSearch());
        viewEmployeeControl.GetDataGridViewEmployee().DataSource = dv; // Hiển thị danh sách đã lọc
        viewEmployeeControl.LoadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
    private void ResetForm(object sender, EventArgs e)
    {
      viewEmployeeControl.ResetForm();
      LoadFormDataToGridView();
    }

  }
}
