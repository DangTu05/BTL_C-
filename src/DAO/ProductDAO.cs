using BTL_C_.Configs;
using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class ProductDAO : BaseDAO<ProductModel>
  {
    public static void fillProductCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT maquanao, tenquanao FROM tbLSanPham WHERE deleted=0", "maquanao", "tenquanao");
    }
    public bool insert(ProductModel product)
    {
      string query = "INSERT INTO tblSanPham (maquanao, matheloai, tenquanao, mamau, mansx, madt, mamua, sltonkho, anh, dongianhap, dongiaban, trangthai, macl, maco) " +
                   "VALUES (@maquanao, @matheloai, @tenquanao, @mamau, @mansx, @madt, @mamua, @sltonkho, @anh, @dongianhap, @dongiaban, @trangthai, @macl, @maco)";

      var parameters = new Dictionary<string, object>
        {
            {"@maquanao", product.maquanao },
            {"@matheloai", product.matheloai},
            {"@tenquanao", product.tenquanao},
            {"@mamau", product.mamau},
            {"@mansx", product.mansx},
            {"@madt", product.madt},
            {"@mamua",product.mamua },
            {"@sltonkho", product.sltonkho },
            {"@anh", product.anh },
            {"@dongianhap", product.dongianhap },
            {"@dongiaban", product.dongiaban },
            {"@trangthai", product.trangthai },
            {"@macl", product.macl },
            {"@maco", product.maco }
        };

      return ExecuteNonQuery(query, parameters);
    }
    public bool update(ProductModel product)
    {
      string sql = "UPDATE tblSanPham SET matheloai = @matheloai, mamau = @mamau, mansx = @mansx, madt = @madt, mamua = @mamua, anh = @anh, sltonkho = @sltonkho, dongianhap = @dongianhap, dongiaban = @dongiaban, macl = @macl, maco = @maco, trangthai = @trangthai, tenquanao = @tenquanao where maquanao = @maquanao";
      var parameters = new Dictionary<string, object>
        {
            {"@maquanao", product.maquanao },
            {"@matheloai", product.matheloai},
            {"@tenquanao", product.tenquanao},
            {"@mamau", product.mamau},
            {"@mansx", product.mansx},
            {"@madt", product.madt},
            {"@mamua",product.mamua },
            {"@sltonkho", product.sltonkho },
            {"@anh", product.anh },
            {"@dongianhap", product.dongianhap },
            {"@dongiaban", product.dongiaban },
            {"@trangthai", product.trangthai },
            {"@macl", product.macl },
            {"@maco", product.maco }
        };
      return ExecuteNonQuery(sql, parameters);
    }
    public bool UpdatePriceAndCount(string masp, decimal dongianhap, decimal dongiaban, int sl)
    {
      string sql = "UPDATE tblSanPham SET dongiaban=@dongiaban, dongianhap=@dongianhap, sltonkho=@soluong where maquanao = @maquanao";
      var parameters = new Dictionary<string, object>
        {
            {"@maquanao", masp },
            {"@dongianhap",dongianhap },
            {"@dongiaban",dongiaban },
            {"@soluong", sl }
        };
      return ExecuteNonQuery(sql, parameters);
    }
    public bool UpdateCount(string masp, int soluong, SqlConnection conn, SqlTransaction transaction)
    {
      string selectSql = "SELECT sltonkho FROM tblSanPham WHERE maquanao = @maquanao";
      int sltonkho;

      using (SqlCommand selectCmd = new SqlCommand(selectSql, conn, transaction))
      {
        selectCmd.Parameters.AddWithValue("@maquanao", masp);
        object result = selectCmd.ExecuteScalar();
        if (result == null || result == DBNull.Value)
        {
          return false; // Không tìm thấy sản phẩm
        }

        sltonkho = Convert.ToInt32(result);
      }

      int slconlai = sltonkho - soluong;
      if (slconlai < 0)
      {
        return false; // Không đủ tồn kho
      }

      string updateSql = "UPDATE tblSanPham SET sltonkho = @soluong WHERE maquanao = @maquanao";
      using (SqlCommand updateCmd = new SqlCommand(updateSql, conn, transaction))
      {
        updateCmd.Parameters.AddWithValue("@soluong", slconlai);
        updateCmd.Parameters.AddWithValue("@maquanao", masp);

        return updateCmd.ExecuteNonQuery() > 0;
      }
    }

    public DataTable GetSanPhamBanChay(DateTime ngayBatDau, DateTime ngayKetThuc)
    {
      DataTable dt = new DataTable();

      using (SqlConnection conn = ConfigDB.GetConnection())
      {
        try
        {
          conn.Open(); string query = @"
                        SELECT 
                            sp.maquanao,
                            sp.tenquanao,
                            SUM(ct.soluong) AS SoLuongBan,
                            sp.dongiaban,
                            SUM(ct.thanhtien) AS TongTien
                        FROM 
                            tblChiTietHoaDonBan ct
                        JOIN 
                            tblSanPham sp ON ct.maquanao = sp.maquanao
                        JOIN 
                            tblHoaDonBan hdb ON ct.sohdb = hdb.sohdb
                        WHERE 
                            hdb.ngayban BETWEEN @NgayBatDau AND @NgayKetThuc
                        GROUP BY 
                            sp.maquanao, sp.tenquanao, sp.dongiaban
                        ORDER BY 
                            SoLuongBan DESC";

          SqlCommand command = new SqlCommand(query, conn);
          command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
          command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
          SqlDataAdapter adapter = new SqlDataAdapter(command);
          adapter.Fill(dt);
          return dt;
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi truy vấn trong DAO!!!", ex);
        }
      }
    }
    protected override string getColumns() => " maquanao, tenquanao, tl.tentl, m.tenmau, nsx.tennsx, dt.tendt, mua.tenmua, cl.tencl, co.tenco, sltonkho, anh, dongianhap, dongiaban, trangthai ";

    protected override string getKeyColumn()
    {
      return "maquanao";
    }

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }
    protected override string GetAlias()
    {
      return " sp";
    }

    protected override string GetTableName() => " tblSanPham sp LEFT JOIN tblTheLoai tl ON sp.matheloai = tl.matheloai LEFT JOIN tblMau m ON sp.mamau = m.mamau LEFT JOIN tblMua mua ON sp.mamua = mua.mamua LEFT JOIN tblDoiTuong dt ON sp.madt = dt.madt LEFT JOIN tblNoiSanXuat nsx ON sp.mansx = nsx.mansx LEFT JOIN tblChatLieu cl ON sp.macl = cl.macl LEFT JOIN tblCo co ON sp.maco = co.maco ";

    protected override ProductModel MapReaderToObject(SqlDataReader reader)
    {
      return new ProductModel
      {
        maquanao = reader["maquanao"].ToString(),
        tenquanao = reader["tenquanao"].ToString(),
        dongiaban = reader["dongiaban"] == DBNull.Value ? 0 : Convert.ToSingle(reader["dongiaban"]),
        sltonkho = reader["sltonkho"] == DBNull.Value ? 0 : Convert.ToInt32(reader["sltonkho"]),
        trangthai = reader["trangthai"].ToString()
      };


    }

    protected override string getName() => "sp.tenquanao";
  }
}
