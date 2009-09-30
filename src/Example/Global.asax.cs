namespace Example
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Routing;
	using System.Web.Mvc;

	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			RegisterRoutes(RouteTable.Routes);
		}

		private static void RegisterRoutes(RouteCollection routes)
		{
			routes.MapRoute("Default", "{controller}/{action}/{id}", new { Controller = "Home", Action = "Index", Id = "" });
		}
        
	}
}