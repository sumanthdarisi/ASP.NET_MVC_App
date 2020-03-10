using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class ActionResultsController : Controller
    {
        //ViewResult
        
        public ViewResult ViewResult()
        {
            return View();
        }

        [ActionName("Prime")]
        public ContentResult ContentResult()
        {
            return Content("Retruning Content Result...","String");
        }

        [NonAction]
        public RedirectResult RedirectResult()
        {
            return Redirect("http://www.facebook.com/sumanth.darisi");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToRoute("Default");
        }

    }
}