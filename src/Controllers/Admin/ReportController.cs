using BTL_C_.src.DAO;
using BTL_C_.src.Utils;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal class ReportController
  {
    private ReportControl viewReportControl;
    private ReportDAO reportDao;
    public ReportController(ReportControl viewReportControl)
    {
      this.viewReportControl = viewReportControl;
      reportDao = new ReportDAO();
      setupEventListeners();
    }
    private void setupEventListeners()
    {
      viewReportControl.SetTimKiemListener(LoadDataToGridViewSaleReport);
      viewReportControl.SetXuatExxcelListener(XuatExcel);
    }
    private void LoadDataToGridViewSaleReport(object sender, EventArgs e)
    {
      try
      {
        DateTime ngayBatDau = viewReportControl.GetNgayBatDau();
        DateTime ngayKetThuc = viewReportControl.GetNgayKetThuc();
        viewReportControl.LoadDataToGridView(reportDao.LoadSaleReportData(ngayBatDau, ngayKetThuc));
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    private void XuatExcel(object sender, EventArgs e)
    {
      DataGridView dvgSaleReport = viewReportControl.GetDataGridView();
      ExcelUtil.Export(dvgSaleReport, "HoaDonBan");
    }

  }
}
