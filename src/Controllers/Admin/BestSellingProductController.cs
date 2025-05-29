using BTL_C_.src.DAO;
using BTL_C_.src.Utils;
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
  internal class BestSellingProductController
  {
    private BestSellingProductControl viewBestSellingProductControl;
    private ProductDAO productDao;
    public BestSellingProductController(BestSellingProductControl viewBestSellingProductControl)
    {
      this.viewBestSellingProductControl = viewBestSellingProductControl;
      productDao = new ProductDAO();
      setupEventListeners();
    }
    private void setupEventListeners()
    {
      viewBestSellingProductControl.SetTimKiemListener(TimKiem);
    }
    private void TimKiem(object sender, EventArgs e)
    {
      DateTime ngayBatDau = viewBestSellingProductControl.GetNgayBatDau();
      DateTime ngayKetThuc = viewBestSellingProductControl.GetNgayKetThuc();

      if (ngayBatDau > ngayKetThuc)
      {
        MessageUtil.ShowWarning("Ngày bắt đầu không được phép lớn hơn ngày kết thúc!");
        return;
      }
      try
      {
        DataTable dt = productDao.GetSanPhamBanChay(ngayBatDau, ngayKetThuc);
        viewBestSellingProductControl.GetDataGridView().DataSource = dt;

        // Tính tổng số lượng bán và tổng tiền
        int tongSoLuong = 0;
        decimal tongTien = 0;

        foreach (DataRow row in dt.Rows)
        {
          tongSoLuong += Convert.ToInt32(row["SoLuongBan"]);
          tongTien += Convert.ToDecimal(row["TongTien"]);
        }

        // Hiển thị thông tin tổng
        viewBestSellingProductControl.SetTongSoLuong($"Tổng số lượng bán: {tongSoLuong}");
        viewBestSellingProductControl.SetTongTien($"Tổng doanh thu: {tongTien:N0} VNĐ");
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
  }
}
