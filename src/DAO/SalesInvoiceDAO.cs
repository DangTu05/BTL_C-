using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;

namespace BTL_C_.src.DAO
{
  internal class SalesInvoiceDAO : BaseDAO<SalesInvoiceModel>
  {
    protected override string getColumns()
    {
      throw new NotImplementedException();
    }

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
