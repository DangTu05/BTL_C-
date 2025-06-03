using BTL_C_.Configs;
using BTL_C_.src.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class CustomerDAO : BaseDAO<CustomerModel>
  {
    public bool insert(CustomerModel customer)
    {
      string sql = "Insert into tblKhachHang(makh, tenkh, sdt, point) values(@makh, @tenkh,@sdt,@point)";
      var parameters = new Dictionary<string, object>
      {
        {"@makh",customer.makh },
        {"@tenkh", customer.tenkh },
        {"@sdt", customer.sdt },
        {"@point", customer.diem },
        {"@makh", customer.makh }
      };
      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(CustomerModel customer)
    {
      string sql = "Update tblKhachHang SET tenkh = @tenkh, sdt = @sdt, point = @point where makh = @makh";
      var parameters = new Dictionary<string, object>
      {
        {"@tenkh", customer.tenkh },
        {"@sdt", customer.sdt },
        {"@point", customer.diem },
        {"@makh", customer.makh }
      };
      return ExecuteNonQuery(sql, parameters);
    }
    protected override string getColumns() => " makh, tenkh, sdt, point ";

    protected override string getKeyColumn() => " makh ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblKhachHang ";

    protected override CustomerModel MapReaderToObject(SqlDataReader reader)
    {
      return new CustomerModel(
    reader["makh"].ToString(),
    reader["tenkh"].ToString(),
    reader["sdt"].ToString(),
    (int)reader["point"]
);
    }
    public CustomerModel getVIPCustomer()
    {
      string sql = "SELECT TOP 1 * FROM tblKhachHang WHERE deleted = 0 ORDER BY point DESC";
      try
      {
        using (SqlConnection conn = ConfigDB.GetConnection())
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
          conn.Open();
          using (SqlDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              return MapReaderToObject(reader);
            }
          }
        }
      }
      catch (Exception ex)
      {
        // Log lỗi, hoặc xử lý tùy app (throw lại, hoặc trả null, hoặc báo lỗi)
        throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
        // Có thể throw lại để bên trên bắt hoặc trả mặc định
      }
      return null;
    }
  }
}
