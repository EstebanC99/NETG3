using Academia.UI.WebForm.App_Start;
using Business.Utils;
using Cross.Exceptions;
using System;
using System.Diagnostics;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;

namespace Academia.UI.WebForm
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.DependencyResolver = new DefaultDependencyResolver(IoCContainer.Instance);

            IoCContainer.Instance.Register();
        }

        void Application_Error()
        {
            var ex = Server.GetLastError();

            if (ex is ValidationException)
            {
                EventLog.WriteEntry("Academia", $"{ex.Message}", EventLogEntryType.Information);
                HttpContext.Current.Response.Write(string.Format("<script>alert('{0}')</script>", ex.Message));
            }

            if (ex is Exception)
            {
                EventLog.WriteEntry("Academia", $"{ex.Message} - {ex.StackTrace}", EventLogEntryType.Error);
                HttpContext.Current.Response.Write(string.Format("<script>alert('{0}')</script>", "Ocurrio un error inesperado!"));
            }

            return;
        }

    }
}