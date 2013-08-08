using System;
using System.Web.Mvc;

namespace StoneFinch.SmpMaintenance.Views.Web.Interop
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {

            }
            catch { /* no-op */}

            base.OnActionExecuting(filterContext);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            try
            {

            }
            catch { /* no-op */ }

            base.OnException(filterContext);
        }
    }
}