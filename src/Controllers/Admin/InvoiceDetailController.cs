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
  internal class InvoiceDetailController
  {
    private InvoiceDetailControl viewInvoiceDetailControl;
    private InvoiceDetailDAO invoiceDetailDao;
    private DataTable dtChiTietHoaDonBan;

    public InvoiceDetailController(InvoiceDetailControl viewInvoiceDetailControl)
    {
      this.viewInvoiceDetailControl = viewInvoiceDetailControl;
      invoiceDetailDao = new InvoiceDetailDAO();
      LoadDataToGridViewInvoiceDetail();
      SetupEventListeners();
    }

    private void SetupEventListeners()
    {
      viewInvoiceDetailControl.SetTaiLaiListener(Reset);
      viewInvoiceDetailControl.SetXoaCTHDBListener(DeleteInvoiceDetail);
      viewInvoiceDetailControl.SetXuatExcelListener(XuatExcel);
      viewInvoiceDetailControl.SetTinKiemListener(TimKiem);
      viewInvoiceDetailControl.SetInvoiceDetailCellClickListener(OnInvoiceDetailCellClick);
      viewInvoiceDetailControl.SetSaleInvoiceCellClickListener(OnSaleInvoiceCellClick);
    }

    private void LoadDataToGridViewInvoiceDetail()
    {
      try
      {
        DataSet ds = invoiceDetailDao.getData();
        dtChiTietHoaDonBan = ds.Tables["tblChiTietHoaDonBan"];
        viewInvoiceDetailControl.LoadDataToGridView(ds);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi !!!");
      }
    }
    private void OnInvoiceDetailCellClick(object sender, DataGridViewCellEventArgs e)
    {

      if (e.RowIndex >= 0)
      {
        DataGridView dgv = viewInvoiceDetailControl.GetDataGridViewCTHDB();
        var row = dgv.Rows[e.RowIndex];
        string mahdb = row.Cells[0].Value.ToString();
        string masp = row.Cells[1].Value.ToString();
        decimal dongia = row.Cells[3].Value != null ? Convert.ToDecimal(row.Cells[3].Value) : 0m;
        decimal thanhtien = row.Cells[5].Value != null ? Convert.ToDecimal(row.Cells[5].Value) : 0m;
        decimal giamgia = row.Cells[4].Value != null ? Convert.ToDecimal(row.Cells[4].Value) : 0m;
        int soluong = row.Cells[2].Value != null ? Convert.ToInt32(row.Cells[2].Value) : 0;
        viewInvoiceDetailControl.SetFormDataCTHDB(mahdb, masp, dongia, thanhtien, giamgia, soluong);

      }
    }
    private void OnSaleInvoiceCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridView dgv = viewInvoiceDetailControl.GetDataGridViewHDB();
        var row = dgv.Rows[e.RowIndex];
        string sohdb = row.Cells[0].Value.ToString();
        string manv = row.Cells[1].Value.ToString();
        string makh = row.Cells[2].Value.ToString();
        DateTime ngayban = row.Cells[3].Value != null ? Convert.ToDateTime(row.Cells[3].Value) : DateTime.Now;
        decimal tongtien = row.Cells[4].Value != null ? Convert.ToDecimal(row.Cells[4].Value) : 0m;
        viewInvoiceDetailControl.SetFormDataHDB(sohdb, manv, makh, ngayban, tongtien);
      }
    }
    private void Reset(object sender, EventArgs e)
    {
      viewInvoiceDetailControl.ResetForm();
      LoadDataToGridViewInvoiceDetail();
    }
    private void DeleteInvoiceDetail(object sender, EventArgs e)
    {
      string sohdb = viewInvoiceDetailControl.GetSoHDB();
      string masp = viewInvoiceDetailControl.GetMaSP();
      if (string.IsNullOrWhiteSpace(sohdb) || string.IsNullOrWhiteSpace(masp))
      {
        MessageUtil.ShowWarning("Vui lòng chọn chi tiết hóa đơn muốn xóa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có chắc chắn muốn xóa?"))
        return;
      try
      {
        if (!invoiceDetailDao.delete(sohdb, masp))
        {
          MessageUtil.ShowError("Xóa thất bại!!!");
          return;
        }
        invoiceDetailDao.CapNhatTongTienHoaDon(sohdb);
        MessageUtil.ShowInfo("Đã xóa thành công!");
        Reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi xóa!!!");
      }
    }
    private void XuatExcel(object sender, EventArgs e)
    {
      DataGridView dvgInvoiceDetail = viewInvoiceDetailControl.GetDataGridViewCTHDB();
      ExcelUtil.Export(dvgInvoiceDetail, "ChiTietHoaDonBan");
    }
    private void TimKiem(object sender, EventArgs e)
    {
      string keyword = viewInvoiceDetailControl.GetTimKiem();
      if (string.IsNullOrEmpty(keyword))
      {
        viewInvoiceDetailControl.GetDataGridViewCTHDB().DataSource = dtChiTietHoaDonBan;
      }
      else
      {
        DataView dv = dtChiTietHoaDonBan.DefaultView;
        dv.RowFilter = $"sohdb LIKE '%{keyword}%' OR maQuanAo LIKE '%{keyword}%'";
        viewInvoiceDetailControl.GetDataGridViewCTHDB().DataSource = dv.ToTable();
      }
    }
  }
}
