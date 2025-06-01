using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace BTL_C_.src.Controllers.Admin
{
  internal class DemographicController : BaseController<DemographicModel>
  {
    private FrmDemographic frmDemographic;
    private DemographicDAO demographicDAO;

    protected override string EntityName => "đối tượng";

    public DemographicController(FrmDemographic frmDemographic)
    {
      this.frmDemographic = frmDemographic;
      demographicDAO = new DemographicDAO();
      LoadDataToGridViewObject();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      frmDemographic.SetTaoListener(InsertObject);
      frmDemographic.SetLamMoiListener(ResetForm);
      frmDemographic.SetLuuListener(UpdateObject);
      frmDemographic.SetXoaListener(Delete);
      frmDemographic.SetObjectCellClickListener(OnAccountCellClick);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewObject()
    {
      try
      {
        DataTable dt = demographicDAO.getAllRecord();
        DataView dv = new DataView(dt);
        frmDemographic.LoadDataToGridViewObject(dv);
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
        var dgv = frmDemographic.GetDataGridViewObject();
        var row = dgv.Rows[e.RowIndex];
        string madt = row.Cells[0].Value.ToString();
        string tendt = row.Cells[1].Value.ToString();
        frmDemographic.SetFormData(madt, tendt);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertObject(object sender, EventArgs e)
    {

      if (!InputValidate.InputObjectValidate(frmDemographic.GetTenDoiTuong()))
        return;
      try
      {
        string madt = GenerateIdUtil.GenerateId("OBJECT");
        DemographicModel obj = new DemographicModel(madt, frmDemographic.GetTenDoiTuong());
        if (!demographicDAO.insert(obj))
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
    private void UpdateObject(object sender, EventArgs e)
    {
      string madt = frmDemographic.GetMaDoiTuong();
      string tendt = frmDemographic.GetTenDoiTuong();
      if (string.IsNullOrWhiteSpace(madt))
      {
        MessageUtil.ShowWarning("Vui lòng chọn đối tượng muốn sửa!");
        return;
      }
      if (!InputValidate.InputObjectValidate(tendt))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        DemographicModel obj = new DemographicModel(madt, tendt);
        if (!demographicDAO.update(obj))
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
      frmDemographic.ResetForm();
      LoadDataToGridViewObject();
    }

    protected override string GetId() => frmDemographic.GetMaDoiTuong();

    protected override bool DeleteById(string id) => demographicDAO.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
  }
}
