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
  internal class ColorController : BaseController<ColorModel>
  {
    private FrmColor viewFrmColor;
    private ColorDAO colorDao;

    protected override string EntityName => "màu";

    public ColorController(FrmColor viewFrmColor)
    {
      this.viewFrmColor = viewFrmColor;
      colorDao = new ColorDAO();
      LoadDataToGridViewColor();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmColor.SetTaoListener(InsertColor);
      viewFrmColor.SetLamMoiListener(ResetForm);
      viewFrmColor.SetLuuListener(UpdateColor);
      viewFrmColor.SetXoaListener(Delete);
      viewFrmColor.SetColorCellClickListener(OnAccountCellClick);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewColor()
    {
      try
      {
        DataTable dt = colorDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmColor.LoadDataToGridViewColor(dv);
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
        var dgv = viewFrmColor.GetDataGridViewColor();
        var row = dgv.Rows[e.RowIndex];
        string mamau = row.Cells[0].Value.ToString();
        string tenmau = row.Cells[1].Value.ToString();
        viewFrmColor.SetFormData(mamau, tenmau);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertColor(object sender, EventArgs e)
    {

      if (!InputValidate.inputColorValidate(viewFrmColor.GetTenMau()))
        return;
      try
      {
        string mamau = GenerateIdUtil.GenerateId("COLOR");
        ColorModel color = new ColorModel(mamau, viewFrmColor.GetTenMau());
        if (!colorDao.insert(color))
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
    private void UpdateColor(object sender, EventArgs e)
    {
      string mamau = viewFrmColor.GetMaMau();
      string tenmau = viewFrmColor.GetTenMau();
      if (string.IsNullOrWhiteSpace(mamau))
      {
        MessageUtil.ShowWarning("Vui lòng chọn màu muốn sửa!");
        return;
      }
      if (!InputValidate.inputColorValidate(tenmau))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        ColorModel color = new ColorModel(mamau, tenmau);
        if (!colorDao.update(color))
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
      viewFrmColor.ResetForm();
      LoadDataToGridViewColor();
    }

    protected override string GetId() => viewFrmColor.GetMaMau();

    protected override bool DeleteById(string id) => colorDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
  }
}
