using BTL_C_.Configs;
using BTL_C_.src.Models;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BTL_C_.src.DAO
{
  internal class PurchaseInvoiceDAO : BaseDAO<PurchaseInvoiceModel>
  {
    public DataSet getData()
    {
      using (SqlConnection conn = ConfigDB.GetConnection())
      {
        try
        {
          conn.Open();

          SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT sohdn, mancc, ngaynhap, ghichu FROM tblHoaDonNhap where deleted=0", conn);
          SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT sohdn, maquanao, soluong, dongia, giamgia, thanhtien FROM tblChiTietHoaDonNhap where deleted=0", conn);
          DataSet ds = new DataSet();
          adapter1.Fill(ds, "tblHoaDonNhap");
          adapter2.Fill(ds, "tblChiTietHoaDonNhap");
          return ds;
        }
        catch (Exception ex)
        {
          throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
        }
      }
    }
    public bool AddHoaDonNhap(PurchaseInvoiceModel hdn, List<PurchaseInvoiceDetailModel> chiTietList)
    {
      using (SqlConnection conn = ConfigDB.GetConnection())
      {
        conn.Open();
        SqlTransaction transaction = conn.BeginTransaction();

        try
        {
          // Thêm hóa đơn
          string insertHoaDonQuery = @"INSERT INTO tblHoaDonNhap (sohdn, mancc, ngaynhap, ghichu, tongtien) 
                                         VALUES (@sohdn, @mancc, @ngaynhap, @ghichu, @tongtien)";
          using (SqlCommand cmd = new SqlCommand(insertHoaDonQuery, conn, transaction))
          {
            cmd.Parameters.AddWithValue("@sohdn", hdn.soHDN);
            cmd.Parameters.AddWithValue("@mancc", hdn.mancc);
            cmd.Parameters.AddWithValue("@ghichu", string.IsNullOrWhiteSpace(hdn.ghichu) ? (object)DBNull.Value : hdn.ghichu);
            cmd.Parameters.AddWithValue("@tongtien", hdn.tongtien);
            cmd.Parameters.AddWithValue("@ngaynhap", hdn.ngaynhap);

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
            string insertCTQuery = @"INSERT INTO tblChiTietHoaDonNhap (sohdn, maquanao, soluong, dongia,giamgia,thanhtien)
                                         VALUES (@sohdn, @masp, @soluong, @dongia,@giamgia,@thanhtien)";
            using (SqlCommand cmd = new SqlCommand(insertCTQuery, conn, transaction))
            {
              cmd.Parameters.AddWithValue("@sohdn", ct.sohdn);
              cmd.Parameters.AddWithValue("@masp", ct.maquanao);
              cmd.Parameters.AddWithValue("@soluong", ct.soluong);
              cmd.Parameters.AddWithValue("@dongia", ct.dongia);
              cmd.Parameters.AddWithValue("@giamgia", ct.giamgia);
              cmd.Parameters.AddWithValue("@thanhtien", ct.thanhtien);

              if (cmd.ExecuteNonQuery() <= 0)
              {
                transaction.Rollback();
                return false;
              }
              decimal dongiaban = ct.dongia * (decimal)1.1;
              if (!productDAO.UpdatePriceAndCount(ct.maquanao, ct.dongia, dongiaban, ct.soluong))
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

    protected override string getColumns()
    {
      throw new NotImplementedException();
    }

    protected override string getKeyColumn() => " sohdn ";
    protected override string GetAlias() => " hdn";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblHoaDonNhap hdn Left join tblNhaCungCap ncc On hdn.mancc=ncc.mancc ";

    protected override PurchaseInvoiceModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
