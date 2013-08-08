using StoneFinch.SmpMaintenance.Views.Web.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoneFinch.SmpMaintenance.Views.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            // no-op
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}