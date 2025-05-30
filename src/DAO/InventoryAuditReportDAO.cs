using BTL_C_.Configs;
using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
  internal class InventoryAuditReportDAO
  {
    public DataTable GetData(DateTime? startDate = null, DateTime? endDate = null)
    {
      string query = @"
                    SELECT
                        sp.maquanao,
                        tl.tentl,
                        m.tenmau,
                        nsx.tennsx,
                        dt.tendt,
                        mua.tenmua,
                        co.tenco,
                        cl.tencl,
                        sp.sltonkho,
                        sp.dongiaban,
                        sp.trangthai,
                        MAX(hdn.ngaynhap) AS NgayNhapCuoiCung -- Lấy ngày nhập cuối cùng của sản phẩm
                    FROM
                        tblSanPham sp
                    LEFT JOIN
                        tblTheLoai tl ON sp.matheloai = tl.matheloai
                    LEFT JOIN
                        tblMau m ON sp.mamau = m.mamau
                    LEFT JOIN
                        tblNoiSanXuat nsx ON sp.mansx = nsx.mansx
                    LEFT JOIN
                        tblDoiTuong dt ON sp.madt = dt.madt
                    LEFT JOIN
                        tblMua mua ON sp.mamua = mua.mamua
                    LEFT JOIN
                        tblCo co ON sp.maco = co.maco
                    LEFT JOIN
                        tblChatLieu cl ON sp.macl = cl.macl
                    LEFT JOIN
                        tblChiTietHoaDonNhap cthdn ON sp.maquanao = cthdn.maquanao
                    LEFT JOIN
                        tblHoaDonNhap hdn ON cthdn.sohdn = hdn.sohdn
                    WHERE
                        sp.deleted = 0 -- Chỉ hiển thị sản phẩm chưa bị xóa mềm
                        AND (@StartDate IS NULL OR hdn.ngaynhap >= @StartDate)
                        AND (@EndDate IS NULL OR hdn.ngaynhap <= @EndDate)
                    GROUP BY
                        sp.maquanao, tl.tentl, m.tenmau, nsx.tennsx, dt.tendt, mua.tenmua, co.tenco, cl.tencl, sp.sltonkho, sp.dongiaban, sp.trangthai
                    ORDER BY
                        sp.maquanao;";
      try
      {
        using (SqlConnection conn = ConfigDB.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
          conn.Open();
          // Thêm tham số vào câu lệnh SQL
          cmd.Parameters.AddWithValue("@StartDate", startDate.HasValue ? (object)startDate.Value.Date : DBNull.Value);
          cmd.Parameters.AddWithValue("@EndDate", endDate.HasValue ? (object)endDate.Value.Date : DBNull.Value);



          // Dùng SqlDataAdapter với cmd đã có sẵn tham số
          SqlDataAdapter adapter = new SqlDataAdapter(cmd);

          DataTable dt = new DataTable();
          adapter.Fill(dt);
          return dt;
        }
      }
      catch (Exception ex)
      {
        // Xử lý lỗi hoặc ghi log tại đây
        throw new Exception("Lỗi khi truy vấn dữ liệu: " + ex.Message, ex);
      }
    }
  }
}


