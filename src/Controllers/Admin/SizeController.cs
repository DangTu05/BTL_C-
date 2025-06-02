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
  internal class SizeController : BaseController<SizeModel>
  {
    private FrmSize viewFrmSize;
    private SizeDAO sizeDao;

    protected override string EntityName => "cỡ";

    public SizeController(FrmSize viewFrmSize)
    {
      this.viewFrmSize = viewFrmSize;
      sizeDao = new SizeDAO();
      LoadDataToGridViewSize();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmSize.SetTaoListener(InsertSize);
      viewFrmSize.SetLamMoiListener(ResetForm);
      viewFrmSize.SetLuuListener(UpdateSize);
      viewFrmSize.SetXoaListener(Delete);
      viewFrmSize.SetSizeCellClickListener(OnAccountCellClick);
      viewFrmSize.SetThoatListener(Close);
    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewSize()
    {
      try
      {
        DataTable dt = sizeDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmSize.LoadDataToGridViewSize(dv);
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
        var dgv = viewFrmSize.GetDataGridViewSize();
        var row = dgv.Rows[e.RowIndex];
        string maco = row.Cells[0].Value.ToString();
        string tenco = row.Cells[1].Value.ToString();
        viewFrmSize.SetFormData(maco, tenco);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertSize(object sender, EventArgs e)
    {

      if (!InputValidate.InputSizeValidate(viewFrmSize.GetTenCo()))
        return;
      try
      {
        string maco = GenerateIdUtil.GenerateId("SIZE");
        SizeModel size = new SizeModel(maco, viewFrmSize.GetTenCo());
        if (!sizeDao.insert(size))
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
    private void UpdateSize(object sender, EventArgs e)
    {
      string maco = viewFrmSize.GetMaCo();
      string tenco = viewFrmSize.GetTenCo();
      if (string.IsNullOrWhiteSpace(maco))
      {
        MessageUtil.ShowWarning("Vui lòng chọn cỡ muốn sửa!");
        return;
      }
      if (!InputValidate.InputSizeValidate(tenco))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        SizeModel size = new SizeModel(maco, tenco);
        if (!sizeDao.update(size))
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
      viewFrmSize.ResetForm();
      LoadDataToGridViewSize();
    }

    protected override string GetId() => viewFrmSize.GetMaCo();

    protected override bool DeleteById(string id) => sizeDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
    protected override Form GetForm() => viewFrmSize.GetForm();
  }
}