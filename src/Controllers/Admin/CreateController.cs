using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Controllers.Admin
{
  internal class CreateController
  {
    private CreateControl createControl;
    public CreateController(CreateControl createControl)
    {
      this.createControl = createControl;
      SetupEventListener();
    }
    public void SetupEventListener()
    {
      createControl.SetMauListener(redirectFrmColor);
      createControl.SetChatLieuListener(RedirectFrmMaterial);
      createControl.SetCoListener(RedirectFrmSize);
      createControl.SetDoiTuongListener(RedirectFrmDemographic);
      createControl.SetMuaListener(RedirectFrmSeason);
      createControl.SetNoiSanXuatListener(RedirectFrmMadeIn);
      createControl.SetCongViecListener(RedirectFrmTask);
      createControl.SetTheLoaiListener(RedirectFrmCategory);
    }
    private void redirectFrmColor(object sender, EventArgs e)
    {
      AppController.StartFrmColor(createControl.GetForm());
    }
    private void RedirectFrmMaterial(object sender, EventArgs e)
    {
      AppController.StartFrmMaterial(createControl.GetForm());
    }
    private void RedirectFrmSize(object sender, EventArgs e)
    {
      AppController.StartFrmSize(createControl.GetForm());
    }
    private void RedirectFrmDemographic(object sender, EventArgs e)
    {
      AppController.StartFrmDemographic(createControl.GetForm());
    }
    private void RedirectFrmSeason(object sender, EventArgs e)
    {
      AppController.StartFrmSeason(createControl.GetForm());
    }
    private void RedirectFrmMadeIn(object sender, EventArgs e)
    {
      AppController.StartFrmMadeIn(createControl.GetForm());
    }
    private void RedirectFrmTask(object sender, EventArgs e)
    {
      AppController.StartFrmTask(createControl.GetForm());
    }
    private void RedirectFrmCategory(object sender, EventArgs e)
    {
      AppController.StartFrmCategory(createControl.GetForm());
    }
  }
}
