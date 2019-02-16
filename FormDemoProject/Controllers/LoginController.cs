using FormDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormDemoProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult SignIn(User model)
        {
            FormDbContext dbContext = new FormDbContext();
            var user = dbContext.Users.Where(x => x.IsActive).FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

            if (user == null)
            {
                ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Şifre Girdiniz !!!");
                return View(model);
            }
            else
            {
                Session["login"] = user;

                return RedirectToAction("Index", "Forms");
            }
        }
    }
}