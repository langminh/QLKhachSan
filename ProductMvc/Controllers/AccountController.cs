using ProductMvc.Code;
using ProductMvc.Entity;
using ProductMvc.Entity.EF;
using ProductMvc.Models;
using ProductMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace ProductMvc.Controllers
{
    public class AccountController : Controller
    {

        DataEntities db = new DataEntities();
        [Authorize(Users = "admin")]
        public ActionResult Index()
        {
            return View(db.Users);
        }
        #region LogOn
        [HttpGet]
        public ActionResult LogOn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogOn(LogOnModel model)
        {
            if (ModelState.IsValid)
            {
                var UserLogOn = LoginDao.CheckUser(model.UserName, model.Password);
                if (UserLogOn != null)
                {
                    FormsAuthentication.SetAuthCookie(UserLogOn.UserName, true);
                    return Redirect(this.Request.QueryString["ReturnUrl"]??"/");
                }
                ViewBag.Message = "Vui lòng kiểm tra lại tên đăng nhập và mật khẩu";
                return View("LogOn", model);
            }
            return View("LogOn", model);
        }
        #endregion
        #region LogOff
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogOn","Account");
        }
        #endregion
        #region Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserVM model)
        {
            if (ModelState.IsValid)
            {
                var _OldUserName = db.Users.FirstOrDefault(m => m.UserName == model.UserName);
                if (_OldUserName == null)
                {
                    var _User = new User { UserName = model.UserName, Password = model.Password.GetMD5(), RoleID = 2, Address = string.Empty, FullName = string.Empty, Phone = string.Empty, Sex = true, Lock= false };
                    db.Users.Add(_User);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Message = "Tên đăng nhập đã tồn tại";
            return View(model);
        }
        #endregion

        #region Đổi mật khẩu
        public ActionResult ChangePass()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePass(ChangePasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var UserLogOn = LoginDao.UserLogOn();
                if (UserLogOn.Password == model.OldPassword.GetMD5())
                {
                    UserLogOn.Password = model.NewPassword;
                    var update = db.Users.Single(u => u.UserID == UserLogOn.UserID);
                    update.Password = model.NewPassword.GetMD5();
                    db.SaveChanges();
                    ViewBag.Message = "Đổi mật khẩu thành công";
                }
                else
                {
                    ViewBag.Message = "Mật Khẩu cũ không đúng";
                }
                return View();
            }
            return View();
        }
        #endregion

    }
}
