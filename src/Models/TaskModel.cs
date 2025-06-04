namespace BTL_C_.src.Models
{
  internal class TaskModel
  {
    public string macv { get; set; }
    public string tencv { get; set; }
    public TaskModel(string macv, string tencv)
    {
      this.macv = macv;
      this.tencv = tencv;
    }
  }
}
