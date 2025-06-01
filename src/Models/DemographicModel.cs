namespace BTL_C_.src.Models
{
  internal class DemographicModel
  {
    public string madt { get; set; }
    public string tendt { get; set; }
    public DemographicModel(string madt, string tendt)
    {
      this.madt = madt;
      this.tendt = tendt;
    }
  }
}
