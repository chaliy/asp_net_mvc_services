namespace Community.Web.Mvc.Services
{
	using System.Web.Mvc;

	public class ServiceActionInvoker : ControllerActionInvoker
	{
		protected override ActionResult CreateActionResult(ControllerContext controllerContext, ActionDescriptor actionDescriptor, object actionReturnValue)
		{
			ActionResult actionResult = (actionReturnValue as ActionResult) ??
				new JsonResult { Data = actionReturnValue };

			return actionResult ?? new EmptyResult();
		}       
	}
}
