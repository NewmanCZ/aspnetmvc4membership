using StoneFinch.SmpMaintenance.Data;
using StoneFinch.SmpMaintenance.Views.Web.Controllers;
using StoneFinch.SmpMaintenance.Views.Web.Properties;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

namespace StoneFinch.SmpMaintenance.Views.Web.Interop
{
    public class StaticControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var connectionStringProvider = new DefaultConnectionStringProvider(connectionString);
            
            switch (controllerName)
            {
                case "Home":
                    return new HomeController();

                case "Account":
                    return new AccountController();

                case "Error":
                    return new ErrorController();
            }

            return base.CreateController(requestContext, controllerName);
        }
    }
}