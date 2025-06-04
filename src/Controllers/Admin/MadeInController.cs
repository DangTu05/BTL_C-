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
  internal class MadeInController : BaseController<MadeInModel>
  {
    private FrmMadeIn viewFrmMadeIn;
    private MadeInDAO madeinDao;

    protected override string EntityName => "nơi sản xuất";

    public MadeInController(FrmMadeIn viewFrmMadeIn)
    {
      this.viewFrmMadeIn = viewFrmMadeIn;
      madeinDao = new MadeInDAO();
      LoadDataToGridViewMadeIn();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmMadeIn.SetTaoListener(InsertMadeIn);
      viewFrmMadeIn.SetLamMoiListener(ResetForm);
      viewFrmMadeIn.SetLuuListener(UpdateMadeIn);
      viewFrmMadeIn.SetXoaListener(Delete);
      viewFrmMadeIn.SetMadeInCellClickListener(OnAccountCellClick);
      viewFrmMadeIn.SetThoatListener(Close);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewMadeIn()
    {
      try
      {
        DataTable dt = madeinDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmMadeIn.LoadDataToGridViewMadeIn(dv);
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
        var dgv = viewFrmMadeIn.GetDataGridViewMadeIn();
        var row = dgv.Rows[e.RowIndex];
        string mansx = row.Cells[0].Value.ToString();
        string tennsx = row.Cells[1].Value.ToString();
        viewFrmMadeIn.SetFormData(mansx, tennsx);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertMadeIn(object sender, EventArgs e)
    {

      if (!InputValidate.InputMadeInValidate(viewFrmMadeIn.GetTenNoiSanXuat()))
        return;
      try
      {
        string mansx = GenerateIdUtil.GenerateId("MADEIN");
        MadeInModel madein = new MadeInModel(mansx, viewFrmMadeIn.GetTenNoiSanXuat());
        if (!madeinDao.insert(madein))
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
    private void UpdateMadeIn(object sender, EventArgs e)
    {
      string mansx = viewFrmMadeIn.GetMaNoiSanXuat();
      string tennsx = viewFrmMadeIn.GetTenNoiSanXuat();
      if (string.IsNullOrWhiteSpace(mansx))
      {
        MessageUtil.ShowWarning("Vui lòng chọn nơi sản xuất muốn sửa!");
        return;
      }
      if (!InputValidate.InputMadeInValidate(tennsx))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        MadeInModel madein = new MadeInModel(mansx, tennsx);
        if (!madeinDao.update(madein))
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
      viewFrmMadeIn.ResetForm();
      LoadDataToGridViewMadeIn();
    }

    protected override string GetId() => viewFrmMadeIn.GetMaNoiSanXuat();

    protected override bool DeleteById(string id) => madeinDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
    protected override Form GetForm() => viewFrmMadeIn.GetForm();
  }
}