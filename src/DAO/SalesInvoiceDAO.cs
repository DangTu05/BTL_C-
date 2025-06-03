using BTL_C_.Configs;
using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BTL_C_.src.DAO
{
  internal class SalesInvoiceDAO : BaseDAO<SalesInvoiceModel>
  {
    public bool Insert(SalesInvoiceModel hdb)
    {
      string sql = "Insert into tblHoaDonBan(sohdb, manv, makh, ngayban, tongtien) values (@sohdb, @manv, @makh, @ngayban, @tongtien)";
      var parameters = new Dictionary<string, object>
        {
            {"@sohdb", hdb.soHDB},
            {"@manv", hdb.manv},
            { "@makh",hdb.makh},
            {"@ngayban",hdb.ngayban },
            {"@tongtien",hdb.tongtien }
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public List<SalesInvoiceModel> GetAllHoaDonBan()
    {
      List<SalesInvoiceModel> list = new List<SalesInvoiceModel>();

      string query = "SELECT sohdb, manv, makh, ngaban, tongtien FROM tblhoadonban where deleted=0";

      using (SqlConnection conn = ConfigDB.GetConnection()) // dùng class tiện ích kết nối DB
      {
        conn.Open();
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
          using (SqlDataReader reader = cmd.ExecuteReader())
          {
            while (reader.Read())
            {
              var invoice = new SalesInvoiceModel
              {
                soHDB = reader["sohdb"] != DBNull.Value ? reader["sohdb"].ToString() : string.Empty,
                ngayban = reader["ngaylap"] != DBNull.Value ? Convert.ToDateTime(reader["ngaylap"]) : DateTime.MinValue,
                makh = reader["makh"] != DBNull.Value ? reader["makh"].ToString() : string.Empty,
                tongtien = reader["tongtien"] != DBNull.Value
               ? (float)Convert.ToDecimal(reader["tongtien"])
               : 0f,
                manv = reader["manv"] != DBNull.Value ? reader["manv"].ToString() : string.Empty
              };

              list.Add(invoice);
            }
          }
        }
      }

      return list;
    }


    //public List<InvoiceDetailModel> GetChiTietHoaDonBan(string soHDB)
    //{
    //  List<InvoiceDetailModel> list = new List<InvoiceDetailModel>();

    //  string query = "SELECT sohdb, manv, makh, ngaban, tongtien FROM tblhoadonban where deleted=0";

    //  using (SqlConnection conn = ConfigDB.GetConnection()) // dùng class tiện ích kết nối DB
    //  {
    //    conn.Open();
    //    using (SqlCommand cmd = new SqlCommand(query, conn))
    //    {
    //      using (SqlDataReader reader = cmd.ExecuteReader())
    //      {
    //        while (reader.Read())
    //        {
    //          var invoice = new SalesInvoiceModel
    //          {
    //            soHDB = reader["sohdb"] != DBNull.Value ? reader["sohdb"].ToString() : string.Empty,
    //            ngayban = reader["ngaylap"] != DBNull.Value ? Convert.ToDateTime(reader["ngaylap"]) : DateTime.MinValue,
    //            makh = reader["makh"] != DBNull.Value ? reader["makh"].ToString() : string.Empty,
    //            tongtien = reader["tongtien"] != DBNull.Value
    //           ? (float)Convert.ToDecimal(reader["tongtien"])
    //           : 0f,
    //            manv = reader["manv"] != DBNull.Value ? reader["manv"].ToString() : string.Empty
    //          };

    //          list.Add(invoice);
    //        }
    //      }
    //    }
    //  }

    //  return list;
    //}

    public bool AddHoaDonBan(SalesInvoiceModel hd, List<InvoiceDetailModel> chiTietList)
    {
      using (SqlConnection conn = ConfigDB.GetConnection())
      {
        conn.Open();
        SqlTransaction transaction = conn.BeginTransaction();

        try
        {
          // Thêm hóa đơn
          string insertHoaDonQuery = @"INSERT INTO tblhoadonban (sohdb, ngayban, makh, tongtien, manv) 
                                         VALUES (@sohdb, @ngaylap, @makh, @tongtien, @manv)";
          using (SqlCommand cmd = new SqlCommand(insertHoaDonQuery, conn, transaction))
          {
            cmd.Parameters.AddWithValue("@sohdb", hd.soHDB);
            cmd.Parameters.AddWithValue("@ngaylap", hd.ngayban);
            cmd.Parameters.AddWithValue("@makh", string.IsNullOrWhiteSpace(hd.makh) ? (object)DBNull.Value : hd.makh);
            cmd.Parameters.AddWithValue("@tongtien", hd.tongtien);
            cmd.Parameters.AddWithValue("@manv", hd.manv);

            if (cmd.ExecuteNonQuery() <= 0)
            {
              transaction.Rollback();
              return false;
            }
          }
          ProductDAO productDAO = new ProductDAO();
          // Thêm chi tiết hóa đơn
          foreach (var ct in chiTietList)
          {
            string insertCTQuery = @"INSERT INTO tblchitiethoadonban (sohdb, maquanao, soluong, dongia,giamgia,thanhtien)
                                         VALUES (@sohdb, @masp, @soluong, @dongia,@giamgia,@thanhtien)";

            using (SqlCommand cmd = new SqlCommand(insertCTQuery, conn, transaction))
            {
              cmd.Parameters.AddWithValue("@sohdb", ct.mahdb);
              cmd.Parameters.AddWithValue("@masp", ct.masp);
              cmd.Parameters.AddWithValue("@soluong", ct.soluong);
              cmd.Parameters.AddWithValue("@dongia", ct.dongia);
              cmd.Parameters.AddWithValue("@giamgia", ct.giamgia);
              cmd.Parameters.AddWithValue("@thanhtien", ct.thanhtien);

              if (cmd.ExecuteNonQuery() <= 0)
              {
                transaction.Rollback();
                return false;
              }
              if (!productDAO.UpdateCount(ct.masp, ct.soluong, conn, transaction))
              {
                transaction.Rollback();
                return false;
              }
            }
          }

          // Nếu tất cả thành công
          transaction.Commit();
          return true;
        }
        catch (Exception ex)
        {

          transaction.Rollback();
          throw new Exception("Đã xảy ra lỗi!!!", ex);
        }
      }
    }


    protected override string getColumns() => " sohdb, hdb.manv, kh.tenkh, ngayban, tongtien ";

    protected override string getKeyColumn() => " sohdb ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }
    protected override string GetAlias() => " hdb ";
    protected override string GetTableName() => " tblHoaDonBan hdb left join tblKhachHang kh On hdb.makh=kh.makh left join tblNhanVien nv On hdb.manv=nv.manv ";

    protected override SalesInvoiceModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
