using Academia.UI.Services;
using Business.Utils;
using ResourceAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Academia.UI.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.DependencyResolver = new DefaultDependencyResolver(IoCContainer.Instance);

            IoCContainer.Instance.Register();
        }
    }
}
