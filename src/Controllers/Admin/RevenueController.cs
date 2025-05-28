using BTL_C_.src.DAO;
using BTL_C_.src.Models;
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
  internal class RevenueController : BaseController<RevenueModel>
  {
    private RevenueDAO revenueDao;
    private RevenueControl viewRevenueControl;

    protected override string EntityName => "hóa đơn";

    public RevenueController(RevenueControl viewRevenueControl)
    {
      this.viewRevenueControl = viewRevenueControl;
      revenueDao = new RevenueDAO();
      LoadDataToGridViewRevenue();
      setupEventListener();
    }
    private void LoadDataToGridViewRevenue()
    {
      try
      {
        DataTable dt = revenueDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewRevenueControl.LoadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void setupEventListener()
    {
      viewRevenueControl.SetTimListener(FindRevenueByDate);
      viewRevenueControl.SetTinhTongListener(TinhTong);
      viewRevenueControl.SetXoaListener(Delete);
      viewRevenueControl.SetLamMoiListener(Reset);
      viewRevenueControl.SetRevenueCellClickListener(OnRevenueCellClick);
    }
    private void FindRevenueByDate(object sender, EventArgs e)
    {
      try
      {
        int thang = viewRevenueControl.GetDate().Month;
        int nam = viewRevenueControl.GetDate().Year;
        DataTable dt = revenueDao.GetDoanhThuTheoThangNam(thang, nam);
        DataView dv = new DataView(dt);
        viewRevenueControl.LoadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void TinhTong(object sender, EventArgs e)
    {
      try
      {
        int thang = viewRevenueControl.GetDate().Month;
        int nam = viewRevenueControl.GetDate().Year;
        decimal tong = revenueDao.GetTongDoanhThu(thang, nam);
        viewRevenueControl.SetTongDoanhThu($"Tổng doanh thu tháng {thang} năm {nam} là: {tong} VNĐ");
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void OnRevenueCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridView dgv = viewRevenueControl.GetDataGridViewRevenue();
        var row = dgv.Rows[e.RowIndex];
        string sohdb = row.Cells[0].Value.ToString();
        viewRevenueControl.SetFormData(sohdb);
      }
    }
    private void Reset(object sender, EventArgs e)
    {
      viewRevenueControl.ResetForm();
      LoadDataToGridViewRevenue();
    }

    protected override string GetId() => viewRevenueControl.GetSoHDB();

    protected override bool DeleteById(string id) => revenueDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => Reset(sender, e);
  }
}
