using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Models
{
  internal class RevenueModel
  {
    public string sohdb { get; set; }
    public string manv { get; set; }
    public string makh { get; set; }
    public DateTime ngayban { get; set; }
    public float tongtien { get; set; }
    public RevenueModel(string sohdb, string manv, string makh, DateTime ngayban, float tongtien)
    {
      this.sohdb = sohdb;
      this.manv = manv;
      this.makh = makh;
      this.ngayban = ngayban;
      this.tongtien = tongtien;
    }

  }
}
