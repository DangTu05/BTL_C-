using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class MaterialDAO : BaseDAO<MaterialModel>
  {
    public bool insert(MaterialModel material)
    {
      string sql = "Insert into tblChatLieu(macl, tencl) values (@macl, @tencl)";
      var parameters = new Dictionary<string, object>
        {
            {"@macl", material.macl},
            {"@tencl", material.tencl}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(MaterialModel material)
    {
      string sql = "Update tblChatLieu Set tencl=@tencl where macl=@macl";
      var parameters = new Dictionary<string, object>
        {
            {"@macl", material.macl},
            {"@tencl", material.tencl}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillMaterialCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT macl, tencl FROM tblChatLieu", "macl", "tencl");
    }

    protected override string getColumns() => " macl, tencl ";
    protected override string getKeyColumn() => " macl ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblChatLieu ";

    protected override MaterialModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}