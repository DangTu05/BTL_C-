using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BTL_C_.src.DAO
{
  internal class EmployeeDAO : BaseDAO<EmployeeModel>
  {
    public bool insert(EmployeeModel employee)
    {
      string query = "INSERT INTO tblNhanVien (manv, tennv, gioitinh,ngaysinh, sdt, diachi,macv) " +
                     "VALUES (@ma, @ten, @gioitinh, @ngaysinh, @sdt, @diachi,@macv)";

      var parameters = new Dictionary<string, object>
        {
            {"@ma", employee.MaNhanVien},
            {"@ten", employee.TenNhanVien},
            {"@gioitinh", employee.GioiTinh},
            {"@ngaysinh", employee.NgaySinh},
            {"@sdt", employee.SoDienThoai},
            {"@diachi", employee.DiaChi},
            {"@macv",employee.MaCV }
        };

      return ExecuteNonQuery(query, parameters);
    }
    public bool update(EmployeeModel employee)
    {
      string query = "UPDATE tblNhanVien set tennv = @ten, gioitinh = @gioitinh, ngaysinh = @ngaysinh, sdt = @sdt, diachi = @diachi, macv = @macv where manv = @ma";
      var parameters = new Dictionary<string, object>
        {
            {"@ma", employee.MaNhanVien},
            {"@ten", employee.TenNhanVien},
            {"@gioitinh", employee.GioiTinh},
            {"@ngaysinh", employee.NgaySinh},
            {"@sdt", employee.SoDienThoai},
            {"@diachi", employee.DiaChi},
            {"@macv",employee.MaCV }
        };

      return ExecuteNonQuery(query, parameters);
    }

    protected override string getColumns() => " manv, tennv, gioitinh, ngaysinh, sdt, tencv, diachi";

    protected override string getKeyColumn() => " manv ";
    protected override string GetKeyExist() => " manv ";

    protected override string GetTableName() => " tblNhanVien nv LEFT JOIN tblCongViec cv ON nv.macv = cv.macv ";

    protected override EmployeeModel MapReaderToObject(SqlDataReader reader)
    {
      return new EmployeeModel(
        reader["manv"].ToString(),
        reader["tennv"].ToString(),
        reader["ngaysinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ngaysinh"]),
        reader["sdt"].ToString(),
        reader["diachi"].ToString(),
        reader["tencv"] != null ? reader["tencv"].ToString() : "",
        reader["gioitinh"].ToString()
    );
    }
    protected override string GetAlias() => " nv";
  }
}
