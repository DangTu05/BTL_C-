using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Utils
{
  internal class Session
  {
    private static EmployeeModel currentNv = null;
    public static bool IsLogin()
    {
      return currentNv != null;
    }
    public static EmployeeModel GetEmployee()
    {
      return currentNv;
    }
    public static void SetEmployee(EmployeeModel nv)
    {
      currentNv = nv;
    }
    public void Logout()
    {
      currentNv = null;
    }
  }
}
