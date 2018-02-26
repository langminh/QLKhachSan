using ProductMvc.Entity;
using ProductMvc.Entity.EF;
using System.Linq;
using ProductMvc.Code;

namespace ProductMvc.Models
{
    public class LoginDao
    {
        #region Lấy về User đăng nhập
        public static User UserLogOn()
        {
            DataEntities db = new DataEntities();
            return db.Users.FirstOrDefault(m => m.UserName == System.Web.HttpContext.Current.User.Identity.Name);
        }
        #endregion
        #region Check UserLogOn
        public static User CheckUser(string UserName, string Password)
        {
            var passMD5 = Password.GetMD5();
            DataEntities db = new DataEntities();
            var UserLogOn = db.Users.SingleOrDefault(m => m.UserName == UserName && m.Password == passMD5);
            return UserLogOn;
        }
        #endregion
    }
}