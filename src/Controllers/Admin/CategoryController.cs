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
  internal class CategoryController : BaseController<CategoryModel>
  {
    private FrmCategory viewFrmCategory;
    private CategoryDAO categoryDao;

    protected override string EntityName => "thể loại";

    public CategoryController(FrmCategory viewFrmCategory)
    {
      this.viewFrmCategory = viewFrmCategory;
      categoryDao = new CategoryDAO();
      LoadDataToGridViewCategory();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmCategory.SetTaoListener(InsertCategory);
      viewFrmCategory.SetLamMoiListener(ResetForm);
      viewFrmCategory.SetLuuListener(UpdateCategory);
      viewFrmCategory.SetXoaListener(Delete);
      viewFrmCategory.SetCategoryCellClickListener(OnAccountCellClick);
      viewFrmCategory.SetThoatListener(Close);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewCategory()
    {
      try
      {
        DataTable dt = categoryDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmCategory.LoadDataToGridViewCategory(dv);
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
        var dgv = viewFrmCategory.GetDataGridViewCategory();
        var row = dgv.Rows[e.RowIndex];
        string matl = row.Cells[0].Value.ToString();
        string tentl = row.Cells[1].Value.ToString();
        viewFrmCategory.SetFormData(matl, tentl);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertCategory(object sender, EventArgs e)
    {

      if (!InputValidate.InputCategoryValidate(viewFrmCategory.GetTenTheLoai()))
        return;
      try
      {
        string matl = GenerateIdUtil.GenerateId("CATEGORY");
        CategoryModel category = new CategoryModel(matl, viewFrmCategory.GetTenTheLoai());
        if (!categoryDao.insert(category))
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
    private void UpdateCategory(object sender, EventArgs e)
    {
      string matl = viewFrmCategory.GetMaTheLoai();
      string tentl = viewFrmCategory.GetTenTheLoai();
      if (string.IsNullOrWhiteSpace(matl))
      {
        MessageUtil.ShowWarning("Vui lòng chọn thể loại muốn sửa!");
        return;
      }
      if (!InputValidate.InputCategoryValidate(tentl))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        CategoryModel category = new CategoryModel(matl, tentl);
        if (!categoryDao.update(category))
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
      viewFrmCategory.ResetForm();
      LoadDataToGridViewCategory();
    }

    protected override string GetId() => viewFrmCategory.GetMaTheLoai();

    protected override bool DeleteById(string id) => categoryDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
    protected override Form GetForm() => viewFrmCategory.GetForm();
  }
}