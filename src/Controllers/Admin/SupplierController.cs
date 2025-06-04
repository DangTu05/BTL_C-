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
  internal class SupplierController : BaseController<SupplierModel>
  {
    private SupplierControl viewSupplierControl;
    private SupplierDAO supplierDao;

    protected override string EntityName => "nhà cung cấp";

    public SupplierController(SupplierControl supplierControl)
    {
      this.viewSupplierControl = supplierControl;
      supplierDao = new SupplierDAO();
      LoadDataToGridView();
      SetupEventListeners();
    }
    private void SetupEventListeners()
    {
      viewSupplierControl.SetLamMoiListener(Reset);
      viewSupplierControl.SetTaoListener(InsertSupplier);
      viewSupplierControl.SetSupplierCellClickListener(OnSupplierCellClick);
      viewSupplierControl.SetLuuListener(UpdateSupplier);
      viewSupplierControl.SetXoaListener(Delete);
      viewSupplierControl.SetTimListener(FindSupplierBySearch);
    }
    public void InsertSupplier(object sender, EventArgs e)
    {
      string mancc = GenerateIdUtil.GenerateId("SUPPLI");
      string tenncc = viewSupplierControl.GetTenNCC();
      string diachi = viewSupplierControl.GetDiaChi();
      string sdt = ConvertUtil.convertSdtToDB(viewSupplierControl.GetSDT());//  (036) 452-1234 => 0364521234
      if (!InputValidate.inputCreaetSupplierValidate(mancc, tenncc, diachi, sdt))
        return;
      SupplierModel supplier = new SupplierModel(mancc, tenncc, diachi, sdt);
      try
      {
        if (!supplierDao.insert(supplier))
        {
          MessageUtil.ShowError("Tạo thất bại!!!");
          return;
        }
        MessageUtil.ShowInfo("Tạo thành công!");
        Reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
      }
    }
    private void UpdateSupplier(object sender, EventArgs e)
    {
      string mancc = viewSupplierControl.GetMaNCC();
      string tenncc = viewSupplierControl.GetTenNCC();
      string diachi = viewSupplierControl.GetDiaChi();
      string sdt = ConvertUtil.convertSdtToDB(viewSupplierControl.GetSDT());
      if (string.IsNullOrWhiteSpace(mancc))
      {
        MessageUtil.ShowWarning("Vui lòng chọn nhà cung cấp muốn sửa!");
        return;
      }
      if (!InputValidate.inputCreaetSupplierValidate(mancc, tenncc, diachi, sdt))
        return;
      SupplierModel supplier = new SupplierModel(mancc, tenncc, diachi, sdt);
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
        return;
      try
      {
        if (!supplierDao.update(supplier))
        {
          MessageUtil.ShowError("Cập nhật thất bại!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        Reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }

    private void LoadDataToGridView()
    {
      try
      {// Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
        DataTable allAccounts = supplierDao.getAllRecord();

        // Tạo DataView từ DataTable và lọc theo vai trò
        DataView dv = new DataView(allAccounts);

        viewSupplierControl.LoadDataToGridView(dv);

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lôi!!!");
      }
    }
    private void OnSupplierCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewSupplierControl.GetDataGridViewSupplier();
        var row = dgv.Rows[e.RowIndex];
        string mancc = row.Cells[0].Value.ToString();
        string tenncc = row.Cells[1].Value.ToString();
        string diachi = row.Cells[2].Value.ToString();
        string sdt = row.Cells[3].Value.ToString();
        viewSupplierControl.SetFormData(mancc, tenncc, diachi, sdt);
      }
    }
    private void FindSupplierBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = supplierDao.findRecordsByName("tenncc", viewSupplierControl.GetTextSearch());
        viewSupplierControl.GetDataGridViewSupplier().DataSource = dv; // Hiển thị danh sách đã lọc
        viewSupplierControl.LoadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm!!!");
      }
    }
    private void Reset(object sender, EventArgs e)
    {
      viewSupplierControl.ResetForm();
      LoadDataToGridView();
    }

    protected override string GetId() => viewSupplierControl.GetMaNCC();

    protected override bool DeleteById(string id) => supplierDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => Reset(sender, e);
  }
}
