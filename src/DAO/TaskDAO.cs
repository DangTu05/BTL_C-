using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class TaskDAO : BaseDAO<TaskModel>
  {
    public bool insert(TaskModel task)
    {
      string sql = "Insert into tblCongViec(macv, tencv) values (@macv, @tencv)";
      var parameters = new Dictionary<string, object>
        {
            {"@macv", task.macv},
            {"@tencv", task.tencv}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(TaskModel task)
    {
      string sql = "Update tblCongViec Set tencv=@tencv where macv=@macv";
      var parameters = new Dictionary<string, object>
        {
            {"@macv", task.macv},
            {"@tencv", task.tencv}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillTaskCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT macv, tencv FROM tblCongViec", "macv", "tencv");
    }

    protected override string getColumns() => " macv, tencv ";
    protected override string getKeyColumn() => " macv ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblCongViec ";

    protected override TaskModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}