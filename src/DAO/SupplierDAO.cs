using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class SupplierDAO : BaseDAO<SupplierModel>
  {
    public static void fillSupplierCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT maNCC, tenNCC FROM tbLNhaCungCap WHERE maNCC IS NOT NULL AND maNCC <> '' AND tenNCC IS NOT NULL AND tenNCC <> ''", "mancc", "tenncc");
    }
    protected override string getColumns() => " mancc, tenncc, diachi, sdt ";

    protected override string getKeyColumn() => "mancc";
    protected override string getName() => "tenncc";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => "tblNhaCungCap";

    protected override SupplierModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
    public bool insert(SupplierModel supplier)
    {
      string sql = "Insert into tblNhaCungCap(mancc, tenncc, diachi, sdt) values (@mancc, @tenncc, @diachi, @sdt)";
      var parameters = new Dictionary<string, object>
            {
                {"@mancc", supplier.mancc },
                {"@tenncc", supplier.tenncc },
                {"@diachi", supplier.diachi },
                {"@sdt", supplier.sdt }
            };
      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(SupplierModel supplier)
    {
      string sql = "UPDATE tblNhaCungCap SET tenncc = @tenncc, diachi = @diachi, sdt = @sdt where mancc = @mancc";
      var parameters = new Dictionary<string, object>
                 {
                {"@mancc", supplier.mancc },
                {"@tenncc", supplier.tenncc },
                {"@diachi", supplier.diachi },
                {"@sdt", supplier.sdt }
            };
      return ExecuteNonQuery(sql, parameters);
    }
  }
}
