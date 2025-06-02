using BTL_C_.src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal abstract class BaseController<T>
  {
    public void Delete(object sender, EventArgs e)
    {
      string id = GetId();
      if (string.IsNullOrWhiteSpace(id))
      {
        MessageUtil.ShowWarning($"Vui lòng chọn {EntityName} muốn xóa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có chắc chắn xóa?"))
        return;
      try
      {
        if (!DeleteById(id))
        {
          MessageUtil.ShowWarning($"Xóa {EntityName} thất bại!");
          return;
        }

        MessageUtil.ShowInfo($"Đã xóa {EntityName} thành công!");
        ResetView(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, $"Đã xảy ra lỗi khi xóa {EntityName}!!!");
      }
    }

    // Các phương thức cần override
    protected abstract string GetId();
    protected abstract bool DeleteById(string id);
    protected abstract void ResetView(object sender, EventArgs e);
    protected abstract string EntityName { get; }
    protected virtual void Close(object sender, EventArgs e)
    {
      if (!MessageUtil.Confirm("Bạn có muốn thoát không?"))
        return;
      AppController.startDashBoard(GetForm());
    }
    protected virtual Form GetForm() => null;
  }
}
