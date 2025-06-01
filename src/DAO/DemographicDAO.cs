using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class DemographicDAO : BaseDAO<DemographicModel>
  {
    public bool insert(DemographicModel obj)
    {
      string sql = "Insert into tblDoiTuong(madt, tendt) values (@madt, @tendt)";
      var parameters = new Dictionary<string, object>
        {
            {"@madt", obj.madt},
            {"@tendt", obj.tendt}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(DemographicModel obj)
    {
      string sql = "Update tblDoiTuong Set tendt=@tendt where madt=@madt";
      var parameters = new Dictionary<string, object>
        {
            {"@madt", obj.madt},
            {"@tendt", obj.tendt}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillDemographicCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT madt, tendt FROM tblDoiTuong", "madt", "tendt");
    }

    protected override string getColumns() => " madt, tendt ";
    protected override string getKeyColumn() => " madt ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblDoiTuong ";

    protected override DemographicModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}