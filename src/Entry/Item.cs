using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Entry
{
  public class Item
  {

    public string Text { get; set; }
    public object Value { get; set; }
    public decimal Price { get; set; }
    public override string ToString()
    {
      return Text; // Đảm bảo hiển thị đúng trong CheckedListBox
    }
  }
}
