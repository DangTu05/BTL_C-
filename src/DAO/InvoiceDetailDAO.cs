using BTL_C_.Configs;
using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class InvoiceDetailDAO
  {
    public DataSet getData()
    {
      using (SqlConnection conn = ConfigDB.GetConnection())
      {
        try
        {
          conn.Open();

          SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT sohdb, manv, makh, ngayban, tongtien FROM tblHoaDonBan where deleted=0", conn);
          SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT sohdb, maquanao, soluong, dongia, giamgia, thanhtien FROM tblChiTietHoaDonBan where deleted=0", conn);
          DataSet ds = new DataSet();
          adapter1.Fill(ds, "tblHoaDonBan");
          adapter2.Fill(ds, "tblChiTietHoaDonBan");
          return ds;
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
        }
      }
    }

    public bool delete(string sohdb, string masp)
    {
      string sql = $"UPDATE tblChiTietHoaDonBan SET deleted = 1 WHERE sohdb = @sohdb and maquanao=@masp";
      using (SqlConnection conn = ConfigDB.GetConnection())
      using (SqlCommand cmd = new SqlCommand(sql, conn))
      {
        try
        {
          cmd.Parameters.AddWithValue("@sohdb", sohdb);
          cmd.Parameters.AddWithValue("@masp", masp);
          conn.Open();
          return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi xóa!!!", ex);
        }
      }

    }
    //TỰ ĐỘNG CẬP NHẬT TỔNG TIỀN VÀO BẢNG hoaDonBan SAU MỖI THÊM/SỬA/XÓA CHI TIẾT
    public void CapNhatTongTienHoaDon(string maHDB)
    {
      string sql = "SELECT SUM(thanhtien) FROM tblChiTietHoaDonBan WHERE sohdb = @maHDB and deleted=0";
      using (SqlConnection conn = ConfigDB.GetConnection())
      using (SqlCommand cmd = new SqlCommand(sql, conn))
      {
        try
        {
          conn.Open();
          // Tính tổng thanhTien các dòng trong chiTietHDBan theo mã hóa đơn
          cmd.Parameters.AddWithValue("@maHDB", maHDB);
          object result = cmd.ExecuteScalar();
          decimal tongTien = 0;
          if (result != DBNull.Value && result != null)
            tongTien = Convert.ToDecimal(result);
          // Cập nhật lại tổng tiền vào bảng hoaDonBan
          string sqlUpdate = "UPDATE tblHoaDonBan SET tongtien = @tongTien WHERE sohdb = @maHDB and deleted=0";
          SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
          cmdUpdate.Parameters.AddWithValue("@tongTien", tongTien);
          cmdUpdate.Parameters.AddWithValue("@maHDB", maHDB);
          cmdUpdate.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi xóa!!!", ex);
        }
      }
    }
    public decimal GetDoanhThuCuaThangTruoc()
    {
      decimal doanhThu = 0;

      string sql = @"
        SELECT SUM(tongtien) 
        FROM tblHoaDonBan 
        WHERE deleted = 0 
          AND MONTH(ngayban) = MONTH(DATEADD(MONTH, -1, GETDATE())) 
          AND YEAR(ngayban) = YEAR(DATEADD(MONTH, -1, GETDATE()))";

      using (SqlConnection conn = ConfigDB.GetConnection())
      using (SqlCommand cmd = new SqlCommand(sql, conn))
      {
        try
        {
          conn.Open();
          object result = cmd.ExecuteScalar();
          if (result != DBNull.Value && result != null)
          {
            doanhThu = Convert.ToDecimal(result);
          }
        }
        catch (Exception ex)
        {
          // Ghi log hoặc xử lý lỗi nếu cần
          throw new Exception("Lỗi khi lấy doanh thu trong DAO!!!", ex);
        }
      }

      return doanhThu;
    }

  }
}
