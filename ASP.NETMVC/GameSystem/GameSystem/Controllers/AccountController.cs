using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
using GameSystem.Models;

namespace GameSystem.Controllers
{
    public class AccountController : Controller
    {
        private GameDBEntities db = new GameDBEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Account/Login 登录
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string account, string pwd)
        {
            Account login = db.Account.FirstOrDefault(a => a.AccountName == account && a.AccountPwd == pwd);
            if (login != null)
            {
                Session["login"] = login;//在Session中保存用户信息
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["msg"] = "帐号或密码错误,登录失败!!";
            }
            return View();
        }

        // GET: /Account/Register 注册
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Account a)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //注册
                    db.Account.Add(a);
                    db.SaveChanges();
                    TempData["msg"] = "注册成功,请输入账号和密码进行登录!!";
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    TempData["msg"] = "表单验证失败!";
                }
            }
            catch (Exception)
            {
                TempData["msg"] = "注册失败!!";
            }
            return View();
        }

    }
}