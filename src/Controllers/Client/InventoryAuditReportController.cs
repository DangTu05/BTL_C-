using BTL_C_.src.DAO;
using BTL_C_.src.Utils;
using BTL_C_.src.Views.Client;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Client
{
  internal class InventoryAuditReportController
  {
    private FrmInventoryAuditReport frmInventoryAuditReport;
    private InventoryAuditReportDAO inventoryAuditReportDao;
    public InventoryAuditReportController(FrmInventoryAuditReport frmInventoryAuditReport)
    {
      this.frmInventoryAuditReport = frmInventoryAuditReport;
      inventoryAuditReportDao = new InventoryAuditReportDAO();
      frmInventoryAuditReport.SetTimKiemListener(TimKiem);
      frmInventoryAuditReport.SetXuatExcelListener(XuatExcel);
      frmInventoryAuditReport.SetThoatListener(RedirectFrmHome);

    }
    private void TimKiem(object sender, EventArgs e)
    {
      try
      {
        DateTime? startDate = frmInventoryAuditReport.GetStartDate();
        DateTime? endDate = frmInventoryAuditReport.GetEndDate();

        // Đảm bảo ngày kết thúc không nhỏ hơn ngày bắt đầu
        if (startDate.HasValue && endDate.HasValue && startDate.Value > endDate.Value)
        {
          MessageUtil.ShowWarning("Ngày bắt đầu không được phép lớn hơn ngày kết thúc!");
          return;
        }
        DataTable dt = inventoryAuditReportDao.GetData(startDate, endDate);
        DataView dv = new DataView(dt);
        frmInventoryAuditReport.LoadDataToGridView(dv);

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy lỗi khi tìm kiếm!!!");
      }
    }
    private void XuatExcel(object sender, EventArgs e)
    {
      try
      {
        DataGridView dgv = frmInventoryAuditReport.GetDataGridViewInventory();
        if (dgv.Rows.Count == 0)
        {
          MessageUtil.ShowWarning("Không có dữ liệu nào để xuất ra excel!");
          return;
        }
        ExcelUtil.Export(dgv, "ChiTietHoaDonNhap");
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Xuất ra file excel thất bại!!!");
      }
    }
    private void RedirectFrmHome(object sender, EventArgs e)
    {
      AppController.StartHomeClient(frmInventoryAuditReport.GetForm());
    }
  }
}
