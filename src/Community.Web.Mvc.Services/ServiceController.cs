namespace Community.Web.Mvc.Services
{
	using System.Web.Mvc;

	public abstract class ServiceController : Controller
	{
        protected override IActionInvoker CreateActionInvoker()
        {
            return new ServiceActionInvoker();
        }
	}
}
