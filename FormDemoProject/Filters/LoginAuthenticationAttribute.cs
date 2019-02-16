﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace FormDemoProject.Filters
{
    public class LoginAuthentication : FilterAttribute, IAuthorizationFilter
    {    
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if(filterContext.HttpContext.Session["login"] == null)
            {
                filterContext.Result = new RedirectResult("/Login/SignIn");
            }
        }
    }
}