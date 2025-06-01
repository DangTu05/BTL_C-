using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal class MaterialController : BaseController<MaterialModel>
  {
    private FrmMaterial viewFrmMaterial;
    private MaterialDAO materialDao;

    protected override string EntityName => "chất liệu";

    public MaterialController(FrmMaterial viewFrmMaterial)
    {
      this.viewFrmMaterial = viewFrmMaterial;
      materialDao = new MaterialDAO();
      LoadDataToGridViewMaterial();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmMaterial.SetTaoListener(InsertMaterial);
      viewFrmMaterial.SetLamMoiListener(ResetForm);
      viewFrmMaterial.SetLuuListener(UpdateMaterial);
      viewFrmMaterial.SetXoaListener(Delete);
      viewFrmMaterial.SetMaterialCellClickListener(OnAccountCellClick);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewMaterial()
    {
      try
      {
        DataTable dt = materialDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmMaterial.LoadDataToGridViewMaterial(dv);
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
        var dgv = viewFrmMaterial.GetDataGridViewMaterial();
        var row = dgv.Rows[e.RowIndex];
        string macl = row.Cells[0].Value.ToString();
        string tencl = row.Cells[1].Value.ToString();
        viewFrmMaterial.SetFormData(macl, tencl);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertMaterial(object sender, EventArgs e)
    {

      if (!InputValidate.inputMaterialValidate(viewFrmMaterial.GetTenChatLieu()))
        return;
      try
      {
        string macl = GenerateIdUtil.GenerateId("MATERIAL");
        MaterialModel material = new MaterialModel(macl, viewFrmMaterial.GetTenChatLieu());
        if (!materialDao.insert(material))
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
    private void UpdateMaterial(object sender, EventArgs e)
    {
      string macl = viewFrmMaterial.GetMaChatLieu();
      string tencl = viewFrmMaterial.GetTenChatLieu();
      if (string.IsNullOrWhiteSpace(macl))
      {
        MessageUtil.ShowWarning("Vui lòng chọn màu muốn sửa!");
        return;
      }
      if (!InputValidate.inputMaterialValidate(tencl))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        MaterialModel material = new MaterialModel(macl, tencl);
        if (!materialDao.update(material))
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
      viewFrmMaterial.ResetForm();
      LoadDataToGridViewMaterial();
    }

    protected override string GetId() => viewFrmMaterial.GetMaChatLieu();

    protected override bool DeleteById(string id) => materialDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
  }
}