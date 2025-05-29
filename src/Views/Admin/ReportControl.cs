using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class ReportControl : UserControl
  {
    public ReportControl()
    {
      InitializeComponent();
      InitializeControls();  // Khởi tạo các giá trị ban đầu cho các điều khiển.
      ConfigureDataGridView(); // Cấu hình DataGridView.
    }
    private void ConfigureDataGridView()
    {
      dvgSaleReport.AutoGenerateColumns = false; // Tắt tự động tạo cột để kiểm soát cột hiển thị.

      // Xóa tất cả các cột hiện có (nếu có) để tránh trùng lặp khi chạy lại.
      dvgSaleReport.Columns.Clear();

      // Thêm các cột vào DataGridView.
      // DataPropertyName phải khớp với tên thuộc tính trong lớp HoaDonBanReport.
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số HĐB", DataPropertyName = "So_HDB", Name = "colSoHDB" });
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã NV", DataPropertyName = "Ma_NV", Name = "colMaNV" });
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên NV", DataPropertyName = "Ten_NV", Name = "colTenNV" });
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày Bán", DataPropertyName = "Ngay_ban", Name = "colNgayBan" });
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã KH", DataPropertyName = "Ma_KH", Name = "colMaKH" });
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tên KH", DataPropertyName = "Ten_KH", Name = "colTenKH" });
      dvgSaleReport.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tổng Tiền", DataPropertyName = "Tong_tien", Name = "colTongTien" });

      // Tùy chỉnh độ rộng cột (tùy chọn)
      dvgSaleReport.Columns["colSoHDB"].Width = 100;
      dvgSaleReport.Columns["colMaNV"].Width = 80;
      dvgSaleReport.Columns["colTenNV"].Width = 120;
      dvgSaleReport.Columns["colNgayBan"].Width = 100;
      dvgSaleReport.Columns["colMaKH"].Width = 80;
      dvgSaleReport.Columns["colTenKH"].Width = 120;
      dvgSaleReport.Columns["colTongTien"].Width = 120;

      // Định dạng cột Tổng Tiền
      dvgSaleReport.Columns["colTongTien"].DefaultCellStyle.Format = "N0"; // Định dạng số không có số thập phân
      dvgSaleReport.Columns["colTongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải

      // Cho phép người dùng thay đổi kích thước cột
      foreach (DataGridViewColumn col in dvgSaleReport.Columns)
      {
        col.Resizable = DataGridViewTriState.True;
      }
    }
    private void InitializeControls()
    {
      // Đặt giá trị mặc định cho DateTimePicker là đầu và cuối tháng hiện tại.
      dateNgayBatDau.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
      dateNgayKetThuc.Value = DateTime.Now.Date; // Ngày hiện tại
    }
    public void LoadDataToGridView(List<SalesInvoiceReportModel> list)
    {
      dvgSaleReport.DataSource = list;
    }
    public bool OpenDialogBox(out int month, out int year)
    {
      month = DateTime.Now.Month;
      year = DateTime.Now.Year;

      using (Form inputForm = new Form())
      {
        ComboBox cbThang = new ComboBox() { Location = new Point(100, 17), Width = 150 };
        for (int i = 1; i <= 12; i++) cbThang.Items.Add(i);
        cbThang.SelectedIndex = DateTime.Now.Month - 1;

        TextBox txtNam = new TextBox() { Location = new Point(100, 47), Width = 150, Text = DateTime.Now.Year.ToString() };

        Button btnOK = new Button() { Text = "OK", DialogResult = DialogResult.OK };
        Button btnCancel = new Button() { Text = "Hủy", DialogResult = DialogResult.Cancel };

        inputForm.Controls.Add(cbThang);
        inputForm.Controls.Add(txtNam);
        inputForm.Controls.Add(btnOK);
        inputForm.Controls.Add(btnCancel);

        inputForm.AcceptButton = btnOK;
        inputForm.CancelButton = btnCancel;

        if (inputForm.ShowDialog() == DialogResult.OK)
        {
          month = (int)cbThang.SelectedItem;
          year = int.TryParse(txtNam.Text, out int y) ? y : DateTime.Now.Year;
          return true;
        }
        return false;
      }
    }

    public void SetTimKiemListener(EventHandler handler) => btnTimKiem.Click += handler;
    public void SetXuatExxcelListener(EventHandler handler) => btnXuatExcel.Click += handler;
    public void SetKhenThuongListener(EventHandler handler) => btnKhenThuong.Click += handler;
    public DateTime GetNgayBatDau() => dateNgayBatDau.Value;
    public DateTime GetNgayKetThuc() => dateNgayKetThuc.Value;
    public DataGridView GetDataGridView() => dvgSaleReport;
    public void SetKetQuaNVXuatSac(string ketqua) => lblKetQuaNVXuatSac.Text = ketqua;
  }
}
