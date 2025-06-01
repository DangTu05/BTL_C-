using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class ColorDAO : BaseDAO<ColorModel>
  {
    public static void fillColorCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT mamau, tenmau FROM tblMau", "mamau", "tenmau");
    }
    public bool insert(ColorModel color)
    {
      string sql = "Insert into tblMau(mamau, tenmau) values (@mamau, @tenmau)";
      var parameters = new Dictionary<string, object>
        {
            {"@mamau", color.mamau},
            {"@tenmau", color.tenmau}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(ColorModel color)
    {
      string sql = "Update tblMau Set tenmau=@tenmau where mamau=@mamau";
      var parameters = new Dictionary<string, object>
        {
            {"@mamau", color.mamau},
            {"@tenmau", color.tenmau}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    protected override string getColumns() => " mamau, tenmau ";
    protected override string getKeyColumn() => " mamau ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblMau ";

    protected override ColorModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
