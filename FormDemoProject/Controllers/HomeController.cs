using FormDemoProject.Filters;
using FormDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormDemoProject.Controllers
{
    public class HomeController : Controller
    {
        [LoginAuthentication]
        public ActionResult Index()
        {
            return View();
        }
    }
}