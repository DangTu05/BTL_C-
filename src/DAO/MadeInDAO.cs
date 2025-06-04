using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class MadeInDAO : BaseDAO<MadeInModel>
  {
    public bool insert(MadeInModel madein)
    {
      string sql = "Insert into tblNoiSanXuat(mansx, tennsx) values (@mansx, @tennsx)";
      var parameters = new Dictionary<string, object>
        {
            {"@mansx", madein.mansx},
            {"@tennsx", madein.tennsx}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(MadeInModel madein)
    {
      string sql = "Update tblNoiSanXuat Set tennsx=@tennsx where mansx=@mansx";
      var parameters = new Dictionary<string, object>
        {
            {"@mansx", madein.mansx},
            {"@tennsx", madein.tennsx}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillMadeInCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT mansx, tennsx FROM tblNoiSanXuat", "mansx", "tennsx");
    }

    protected override string getColumns() => " mansx, tennsx ";
    protected override string getKeyColumn() => " mansx ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblNoiSanXuat ";

    protected override MadeInModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}