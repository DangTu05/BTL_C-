using BTL_C_.Configs;
using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
  internal class RevenueDAO : BaseDAO<RevenueModel>
  {
    public DataTable GetDoanhThuTheoThangNam(int thang, int nam)
    {
      try
      {
        using (SqlConnection conn = ConfigDB.GetConnection())
        {
          conn.Open();
          string query = @"
            SELECT 
                sohdb,
                manv,
                hdb.makh, 
                kh.tenkh, 
                ngayban,
                tongtien
            FROM tblKhachHang kh
            JOIN tblHoaDonBan hdb ON kh.makh = hdb.makh
            WHERE MONTH(hdb.ngayban) = @Thang 
              AND YEAR(hdb.ngayban) = @Nam
            ORDER BY hdb.ngayban";


          using (var command = new SqlCommand(query, conn))
          {
            command.Parameters.AddWithValue("@Thang", thang);
            command.Parameters.AddWithValue("@Nam", nam);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
      }
    }
    public decimal GetTongDoanhThu(int thang, int nam)
    {
      try
      {
        using (SqlConnection conn = ConfigDB.GetConnection())
        {
          conn.Open();
          string query = @"
                        SELECT ISNULL(SUM(tongtien), 0) 
                        FROM tblHoaDonBan 
                        WHERE MONTH(ngayban) = @Thang 
                          AND YEAR(ngayban) = @Nam";

          using (var command = new SqlCommand(query, conn))
          {
            command.Parameters.AddWithValue("@Thang", thang);
            command.Parameters.AddWithValue("@Nam", nam);
            return Convert.ToDecimal(command.ExecuteScalar());
          }
        }
      }
      catch (Exception ex)
      {
        // Log the error here
        throw new ApplicationException("Đã xảy ra lỗi khi truy vấn!!!", ex);
      }
    }
    protected override string getColumns() => " sohdb, manv, hdb.makh, kh.tenkh, ngayban, tongtien ";

    protected override string getKeyColumn() => " sohdb ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }
    protected override string GetAlias() => " hdb ";
    protected override string GetTableName() => " tblKhachHang kh JOIN tblHoaDonBan hdb ON kh.makh = hdb.makh ";

    protected override RevenueModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
