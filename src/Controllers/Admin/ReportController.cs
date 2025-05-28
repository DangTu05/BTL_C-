using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
      viewReportControl.SetKhenThuongListener(KhenThuong);
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
    /// <summary>
    /// Xử lý sự kiện click cho nút "Khen Thưởng NV Xuất Sắc".
    /// Hiển thị một hộp thoại cho phép người dùng chọn tháng/năm để tìm nhân viên xuất sắc.
    /// </summary>

    private void KhenThuong(object sender, EventArgs e)
    {
      if (viewReportControl.OpenDialogBox(out int month, out int year))
      {
        FindBestPerformingEmployee(month, year);
      }
    }
    /// <summary>
    /// Tìm nhân viên có doanh số cao nhất trong một tháng/năm cụ thể và hiển thị kết quả.
    /// </summary>
    /// <param name="month">Tháng cần tìm kiếm.</param>
    /// <param name="year">Năm cần tìm kiếm.</param>
    private void FindBestPerformingEmployee(int month, int year)
    {
      List<EmployeeSalesModel> employeeSales = new List<EmployeeSalesModel>();
      try
      {
        employeeSales = reportDao.FindBestPerformingEmployee(month, year);
        if (employeeSales.Any())
        {
          // Lấy nhân viên có doanh số cao nhất (có thể có nhiều người cùng cao nhất)
          decimal maxSales = employeeSales.First().TongDoanhSo;
          var bestEmployees = employeeSales.Where(e => e.TongDoanhSo == maxSales).ToList();

          if (bestEmployees.Count == 1)
          {
            viewReportControl.SetKetQuaNVXuatSac($"NV xuất sắc tháng {month}/{year}: {bestEmployees[0].Ten_NV} ({bestEmployees[0].Ma_NV}) - Doanh số: {bestEmployees[0].TongDoanhSo:N0} VND");
          }
          else
          {
            string employeeInfo = string.Join("; ", bestEmployees.Select(e => $"{e.Ten_NV} ({e.Ma_NV})"));
            viewReportControl.SetKetQuaNVXuatSac($"Các NV xuất sắc tháng {month}/{year}: {employeeInfo} - Doanh số: {maxSales:N0} VND");
          }
        }
        else
        {
          viewReportControl.SetKetQuaNVXuatSac($"Không có doanh số trong tháng {month}/{year}.");
        }
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi truy vấn nhân viên được khen thưởng!!!");
      }

    }
  }
}
