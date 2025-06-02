using BTL_C_.src.Utils;
using System;
using System.Linq;

namespace BTL_C_.src.Validators
{
  internal class InputValidate
  {
    private static bool CheckEmptyFields(params string[] fields)
    {
      if (fields.Any(string.IsNullOrWhiteSpace))
      {
        MessageUtil.ShowWarning(MessageConstants.INPUT_WARN);
        return false;
      }
      return true;
    }

    public static bool inputLoginValidate(string email, string password)
    {
      return CheckEmptyFields(email, password);
    }

    public static bool inputCreateAccountValidate(string email, string name, string password, string role)
    {
      return CheckEmptyFields(email, name, password, role);
    }

    public static bool inputUpdateAccountValidate(string email, string name, string vaitro, string status)
    {
      return CheckEmptyFields(email, name, vaitro, status);
    }

    public static bool inputCreateProductValidate(string maquanao, string tenquanao, string trangthai)
    {
      return CheckEmptyFields(maquanao, tenquanao, trangthai);
    }

    public static bool inputCreaetSupplierValidate(string mancc, string tenncc, string diachi, string sdt)
    {
      return CheckEmptyFields(mancc, tenncc, diachi, sdt);
    }

    public static bool inputSeasonValidate(string tenmua)
    {
      return CheckEmptyFields(tenmua);
    }
    public static bool inputColorValidate(string tenmau)
    {
      return CheckEmptyFields(tenmau);
    }
    public static bool inputMaterialValidate(string tencl)
    {
      return CheckEmptyFields(tencl);
    }
    public static bool InputObjectValidate(string tendt)
    {
      return CheckEmptyFields(tendt);
    }
    public static bool InputSizeValidate(string tenco)
    {
      return CheckEmptyFields(tenco);
    }
    public static bool InputSalesInvoice(string manv, string masp)
    {
      return CheckEmptyFields(manv, masp);
    }
  }
}
