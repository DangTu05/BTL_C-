using BTL_C_.Configs;
using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class ReportDAO
  {
    public List<SalesInvoiceReportModel> LoadSaleReportData(DateTime? ngayBatDau = null, DateTime? ngayKetThuc = null)
    {
      List<SalesInvoiceReportModel> salesData = new List<SalesInvoiceReportModel>();
      using (SqlConnection conn = ConfigDB.GetConnection())
      {
        if (conn == null) return new List<SalesInvoiceReportModel>();
        try
        {
          conn.Open();
          // Câu lệnh SQL để lấy dữ liệu hóa đơn bán hàng với các JOIN và điều kiện lọc.
          string query = @"
                        SELECT
                            hdb.sohdb,
                            hdb.manv,
                            nv.tennv,
                            hdb.ngayban,
                            hdb.makh,
                            kh.tenkh,
                            hdb.tongtien
                        FROM
                            tblHoaDonBan hdb
                        LEFT JOIN
                            tblNhanVien nv ON hdb.manv = nv.manv
                        LEFT JOIN
                            tblKhachHang kh ON hdb.makh = kh.makh
                        WHERE
                            (@NgayBatDau IS NULL OR hdb.ngayban >= @NgayBatDau) AND
                            (@NgayKetThuc IS NULL OR hdb.ngayban <= @NgayKetThuc) AND hdb.deleted=0
                        ORDER BY hdb.ngayban DESC;";

          using (SqlCommand cmd = new SqlCommand(query, conn))
          {
            // Thêm các tham số vào câu lệnh SQL để tránh SQL Injection và xử lý giá trị NULL.
            cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau.HasValue ? (object)ngayBatDau.Value.Date : DBNull.Value);
            cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc.HasValue ? (object)ngayKetThuc.Value.Date : DBNull.Value);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
              while (reader.Read())
              {
                salesData.Add(new SalesInvoiceReportModel
                {
                  So_HDB = reader["sohdb"] != DBNull.Value ? reader["sohdb"].ToString() ?? string.Empty : string.Empty,
                  Ma_NV = reader["manv"] != DBNull.Value ? reader["manv"].ToString() ?? string.Empty : string.Empty,
                  Ten_NV = reader["tennv"] != DBNull.Value ? reader["tennv"].ToString() ?? string.Empty : string.Empty,
                  Ngay_ban = reader["ngayban"] != DBNull.Value ? Convert.ToDateTime(reader["ngayban"]) : default,
                  Ma_KH = reader["makh"] != DBNull.Value ? reader["makh"].ToString() ?? string.Empty : string.Empty,
                  Ten_KH = reader["tenkh"] != DBNull.Value ? reader["tenkh"].ToString() ?? string.Empty : string.Empty,
                  Tong_tien = reader["tongtien"] != DBNull.Value ? Convert.ToDecimal(reader["tongtien"]) : 0
                });
              }
            }
          }
          return salesData;
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi truy vấn", ex);
        }
      }
    }
    public List<EmployeeSalesModel> FindBestPerformingEmployee(int month, int year)
    {
      List<EmployeeSalesModel> employeeSales = new List<EmployeeSalesModel>();
      using (SqlConnection conn = ConfigDB.GetConnection())
      {


        try
        {
          conn.Open();
          // Lấy ngày bắt đầu và kết thúc của tháng/năm được chọn
          DateTime startDate = new DateTime(year, month, 1);
          DateTime endDate = startDate.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng

          string query = @"
                        SELECT
                            nv.manv,
                            nv.tennv,
                            SUM(hdb.tongtien) AS TongDoanhSo
                        FROM
                            tblHoaDonBan hdb
                        JOIN
                            tblNhanVien nv ON hdb.manv = nv.manv
                        WHERE
                            hdb.ngayban >= @StartDate AND hdb.ngayban <= @EndDate
                        GROUP BY
                            nv.manv, nv.tennv
                        ORDER BY
                            TongDoanhSo DESC;"; // Sắp xếp giảm dần để lấy người có doanh số cao nhất

          using (SqlCommand cmd = new SqlCommand(query, conn))
          {
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
              while (reader.Read())
              {
                employeeSales.Add(new EmployeeSalesModel
                {
                  Ma_NV = reader["manv"] != DBNull.Value ? reader["manv"].ToString() : string.Empty,
                  Ten_NV = reader["tennv"] != DBNull.Value ? reader["tennv"].ToString() : string.Empty,
                  TongDoanhSo = reader["TongDoanhSo"] != DBNull.Value ? Convert.ToDecimal(reader["TongDoanhSo"]) : 0
                });
              }
            }
          }

          return employeeSales;
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi truy vấn trong DAO!!!", ex);
        }
      }
    }
  }
}
