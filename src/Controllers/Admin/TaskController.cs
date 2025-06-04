using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
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
  internal class TaskController : BaseController<TaskModel>
  {
    private FrmTask viewFrmTask;
    private TaskDAO taskDao;

    protected override string EntityName => "công việc";

    public TaskController(FrmTask viewFrmTask)
    {
      this.viewFrmTask = viewFrmTask;
      taskDao = new TaskDAO();
      LoadDataToGridViewTask();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmTask.SetTaoListener(InsertTask);
      viewFrmTask.SetLamMoiListener(ResetForm);
      viewFrmTask.SetLuuListener(UpdateTask);
      viewFrmTask.SetXoaListener(Delete);
      viewFrmTask.SetTaskCellClickListener(OnAccountCellClick);
      viewFrmTask.SetThoatListener(Close);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewTask()
    {
      try
      {
        DataTable dt = taskDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmTask.LoadDataToGridViewTask(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    /// <summary>
    /// Sử lý sự kiện cellclick vào datagridview
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnAccountCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewFrmTask.GetDataGridViewTask();
        var row = dgv.Rows[e.RowIndex];
        string macv = row.Cells[0].Value.ToString();
        string tencv = row.Cells[1].Value.ToString();
        viewFrmTask.SetFormData(macv, tencv);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertTask(object sender, EventArgs e)
    {

      if (!InputValidate.InputTaskValidate(viewFrmTask.GetTenCongViec()))
        return;
      try
      {
        string macv = GenerateIdUtil.GenerateId("TASK");
        TaskModel task = new TaskModel(macv, viewFrmTask.GetTenCongViec());
        if (!taskDao.insert(task))
        {
          MessageUtil.ShowError("Tạo không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Tạo thành công!");
        ResetForm(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
      }
    }
    private void UpdateTask(object sender, EventArgs e)
    {
      string macv = viewFrmTask.GetMaCongViec();
      string tencv = viewFrmTask.GetTenCongViec();
      if (string.IsNullOrWhiteSpace(macv))
      {
        MessageUtil.ShowWarning("Vui lòng chọn công việc muốn sửa!");
        return;
      }
      if (!InputValidate.InputTaskValidate(tencv))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        TaskModel task = new TaskModel(macv, tencv);
        if (!taskDao.update(task))
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

    /// <summary>
    /// Reset form
    /// </summary>
    private void ResetForm(object sender, EventArgs e)
    {
      viewFrmTask.ResetForm();
      LoadDataToGridViewTask();
    }

    protected override string GetId() => viewFrmTask.GetMaCongViec();

    protected override bool DeleteById(string id) => taskDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
    protected override Form GetForm() => viewFrmTask.GetForm();
  }
}