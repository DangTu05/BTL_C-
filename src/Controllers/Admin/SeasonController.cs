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
  internal class SeasonController : BaseController<SeasonModel>
  {
    private FrmSeason viewFrmSeason;
    private SeasonDAO seasonDao;

    protected override string EntityName => "mùa";

    public SeasonController(FrmSeason viewFrmSeason)
    {
      this.viewFrmSeason = viewFrmSeason;
      seasonDao = new SeasonDAO();
      LoadDataToGridViewSeason();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmSeason.SetTaoListener(InsertSeason);
      viewFrmSeason.SetLamMoiListener(ResetForm);
      viewFrmSeason.SetLuuListener(UpdateSeason);
      viewFrmSeason.SetXoaListener(Delete);
      viewFrmSeason.SetSeasonCellClickListener(OnAccountCellClick);
      viewFrmSeason.SetThoatListener(Close);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewSeason()
    {
      try
      {
        DataTable dt = seasonDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmSeason.LoadDataToGridViewSeaSon(dv);
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
        var dgv = viewFrmSeason.GetDataGridViewSeason();
        var row = dgv.Rows[e.RowIndex];
        string mamua = row.Cells[0].Value.ToString();
        string tenmua = row.Cells[1].Value.ToString();
        viewFrmSeason.SetFormData(mamua, tenmua);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertSeason(object sender, EventArgs e)
    {

      if (!InputValidate.inputSeasonValidate(viewFrmSeason.GetTenMua()))
        return;
      try
      {
        string mamua = GenerateIdUtil.GenerateId("SEASON");
        SeasonModel season = new SeasonModel(mamua, viewFrmSeason.GetTenMua());
        if (!seasonDao.insert(season))
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
    private void UpdateSeason(object sender, EventArgs e)
    {
      string mamua = viewFrmSeason.GetMaMua();
      string tenmua = viewFrmSeason.GetTenMua();
      if (string.IsNullOrWhiteSpace(mamua))
      {
        MessageUtil.ShowWarning("Vui lòng chọn mùa muốn sửa!");
        return;
      }
      if (!InputValidate.inputSeasonValidate(tenmua))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        SeasonModel season = new SeasonModel(mamua, tenmua);
        if (!seasonDao.update(season))
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
      viewFrmSeason.ResetForm();
      LoadDataToGridViewSeason();
    }

    protected override string GetId() => viewFrmSeason.GetMaMua();

    protected override bool DeleteById(string id) => seasonDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
    protected override Form GetForm() => viewFrmSeason.GetForm();
  }
}
