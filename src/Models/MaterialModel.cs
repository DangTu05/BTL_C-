namespace BTL_C_.src.Models
{
  internal class MaterialModel
  {
    public string macl { get; set; }
    public string tencl { get; set; }
    public MaterialModel(string macl, string tencl)
    {
      this.macl = macl;
      this.tencl = tencl;
    }
  }
}
