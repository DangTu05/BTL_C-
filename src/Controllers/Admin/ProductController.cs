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
  internal class ProductController : BaseController<ProductModel>
  {
    private FrmCreateProduct viewFrmCreateProduct;
    private ProductControl viewProductControl;
    private ProductDAO productDao;

    protected override string EntityName => "sản phẩm";

    public ProductController(FrmCreateProduct viewFrmCreateProduct)
    {
      this.viewFrmCreateProduct = viewFrmCreateProduct;
      productDao = new ProductDAO();
      FindDataToCmbCreateProduct();
      viewFrmCreateProduct.SetTaoListener(InsertProduct);
    }
    public ProductController(ProductControl viewProductControl)
    {
      this.viewProductControl = viewProductControl;
      productDao = new ProductDAO();
      LoadDataToGridView();
      FindDataToCmbProductControl();
      SetupEventListeners();
    }
    private void SetupEventListeners()
    {
      viewProductControl.SetProductCellClickListener(OnProductCellClick);
      viewProductControl.SetLamMoiListener(Reset);
      viewProductControl.SetLuuListener(UpdateProduct);
      viewProductControl.SetXoaListener(Delete);
      viewProductControl.SetTaoListener(RedirectFrmCreateProduct);
      viewProductControl.SetTimListener(FindRecordsBySearch);
    }
    private void FindDataToCmbCreateProduct()
    {
      CategoryDAO.fillCategoryCombo(viewFrmCreateProduct.GetCmbTheLoai());
      SizeDAO.fillSizeCombo(viewFrmCreateProduct.GetCmbCo());
      MadeInDAO.fillMadeInCombo(viewFrmCreateProduct.GetCmbNoiSanXuat());
      MaterialDAO.fillMaterialCombo(viewFrmCreateProduct.GetCmbChatLieu());
      SeasonDAO.fillSeasonCombo(viewFrmCreateProduct.GetCmbMua());
      ColorDAO.fillColorCombo(viewFrmCreateProduct.GetCmbMau());
      DemographicDAO.fillDemographicCombo(viewFrmCreateProduct.GetCmbDoiTuong());
    }

    private void FindDataToCmbProductControl()
    {
      CategoryDAO.fillCategoryCombo(viewProductControl.GetCmbTheLoai());
      SizeDAO.fillSizeCombo(viewProductControl.GetCmbCo());
      MadeInDAO.fillMadeInCombo(viewProductControl.GetCmbNoiSanXuat());
      MaterialDAO.fillMaterialCombo(viewProductControl.GetCmbChatLieu());
      SeasonDAO.fillSeasonCombo(viewProductControl.GetCmbMua());
      ColorDAO.fillColorCombo(viewProductControl.GetCmbMau());
      DemographicDAO.fillDemographicCombo(viewProductControl.GetCmbDoiTuong());
    }
    private void InsertProduct(object sender, EventArgs e)
    {
      string maquanao = GenerateIdUtil.GenerateId("PRODUCT");
      if (!InputValidate.inputCreateProductValidate(maquanao, viewFrmCreateProduct.GetTenSanPham(), viewFrmCreateProduct.GetTrangThai()))
      {
        return;
      }
      ProductModel product = new ProductModel(
          maquanao,
          viewFrmCreateProduct.GetTenSanPham(),
          viewFrmCreateProduct.GetMaCo(),
          viewFrmCreateProduct.GetMaMau(),
          viewFrmCreateProduct.GetMaMua(),
          viewFrmCreateProduct.GetMaDoiTuong(),
          viewFrmCreateProduct.GetMaNoiSanXuat(),
          viewFrmCreateProduct.GetMaTheLoai(),
          viewFrmCreateProduct.GetMaChatLieu(),
          viewFrmCreateProduct.GetSoLuongTonKho(),
          "", // đường dẫn ảnh để trống
          viewFrmCreateProduct.GetDonGiaNhap(),
          //viewFrmCreateProduct.GetDonGiaBan(),
          1000,
          viewFrmCreateProduct.GetTrangThai()
      );
      try
      {
        if (!productDao.insert(product))
        {
          MessageUtil.ShowError("Tạo thất bại!!!");
          return;
        }
        MessageUtil.ShowInfo("Tạo thành công!");
        AppController.startDashBoard(viewFrmCreateProduct.GetForm());

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
      }

    }
    private void OnProductCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewProductControl.GetDataGridViewProduct();
        var row = dgv.Rows[e.RowIndex];
        string masanpham = row.Cells[0].Value?.ToString() ?? "";
        string tensanpham = row.Cells[1].Value?.ToString() ?? "";
        string theloai = row.Cells[2].Value?.ToString() ?? "";
        string mau = row.Cells[3].Value?.ToString() ?? "";
        string nsx = row.Cells[4].Value?.ToString() ?? "";
        string dt = row.Cells[5].Value?.ToString() ?? "";
        string mua = row.Cells[6].Value?.ToString() ?? "";
        string cl = row.Cells[7].Value?.ToString() ?? "";
        string co = row.Cells[8].Value?.ToString() ?? "";
        int sltonkho = 1; // Default value
        if (row.Cells[9].Value != null && int.TryParse(row.Cells[10].Value.ToString(), out int result))
        {
          sltonkho = result;
        }
        string anh = row.Cells[10].Value?.ToString() ?? "";
        float dongianhap;
        if (!float.TryParse(row.Cells[11].Value?.ToString(), out dongianhap))
        {
          dongianhap = 1f; // giá trị mặc định nếu lỗi
        }
        float dongiaban;
        if (!float.TryParse(row.Cells[12].Value?.ToString(), out dongiaban))
        {
          dongiaban = 1f;
        }


        string trangthai = row.Cells[13].Value?.ToString() ?? "";
        viewProductControl.SetForm(masanpham, tensanpham, theloai, cl, mau, dt, mua, nsx, co, sltonkho, dongianhap, dongiaban, anh, trangthai);
      }
    }
    private void LoadDataToGridView()
    {
      DataTable allProduct = productDao.getAllRecord();

      // Tạo DataView từ DataTable và lọc theo vai trò
      DataView dv = new DataView(allProduct);
      viewProductControl.LoadDataToGridView(dv);

    }
    private void Reset(object sender, EventArgs e)
    {
      viewProductControl.ResetForm();
      LoadDataToGridView();
    }
    private void UpdateProduct(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(viewProductControl.GetMaSanPham()))
      {
        MessageUtil.ShowWarning("Vui lòng chọn sản phẩm muốn sửa!");
        return;
      }
      if (!InputValidate.inputCreateProductValidate(viewProductControl.GetMaSanPham(), viewProductControl.GetTenSanPham(), viewFrmCreateProduct.GetTrangThai()))
      {
        return;
      }

      try
      {
        ProductModel product = new ProductModel(viewProductControl.GetMaSanPham(), viewProductControl.GetTenSanPham(), viewProductControl.GetMaCo(), viewProductControl.GetMaMau(), viewProductControl.GetMaMua(), viewProductControl.GetMaDoiTuong(), viewProductControl.GetMaNoiSanXuat(), viewProductControl.GetMaTheLoai(), viewProductControl.GetMaChatLieu(), viewProductControl.GetSoLuongTonKho(), viewProductControl.GetAnh(), viewProductControl.GetDonGiaNhap(), viewProductControl.GetDonGiaBan(), viewProductControl.GetTrangThai());
        if (!productDao.update(product))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        LoadDataToGridView();
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }

    private void FindRecordsBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = productDao.findRecordsByName("tenquanao", viewProductControl.GetTextSearch());
        viewProductControl.GetDataGridViewProduct().DataSource = dv; // Hiển thị danh sách đã lọc
        viewProductControl.LoadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
    private void RedirectFrmCreateProduct(object sender, EventArgs e)
    {
      AppController.startFrmCreateProduct(viewProductControl.GetForm());
    }

    protected override string GetId() => viewProductControl.GetMaSanPham();

    protected override bool DeleteById(string id) => productDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => Reset(sender, e);
  }
}
