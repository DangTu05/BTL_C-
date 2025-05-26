﻿using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views;
using System;

namespace BTL_C_.src.Controllers
{
  internal class LoginController
  {
    private FrmLogin viewLogin;
    private AccountDAO accountDAO;
    public LoginController(FrmLogin viewLogin)
    {
      this.viewLogin = viewLogin;
      accountDAO = new AccountDAO();
      viewLogin.setDangNhapListener(login);
    }
    public void login(object sender, EventArgs e)
    {
      try
      {
        if (!InputValidate.inputLoginValidate(viewLogin.getEmail(), viewLogin.getPassword()))
        {
          return;
        }
        AccountModel account = accountDAO.findRecordByField("email", viewLogin.getEmail());
        if (account == null)
        {
          MessageUtil.ShowInfo("Tài khoản không tồn tại!");
          return;
        }
        if (!HashPasswordUtil.checkPassword(viewLogin.getPassword(), account.mat_khau))
        {
          MessageUtil.ShowWarning("Mật khẩu không khớp!");
          return;
        }
        MessageUtil.ShowInfo("Đăng nhập thành công!");
        if (account.vai_tro == "Admin")
        {
          AppController.startDashBoard(viewLogin.getForm());
        }

      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đăng nhập không thành công!!!");
      }
    }
  }
}
