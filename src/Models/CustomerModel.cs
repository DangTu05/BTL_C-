namespace BTL_C_.src.Models
{
  public class CustomerModel
  {
    public string makh { get; set; }
    public string tenkh { get; set; }
    public string sdt { get; set; }
    public int diem { get; set; }

    // Add a parameterless constructor to resolve CS7036  
    public CustomerModel() { }

    // Add a constructor with parameters for initialization  
    public CustomerModel(string makh, string tenkh, string sdt, int diem)
    {
      this.makh = makh;
      this.tenkh = tenkh;
      this.sdt = sdt;
      this.diem = diem;
    }
  }
}

