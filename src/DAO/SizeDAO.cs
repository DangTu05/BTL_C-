using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class SizeDAO : BaseDAO<SizeModel>
  {
    public bool insert(SizeModel size)
    {
      string sql = "Insert into tblCo(maco, tenco) values (@maco, @tenco)";
      var parameters = new Dictionary<string, object>
        {
            {"@maco", size.maco},
            {"@tenco", size.tenco}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(SizeModel size)
    {
      string sql = "Update tblCo Set tenco=@tenco where maco=@maco";
      var parameters = new Dictionary<string, object>
        {
            {"@maco", size.maco},
            {"@tenco", size.tenco}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillSizeCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT maco, tenco FROM tblCo", "maco", "tenco");
    }

    protected override string getColumns() => " maco, tenco ";
    protected override string getKeyColumn() => " maco ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblCo ";

    protected override SizeModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
