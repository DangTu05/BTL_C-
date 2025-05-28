using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal class AccountController : BaseController<AccountModel>
  {
    private FrmCreateAccount viewFrmCreateAccount;
    private AccountControl viewAccounts;
    private AccountDAO accountDao;
    private EmployeeDAO employeeDAO;

    protected override string EntityName => "tài khoản";

    public AccountController(FrmCreateAccount viewFrmCreateAccount)
    {

      this.viewFrmCreateAccount = viewFrmCreateAccount;
      accountDao = new AccountDAO();
      employeeDAO = new EmployeeDAO();
      viewFrmCreateAccount.setTaoListener(insertAccount);
    }
    public AccountController(AccountControl accountControl)
    {
      viewAccounts = accountControl;
      accountDao = new AccountDAO();
      LoadDataToGridView();
      SetupEventListener();
    }
    private void insertAccount(object sender, EventArgs e)
    {
      try
      {

        if (!InputValidate.inputCreateAccountValidate(viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), viewFrmCreateAccount.getPassword(), viewFrmCreateAccount.getVaiTro()))
        {
          return;
        }


        if (accountDao.checkExist(viewFrmCreateAccount.getEmail()))
        {

          MessageUtil.ShowWarning("Email đã tồn tại!!!");
          return;
        }
        string acc_id = GenerateIdUtil.GenerateId("ACC");
        AccountModel account = null;
        if (viewFrmCreateAccount.getVaiTro() == "Admin")
        {
          account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), null, null);
        }
        else
        {
          string employee_id = GenerateIdUtil.GenerateId("EMPLOYEE");
          while (employeeDAO.checkExist(employee_id))
          {
            employee_id = GenerateIdUtil.GenerateId("EMPLOYEE");
          }
          EmployeeModel employee = new EmployeeModel(employee_id, "", null, "", "", null, null);
          account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), employee_id, null);
          if (!employeeDAO.insert(employee))
          {
            MessageUtil.ShowError("Thêm không thành công!!!");
            return;
          }
        }

        if (!accountDao.insert(account))
        {
          MessageUtil.ShowError("Thêm không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Đã tạo thành công!");
      }
      catch (Exception ex) // Renamed the variable to 'ex' to avoid conflict with the parameter 'e'  
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi thêm tài khoản!!!");
      }
    }
    private void LoadDataToGridView()
    {
      // Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
      DataTable allAccounts = accountDao.getAllRecord();

      // Tạo DataView từ DataTable và lọc theo vai trò
      DataView dv = new DataView(allAccounts);
      dv.RowFilter = "vaitro = 'Nhân Viên'";

      viewAccounts.loadDataToGridView(dv);

    }
    private void SetupEventListener()
    {
      viewAccounts.setAccountCellClickListener(OnAccountCellClick);
      viewAccounts.setLamMoiListener(Reset);
      viewAccounts.setLuuListener(UpdateAccount);
      viewAccounts.setXoaListener(Delete);
      viewAccounts.setTrangThaiListener(ChangeStatus);
      viewAccounts.setTimListener(FindAccountBySearch);
      viewAccounts.setTaoListener(RedirectFrmCreateAccount);
    }
    private void OnAccountCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewAccounts.GetDataGridView();
        var row = dgv.Rows[e.RowIndex];
        string matk = row.Cells[0].Value.ToString();
        string email = row.Cells[1].Value.ToString();
        string tendangnhap = row.Cells[2].Value.ToString();
        string vaitro = row.Cells[4].Value.ToString();
        string manv = row.Cells[5].Value.ToString();
        string status = row.Cells[6].Value.ToString();
        viewAccounts.setFormData(matk, email, tendangnhap, vaitro, status, manv);
      }
    }
    private void Reset(object sender, EventArgs e)
    {
      viewAccounts.resetForm();
      LoadDataToGridView();
    }

    private void UpdateAccount(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(viewAccounts.getMatk()))
        {
          MessageUtil.ShowWarning("Vui lòng chọn tài khoản muốn sửa!");
          return;
        }
        if (!InputValidate.inputUpdateAccountValidate(viewAccounts.getEmail(), viewAccounts.getTenDangNhap(), viewAccounts.getStatus(), viewAccounts.getVaiTro()))
        {
          return;
        }
        AccountModel account = new AccountModel(viewAccounts.getMatk(), viewAccounts.getEmail(), viewAccounts.getTenDangNhap(), "", viewAccounts.getVaiTro(), "", viewAccounts.getStatus());
        if (!accountDao.update(account))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        LoadDataToGridView();
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }
    private void ChangeStatus(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(viewAccounts.getMatk()))
      {
        MessageUtil.ShowWarning("Vui lòng chọn tài khoản muốn sửa!");
        return;
      }
      String newStatus = viewAccounts.getStatus().Equals("hoạt động") ? "ngừng hoạt động" : "hoạt động";
      viewAccounts.setStatus(newStatus);

      try
      {
        if (!accountDao.changeStatus(viewAccounts.getStatus(), viewAccounts.getMatk()))
        {
          MessageUtil.ShowWarning("Cập nhật thất bại!");
          return;
        }

        LoadDataToGridView();
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi thay đổi trạng thái!!!");
      }
    }
    private void FindAccountBySearch(object sender, EventArgs e)
    {

      try
      {
        AccountModel account = accountDao.findRecordByField("email", viewAccounts.getSearchText());
        if (account == null)
        {
          MessageUtil.ShowInfo("Tài khoản không tồn tại!");
          return;
        }
        DataView dv = ConvertToDataView.ObjectToDataView(account);
        dv.RowFilter = "vai_tro = 'Nhân Viên'";
        viewAccounts.loadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void RedirectFrmCreateAccount(object sender, EventArgs e)
    {
      AppController.startFrmCreateAccount(viewAccounts.getForm());
    }

    protected override string GetId() => viewAccounts.getMatk();

    protected override bool DeleteById(string id) => accountDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => Reset(sender, e);
  }
}
