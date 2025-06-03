namespace BTL_C_.src.Models
{
  internal class ProductModel
  {
    public string maquanao { get; set; }
    public string tenquanao { get; set; }
    public string maco { get; set; }
    public string mamau { get; set; }
    public string mamua { get; set; }
    public string madt { get; set; }
    public string mansx { get; set; }
    public string matheloai { get; set; }
    public string macl { get; set; }
    public int sltonkho { get; set; }
    public string anh { get; set; }
    public float dongianhap { get; set; }
    public float dongiaban { get; set; }
    public string trangthai { get; set; }
    public ProductModel() { }
    public ProductModel(string maquanao, string tenquanao, string maco, string mamau, string mamua,
              string madt, string mansx, string matheloai, string macl,
              int sltonkho, string anh, float dongianhap, float dongiaban, string trangthai)
    {
      this.maquanao = maquanao;
      this.tenquanao = tenquanao;
      this.maco = maco;
      this.mamau = mamau;
      this.mamua = mamua;
      this.madt = madt;
      this.mansx = mansx;
      this.matheloai = matheloai;
      this.macl = macl;
      this.sltonkho = sltonkho;
      this.anh = anh;
      this.dongianhap = dongianhap;
      this.dongiaban = dongiaban;
      this.trangthai = trangthai;
    }


  }
}
