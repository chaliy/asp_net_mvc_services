using System.Web.Mvc;

namespace Community.Web.Mvc.Services
{
    public class ServiceAttribute : FilterAttribute, IActionFilter
    {        
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerContext = filterContext.Controller.ControllerContext;
            var parameters = filterContext.ActionParameters;

            var descriptor = filterContext.ActionDescriptor;
            var result = descriptor.Execute(controllerContext, parameters) ?? new EmptyResult();

            var actionResult = (result as ActionResult) ??
                new JsonResult
                {
                    Data = result                    
                };
            
            filterContext.Result = actionResult;
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

    }
}
