using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Models
{
  internal class PurchaseInvoiceDetailModel
  {
    public string sohdn { get; set; }
    public string maquanao { get; set; }
    public int soluong { get; set; }
    public decimal dongia { get; set; }
    public decimal giamgia { get; set; }
    public decimal thanhtien { get; set; }
  }
}
